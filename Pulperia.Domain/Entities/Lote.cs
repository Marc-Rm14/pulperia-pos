using System;
using System.Collections.Generic;
using System.Text;

namespace Pulperia.Domain.Entities
{
    public class Lote
    {
        public int Id { get; set; }
        public int IdEntrada { get; set; }
        public int IdProducto { get; set; }
        public double CantidadInicial { get; set; }
        public string FechaVencimiento { get; set; }  = string.Empty;
        public int EstaActivo { get; set; }
        public int CostoUnitario { get; set; }

        // Propiedad de navegación: Aquí Dapper inyectará los datos del producto
        public Producto ProductoAsociado { get; set; }
    }
}
