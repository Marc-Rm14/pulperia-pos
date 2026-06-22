using System;
using System.Collections.Generic;
using System.Text;

namespace Pulperia.Domain.Entities
{
    public class DetalleVenta
    {
        public int Id { get; set; }

        public int IdVenta { get; set; }

        public int IdProducto { get; set; }
        
        public double Cantidad { get; set; }


        public int PrecionUnitario { get; set; }
    }
}
