using System;
using System.Collections.Generic;
using System.Text;

namespace Pulperia.Domain.Events
{
    public static class InventarioEvents
    {
        // Este evento se disparará cuando una venta sea confirmada
        public static event Action VentaProcesada;

        // Método para invocar el evento
        public static void NotificarVenta()
        {
            VentaProcesada?.Invoke();
        }
    }
}
