using Pulperia.Business;
using Pulperia.Domain.Interfaces;
using Pulperia.WinForms.UserControls;
using Pulperia.WinForms.Utilidades;
using Pulperia.Domain.DTOS;

namespace Pulperia.WinForms
{
    public partial class FrmPrincipal : Form
    {
        private readonly IProductoRepository? _productoRepo;
        private readonly ICategoriaRepository? _categoriaRepository;
        private readonly VentaService _ventaService;
        private readonly IUnidadMedidaRepository _unidadMedidaRepo;


        private readonly UserSession userSession;

        

        private readonly GestorVistas _gestorVistas;
        /*public FrmPrincipal() : this(null!, null!, null!)
        {
            // Dejar vacío. InitializeComponent() se llamará en el constructor principal.
        }*/



        public FrmPrincipal(IProductoRepository productoRepo, ICategoriaRepository categoriaRepository, VentaService ventaService, IUnidadMedidaRepository unidadMedidaRepository)
        {
            InitializeComponent();


           

            _ventaService = ventaService;
            _productoRepo = productoRepo;
            _unidadMedidaRepo = unidadMedidaRepository;

            _categoriaRepository = categoriaRepository;


            _gestorVistas = new(pnlContenedor);

            _gestorVistas.RegistrarVista("Ventas", () => new UCVentas(_productoRepo, _ventaService));
            _gestorVistas.RegistrarVista("Catalogo", () => new UcInventario(_productoRepo, _categoriaRepository, _unidadMedidaRepo)); // Si UcCatalogo no ocupa nada, va vacío.
        


        }

        private void BtnPuntoVenta_Click(object sender, EventArgs e)
        {
            

            _gestorVistas.CambiarVista("Ventas", false);


        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
               "¿Está seguro que desea salir del sistema de ventas?\n\nLos cambios no guardados se perderán.",
               "Salir del sistema",
               MessageBoxButtons.YesNo,
               MessageBoxIcon.Exclamation);

            if (result == DialogResult.Yes)
            {
                //salirDesdeBoton = true; // Indicamos que el cierre viene del botón
                this.Close(); // Esto dispara FormClosing
            }
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            
            // para que no se guarde en cache(false)
            // ver utilidades gestorVistas
            _gestorVistas.CambiarVista("Ventas", false);
        }

        private void btnCatalogo_Click(object sender, EventArgs e)
        {
            

            _gestorVistas.CambiarVista("Catalogo");
        }
    }
}
