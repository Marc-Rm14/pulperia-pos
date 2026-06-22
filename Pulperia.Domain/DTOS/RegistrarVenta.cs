using System;
using System.Collections.Generic;
using System.Text;

namespace Pulperia.Domain.DTOS
{
    public class RegistrarVenta
    {
        public int IdUsuario { get; set; }
        public List<DetalleVentaVista> Detalles { get; set; } = new List<DetalleVentaVista>();

        // Corrección: Calculamos directo sobre los centavos para no perder nada
        public int TotalVentaCentavos => (int)Detalles.Sum(d => d.Cantidad * d.PrecioVentaCentavos);

        // Propiedad extra que te servirá muchísimo para mostrar el TOTAL en la UI:
        public decimal TotalVisual => Detalles.Sum(d => d.Subtotal);
    }
}
