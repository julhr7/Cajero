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
            Producto newItem = new Producto();
            newItem = producto;

            newItem.subtotal =
                newItem.tea && newItem.cantidad > 1 ?
                    (newItem.cantidad - 1) * newItem.precio :
                newItem.fresa && newItem.cantidad >= 3 ?
                        newItem.cantidad * newItem.precio - Convert.ToDecimal(4.5) :
                newItem.cafe && newItem.cantidad >= 3 ?
                     Math.Round(newItem.cantidad * (newItem.precio - newItem.precio * 2 / 3), 2) :
                newItem.cantidad * newItem.precio;


            productoDto.ProductoList.Add(newItem);
        }
    }
}
