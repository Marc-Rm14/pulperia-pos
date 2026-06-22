using System;
using System.Text;
using System.Security.Cryptography;
using System.Runtime.Versioning;
using BCrypt.Net;


namespace Pulperia.Common
{
    [SupportedOSPlatform("windows")]
    public class CriptografiaService 
    {
        public string EncriptarBaseDatos(string s)
        {

            if (string.IsNullOrWhiteSpace(s)) return string.Empty;


            byte[] datoProtegidos = Encoding.UTF8.GetBytes(s);

            byte[] datosEncriptados = ProtectedData.Protect(datoProtegidos, null, DataProtectionScope.CurrentUser);


            string base64Encriptado = Convert.ToBase64String(datosEncriptados);


            return base64Encriptado;
        }




        public string DesencriptarBaseDatos(string s)
        {
            if (string.IsNullOrWhiteSpace(s)) return string.Empty;



            try
            {
                byte[] bytesEncriptados = Convert.FromBase64String(s);


                byte[] datosDesprotegidos = ProtectedData.Unprotect(bytesEncriptados, null, DataProtectionScope.CurrentUser);


                string contraseña = Encoding.UTF8.GetString(datosDesprotegidos);


                return contraseña;
            }
            catch (Exception ex)
            {

                return string.Empty;
            }
        }


        public string Hash(string contrasena) 
        {
            return BCrypt.Net.BCrypt.HashPassword(contrasena);
        }



        public bool Verificar(string contrasena, string hash) 
        {
            return BCrypt.Net.BCrypt.Verify(contrasena, hash);
        }
    }
    
}
