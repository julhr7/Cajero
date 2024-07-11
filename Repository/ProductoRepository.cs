using Cajero.Models;
using Cajero.Models.DTO;
using System;

namespace Cajero.Repository
{
    public class ProductoRepository : IProductoRepository
    {
        public static ProductoDto productoDto = new ProductoDto();

        ProductoDto IProductoRepository.Producto => productoDto;

        public void guardar(Producto producto)
        {
            var factory = new CalcularFactory();
            var calular = factory.create(producto);
            calular.Calcular(producto);
            productoDto.ProductoList.Add(producto);
        }
    }
}
