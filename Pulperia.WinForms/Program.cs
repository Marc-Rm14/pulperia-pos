using Pulperia.Business;
using Pulperia.Business.Seguridad;
using Pulperia.Data;
using Pulperia.Data.Repositories;
using Pulperia.Domain.DTOS;
using Pulperia.Domain.Interfaces;
using Pulperia.WinForms.Views;
using System.Diagnostics;



namespace Pulperia.WinForms
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            

            //Configuramos la ruta principal
            string systemPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);


            //Convinamos la carpeta con la ruta
            string carpetaProyecto = Path.Combine(systemPath, "PulperiaSistema");




            ConfiguracionService servicio = new(carpetaProyecto);


            Debug.WriteLine(servicio.ExisteBaseDatosEnCarpetaSegura());
            Debug.WriteLine(servicio.EstaConfigurado());
            //Se verifica que exista el archivo de configuracion
            if (!servicio.EstaConfigurado() || !servicio.ExisteBaseDatosEnCarpetaSegura())
            {

                using (FrmConfiguracion frm = new FrmConfiguracion(carpetaProyecto))
                {
                    // Si da "Cancelar" en el formulario principal, aquí sí es correcto cerrar la app
                    if (frm.ShowDialog() != DialogResult.OK)
                    {
                        return;
                    }

                    string rutaElegida = frm.RutaSeleccionada;
                    string contrasena = frm.contraseña;



                    // Si la ruta elegida terminó siendo la misma de destino (porque el usuario presionó 'No' en el cuadro de diálogo),
                    // el método 'ImportarYGuardarConexion' sabe que no debe auto-copiarse y solo guardará el JSON.
                    bool seGuardo = servicio.ImportarYGuardarConexion(rutaElegida, contrasena, sobreescribir: true);

                    if (!seGuardo)
                    {
                        MessageBox.Show("No se pudo guardar la configuración", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                
            }


            

            string conexion = servicio.CargarConexion();


            DbContext dbContext = new(conexion);



            IUsuarioRepository usuarioRepository = new UsuarioRepository(dbContext);
            IProductoRepository productoRepository = new ProductoRepository(dbContext);
            ICategoriaRepository categoriaRepository = new CategoriaRepository(dbContext);



            ServicioAutenticacion servicioAutenticar = new(usuarioRepository);

            UserSession? usuarioLogueado = null;

            //Pon esto temporalmente en algún lado que se ejecute al arrancar:
            /*var seguridad = new CriptografiaService();
            string hashDePrueba = seguridad.Hash("admin123");
            System.Diagnostics.Debug.WriteLine($"Copia este hash: {hashDePrueba}");*/

            using (FrmInicioSesion frmInicio = new(servicioAutenticar)) 
            {
                if (frmInicio.ShowDialog() != DialogResult.OK) return;


                usuarioLogueado = frmInicio.UsuarioLogueado;
            }

            
            VentaRepository ventaRepository = new VentaRepository(dbContext);


            VentaService ventaService = new VentaService(ventaRepository, productoRepository);

            Application.Run(new FrmPrincipal(productoRepository, categoriaRepository, ventaService));
        }
    }
}