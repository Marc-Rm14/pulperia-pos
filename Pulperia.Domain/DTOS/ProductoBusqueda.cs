using System;
using System.Collections.Generic;
using System.Text;

namespace Pulperia.Domain.DTOS
{
    public class ProductoBusqueda
    {
        public int IdProducto { get; set; }
        public string Nombre { get; set; } = string.Empty;
        // Esta recibe el valor crudo de la DB (ej: 2400)
        public int PrecioVenta { get; set; }

        // Esta la usas para mostrar en la interfaz (ej: 24.00)
        public decimal PrecioVentaDecimal => PrecioVenta / 100m;
        public double StockTotal { get; set; }


        public string Descripcion
            {
            get => $"{Nombre} - {StockTotal}";
        }
    }
}
