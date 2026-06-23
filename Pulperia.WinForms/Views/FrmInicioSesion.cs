using Pulperia.Domain.DTOS;
using Pulperia.Business.Seguridad;

namespace Pulperia.WinForms.Views
{
    public partial class FrmInicioSesion : Form
    {
        private const string txtusuarioPlaceholder = "Usuario";
        private const string txtcontrasenaPlaceholder = "Contraseña";


        private readonly ServicioAutenticacion _servicioAutenticar;


        public UserSession? UsuarioLogueado { get; private set; }
        public FrmInicioSesion(ServicioAutenticacion ServicioAutenticar)
        {
            InitializeComponent();

            _servicioAutenticar = ServicioAutenticar;
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            // Valida que no envíen campos vacíos o con el placeholder
            if (string.IsNullOrWhiteSpace(txtUsuario.Text) || txtUsuario.Text == txtusuarioPlaceholder ||
                string.IsNullOrWhiteSpace(txtContrasena.Text) || txtContrasena.Text == txtcontrasenaPlaceholder)
            {
                MessageBox.Show("Por favor, ingrese sus credenciales.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string nombre = txtUsuario.Text;
            string contrasena = txtContrasena.Text;


            var resultado = _servicioAutenticar.Autenticar(nombre, contrasena);

            if (resultado.EsExitoso)
            {
                UsuarioLogueado = resultado.UserSession;
                this.DialogResult = DialogResult.OK;
                return;
            }

            // Si falló, limpiamos el campo específico según el tipo de error
            if (resultado.TipoFallo == TipoFallo.UsuarioNoEncontrado)
                txtUsuario.Clear();
            else
                txtContrasena.Clear();

            // Mensaje unificado para ambos errores
            MessageBox.Show("Usuario o contraseña incorrectos.", "Error de Autenticación", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            if (txtUsuario.Text == txtusuarioPlaceholder)
            {
                txtUsuario.Text = "";
            }
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "")
            {
                txtUsuario.Text = txtusuarioPlaceholder;
            }
        }

        private void FrmInicioSesion_Enter(object sender, EventArgs e)
        {
            if (txtContrasena.Text == txtcontrasenaPlaceholder)
            {
                txtContrasena.Text = "";
            }
        }

        private void txtContrasena_Leave(object sender, EventArgs e)
        {
            if (txtContrasena.Text == "")
            {
                txtContrasena.Text = txtcontrasenaPlaceholder;
                txtContrasena.PasswordChar = '\0';
                txtContrasena.UseSystemPasswordChar = false;
            }
            else
            {
                txtContrasena.PasswordChar = '*';
                txtContrasena.UseSystemPasswordChar = true;
            }
        }

        private void txtContrasena_Enter(object sender, EventArgs e)
        {
            if (txtContrasena.Text == txtcontrasenaPlaceholder)
            {
                txtContrasena.Text = "";
            }
        }

        private void txtContrasena_TextChanged(object sender, EventArgs e)
        {
            if (txtContrasena.Text != "Contraseña")
            {
                txtContrasena.PasswordChar = '*';
                txtContrasena.UseSystemPasswordChar = true;
            }
        }
    }

}
