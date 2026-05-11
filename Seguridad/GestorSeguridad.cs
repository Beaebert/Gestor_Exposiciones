using System.Security.Cryptography;
using System.Text;
using DAL; // Referencia a capa DAL

namespace GestorExposiciones.Seguridad
{
    public class GestorSeguridad
    {
            private AccesoADatos dal = new AccesoADatos();

            // 1. Método para encriptar la contraseña (SHA256)
            private string EncriptarClave(string textoPlano)
            {
                using (SHA256 sha256Hash = SHA256.Create())
                {
                    byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(textoPlano));
                    StringBuilder constructor = new StringBuilder();
                    for (int i = 0; i < bytes.Length; i++)
                    {
                        constructor.Append(bytes[i].ToString("x2"));
                    }
                    return constructor.ToString();
                }
            }

            // 2. Método público para que la UI pida registrar
            public bool Registrar(string usuario, string passwordPlana)
            {
                string passEncriptada = EncriptarClave(passwordPlana);
                return dal.RegistrarUsuario(usuario, passEncriptada);
            }

            // 3. Método público para que la UI pida ingresar
            public bool Ingresar(string usuario, string passwordPlana)
            {
                string passEncriptada = EncriptarClave(passwordPlana);
                return dal.VerificarUsuario(usuario, passEncriptada);
            }
        
    }
}