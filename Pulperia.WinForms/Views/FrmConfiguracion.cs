namespace Pulperia.WinForms.Views
{
    public partial class FrmConfiguracion : Form
    {

        public string RutaSeleccionada { get; private set; } = string.Empty;

        public string contraseña { get; private set;  } = string.Empty;


        private readonly string _carpetaSegura;

        public FrmConfiguracion(string CarpetaSegura)
        {
            InitializeComponent();

            _carpetaSegura = CarpetaSegura;

            txtRutaActual.Text = "Ningun archivo Seleccionado...";
        }

        private void btnExaminar_Click(object sender, EventArgs e)
        {
            if (openFileDialogBaseDatos.ShowDialog() == DialogResult.OK)
            {
                try
                {

                    RutaSeleccionada = openFileDialogBaseDatos.FileName;

                    txtRutaActual.Text = string.Empty;
                    txtRutaActual.Text = RutaSeleccionada;


                }
                catch (Exception) { }
            }

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(RutaSeleccionada)) 
            {
                MessageBox.Show("Por favor, seleccione una ruta válida antes de continuar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string posibleRuta = Path.Combine(_carpetaSegura, "pulperia.db");


            if (File.Exists(posibleRuta))
            {
                var resultado = MessageBox.Show(
                    "Ya existe una base de datos en la carpeta segura.\n\n¿Desea reemplazarla con el archivo seleccionado?\n\n[Sí] para reemplazar.\n[No] para usar la base de datos que ya existía en la carpeta segura.",
                    "Confirmar Importación",
                    MessageBoxButtons.YesNoCancel,
                    MessageBoxIcon.Question
                );

                if (resultado == DialogResult.Cancel)
                {
                    // No hace nada, el formulario se queda abierto para que el usuario decida qué hacer
                    return;
                }
                else if (resultado == DialogResult.No)
                {
                    // El usuario decide mantener la base de datos que ya existía en Roaming
                    RutaSeleccionada = posibleRuta;
                }
                // Si elige "Sí", RutaSeleccionada se queda como la de Documentos para ser copiada encima
            }



            if (!string.IsNullOrWhiteSpace(txtContrasena.Text)) 
            {
                contraseña = txtContrasena.Text;
            }

            this.DialogResult = DialogResult.OK;
        }
    }
}
