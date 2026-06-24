using System;
using System.Collections.Generic;
using System.Text;

namespace Pulperia.Domain.DTOS
{
    public class FacturaDatos
    {
        public string NumeroFactura { get; set; } = string.Empty;
        public string NombreCliente { get; set; } = string.Empty;
        public DateTime Fecha { get; set; }

        
        public List<DetalleVentaVista> Items { get; set; } = new List<DetalleVentaVista>();

        // Propiedades calculadas automáticas basadas en tus centavos convertidos
        public decimal Total => Items.Sum(i => i.Subtotal);
    }
}
