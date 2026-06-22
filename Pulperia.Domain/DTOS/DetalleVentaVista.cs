using System;
using System.Collections.Generic;
using System.Text;

namespace Pulperia.Domain.DTOS
{
    public class DetalleVentaVista
    {
        public int IdProducto { get; set; }
        public string NombreProducto { get; set; } = string.Empty;
        public decimal Cantidad { get; set; }
        public int PrecioVentaCentavos { get; set; }

        public decimal PrecioUnitario => PrecioVentaCentavos / 100m;
        public decimal Subtotal => Cantidad * PrecioUnitario;
    }
}
