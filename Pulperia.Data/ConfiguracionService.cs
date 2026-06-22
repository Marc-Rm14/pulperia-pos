using System.Text.Json;
using Pulperia.Domain.Entities;
using Pulperia.Common;
using System.Diagnostics;

namespace Pulperia.Data
{
    public class ConfiguracionService
    {
        private readonly string _configPath;
        private readonly string _carpetaBase;
        private readonly CriptografiaService _Seguridad;



        public ConfiguracionService(string path) 
        {
            _carpetaBase = path;
            Debug.WriteLine(_carpetaBase);
                
            _configPath = Path.Combine(path, "config.json");


            _Seguridad = new CriptografiaService();


            
        }

        public bool ExisteBaseDatosEnCarpetaSegura()
        {
            string destino = Path.Combine(_carpetaBase, "pulperia.db");
            return File.Exists(destino) ;
        }

        public bool EstaConfigurado() 
        {
            return File.Exists(_configPath);
        }


        public string CargarConexion()
        {

            try
            {

                string jsonContent = File.ReadAllText(_configPath);


                //Si al deserializar el archivo esta vacio creamos una intancia nueva

                var savedConfig = JsonSerializer.Deserialize<ConfiguracionSistema>(jsonContent)
                    ?? new ConfiguracionSistema();




                return $"Data Source={savedConfig.RutaBaseDatos}; Password={_Seguridad.DesencriptarBaseDatos(savedConfig.contrasena)}  ";


            }
            catch (JsonException)
            { 
               
                return $"Data Source ={Path.Combine(_carpetaBase, "pulperia.db")}";
            }
        }



        /*public bool GuardarConexion (string ruta, string contrasenaPlana)
        {
            try 
            {

                string directorio = Path.GetDirectoryName(_configPath) ?? _carpetaBase;

                Debug.WriteLine(directorio);

                //verificamos que exista el directorio de proyecto antes de guardar

                if (!Directory.Exists(directorio)) Directory.CreateDirectory(directorio);

                ConfiguracionSistema config = new() { RutaBaseDatos = ruta, contrasena = _Seguridad.EncriptarBaseDatos(contrasenaPlana) };

                string json = JsonSerializer.Serialize(config, new JsonSerializerOptions { WriteIndented = true });


                File.WriteAllText(_configPath, json);

                return true;
            }
            catch (Exception )
            {

                return false;

            }
        }*/


        public bool ImportarYGuardarConexion(string rutaOrigen, string contrasenaPlana, bool sobreescribir = false)
        {
            try
            {
                if (!Directory.Exists(_carpetaBase)) Directory.CreateDirectory(_carpetaBase);

                string rutaDestino = Path.Combine(_carpetaBase, "pulperia.db");

                // Solo copiamos si el origen es un archivo externo diferente
                if (string.Compare(rutaOrigen, rutaDestino, StringComparison.OrdinalIgnoreCase) != 0)
                {
                    File.Copy(rutaOrigen, rutaDestino, sobreescribir);
                }

                ConfiguracionSistema config = new()
                {
                    RutaBaseDatos = rutaDestino,
                    contrasena = _Seguridad.EncriptarBaseDatos(contrasenaPlana)
                };

                string json = JsonSerializer.Serialize(config, new JsonSerializerOptions { WriteIndented = true });
                File.WriteAllText(_configPath, json);

                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }
   }    

}
