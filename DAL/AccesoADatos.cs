using System;
using System.Data.SqlClient;
using System.Configuration;

namespace DAL
{
    public class AccesoADatos
    {
        // Leer la conexión (App.config)
        private string cadenaConexion = ConfigurationManager.ConnectionStrings["MiConexion"].ConnectionString;

        // Método para registrar el usuario en la BD
        public bool RegistrarUsuario(string usuario, string passwordEncriptada)
        {
            // Recordar el SQL Embebido
            string query = "INSERT INTO Usuarios (NombreUsuario, Password) VALUES (@user, @pass)";

            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
                SqlCommand cmd = new SqlCommand(query, conexion);
                cmd.Parameters.AddWithValue("@user", usuario);
                cmd.Parameters.AddWithValue("@pass", passwordEncriptada);

                conexion.Open();
                int filasAfectadas = cmd.ExecuteNonQuery();
                return filasAfectadas > 0; // Devuelve true si se guardó con éxito
            }
        }

        // Método para verificar si el usuario y clave existen
        public bool VerificarUsuario(string usuario, string passwordEncriptada)
        {
            string query = "SELECT COUNT(*) FROM Usuarios WHERE NombreUsuario = @user AND Password = @pass";

            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
                SqlCommand cmd = new SqlCommand(query, conexion);
                cmd.Parameters.AddWithValue("@user", usuario);
                cmd.Parameters.AddWithValue("@pass", passwordEncriptada);

                conexion.Open();
                int resultado = (int)cmd.ExecuteScalar();
                return resultado > 0; // Devuelve true si encontró una coincidencia exacta
            }
        }
    }
}