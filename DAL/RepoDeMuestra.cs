using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Text;

namespace DAL
{
    internal class RepoDeMuestra
    {
        public void GuardarMuestraConEspacio(string titulo, string descripcion, DateTime inicio, DateTime fin, string nombreEsp, string dirEsp, int capEsp)
        {
            string cadenaConexion = ConfigurationManager.ConnectionStrings["MiConexionSQL"].ConnectionString;

            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
                conexion.Open();

                // 2. Usamos una Transacción SQL: Si falla la muestra, no se guarda el espacio huérfano.
                using (SqlTransaction transaccion = conexion.BeginTransaction())
                {
                    try
                    {
                        // --- PASO A: GUARDAR EL ESPACIO ---
                        // SCOPE_IDENTITY() nos devuelve el ID que SQL le acaba de inventar a este espacio
                        string queryEspacio = @"INSERT INTO Espacios (Nombre, Direccion, Capacidad) 
                                                VALUES (@nom, @dir, @cap);
                                                SELECT SCOPE_IDENTITY();";

                        using (SqlCommand cmdEspacio = new SqlCommand(queryEspacio, conexion, transaccion))
                        {
                            cmdEspacio.Parameters.AddWithValue("@nom", nombreEsp);
                            cmdEspacio.Parameters.AddWithValue("@dir", dirEsp);
                            cmdEspacio.Parameters.AddWithValue("@cap", capEsp);

                            // Ejecutamos y atrapamos el ID generado
                            int idEspacioGenerado = Convert.ToInt32(cmdEspacio.ExecuteScalar());

                            // --- PASO B: GUARDAR LA MUESTRA ---
                            // Ahora usamos ese idEspacioGenerado para vincular la Muestra
                            string queryMuestra = @"INSERT INTO Muestras (Titulo, Descripcion, FechaInicio, FechaFin, IdEspacio) 
                                                    VALUES (@tit, @desc, @ini, @fin, @idEsp)";

                            using (SqlCommand cmdMuestra = new SqlCommand(queryMuestra, conexion, transaccion))
                            {
                                cmdMuestra.Parameters.AddWithValue("@tit", titulo);
                                cmdMuestra.Parameters.AddWithValue("@desc", descripcion);
                                cmdMuestra.Parameters.AddWithValue("@ini", inicio);
                                cmdMuestra.Parameters.AddWithValue("@fin", fin);
                                cmdMuestra.Parameters.AddWithValue("@idEsp", idEspacioGenerado); // ¡Acá está la composición!

                                cmdMuestra.ExecuteNonQuery();
                            }
                        }

                        // Si llegamos hasta acá sin errores, confirmamos el guardado de ambas tablas
                        transaccion.Commit();
                    }
                    catch (Exception ex)
                    {
                        // Si algo explota (ej: se corta la conexión), deshacemos todo para no dejar datos a medias
                        transaccion.Rollback();
                        throw new Exception("Error en la base de datos: " + ex.Message);
                    }
                }
            }
        }
    }
}
}
