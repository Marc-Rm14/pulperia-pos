using System;
using System.Collections.Generic;
using System.Text;
using Pulperia.Data.Repositories;
using Pulperia.Domain.Interfaces;
using Pulperia.Domain.DTOS;
namespace Pulperia.Business
{
    public class VentaService
    {
        private readonly VentaRepository _ventaRepository;


        private readonly IProductoRepository _productoRepository;


        public VentaService(VentaRepository ventaRepository, IProductoRepository productoRepository)
        {
            _ventaRepository = ventaRepository;
            _productoRepository = productoRepository;
        }

        public void RegistrarNuevaVenta(RegistrarVenta ventaDto)
        {
            // REGLA DE NEGOCIO 1: Validar que el DTO contenga datos (Seguridad del Backend)
            if (ventaDto == null || !ventaDto.Detalles.Any())
            {
                throw new ArgumentException("La venta no contiene productos para procesar.");
            }

            // REGLA DE NEGOCIO 2: Validar stock en el servidor antes de vender
            foreach (var item in ventaDto.Detalles)
            {
                var producto = _productoRepository.ObtenerPorId(item.IdProducto);

                if ((decimal)producto.StockActual < item.Cantidad)
                {
                    // Lanzas una excepción controlada si el pulpero intentó vender más de lo que hay
                    throw new InvalidOperationException($"No hay suficiente stock para el producto: {item.NombreProducto}. Stock disponible: {producto.StockActual}");
                }
            }

            // Si pasa todas las reglas de negocio, llamamos al Repositorio para que haga la Transacción SQL
            bool guardadoExitoso = _ventaRepository.ProcesarVenta(ventaDto);

            if (!guardadoExitoso)
            {
                throw new Exception("Ocurrió un error inesperado en la base de datos al guardar la venta.");
            }
        }
    }
}
