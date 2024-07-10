using Cajero.Interfaces;
using Cajero.Models;
using Cajero.Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Cajero.Repository
{
    public class ProductoRepository : IProductoRepository
    {
        public static ProductoDto productoDto = new ProductoDto();

        ProductoDto IProductoRepository.Producto => productoDto;

        public void guardar(Producto producto)
        {
            ICalcularDescuento calcular = null;
            if (producto.tea) calcular = new CalcularDescuentoTe();
            if (producto.fresa) calcular = new CalcularDescuentoFresa();
            if (producto.cafe) calcular = new CalcularDescuentoCafe();
            producto.subtotal = calcular.CalcularDescuento(producto);
            
            productoDto.ProductoList.Add(producto);
        }
    }
}
