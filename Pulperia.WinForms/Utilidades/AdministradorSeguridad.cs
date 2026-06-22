using System.Security.Cryptography;
using System.Text;

namespace Pulperia.WinForms.Utilidades;

public class AdministradorSeguridad
{

    public string Encriptar(string s)
    {

        if (string.IsNullOrWhiteSpace(s)) return string.Empty;


        byte[] datoProtegidos = Encoding.UTF8.GetBytes(s);

        byte[] datosEncriptados = ProtectedData.Protect(datoProtegidos, null, DataProtectionScope.CurrentUser);


        string base64Encriptado = Convert.ToBase64String(datosEncriptados);


        return base64Encriptado;
    }




    public string Desencriptar(string s)
    {
        if (string.IsNullOrWhiteSpace(s)) return string.Empty;



        try
        {
            byte[] bytesEncriptados = Convert.FromBase64String(s);


            byte[] datosDesprotegidos = ProtectedData.Unprotect(bytesEncriptados, null, DataProtectionScope.CurrentUser);


            string contraseña = Encoding.UTF8.GetString(datosDesprotegidos);


            return contraseña;
        }
        catch (Exception)
        {

            return string.Empty;
        }
    }
}


