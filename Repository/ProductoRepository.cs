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

        

        //public static IEnumerable<Producto> Responses
        //{
        //    get
        //    {
        //        return responsesDto.ProductoList;
        //    }
        //}
        //public static void AddResponse(Producto response)
        //{
        //    Producto newItem = new Producto();
        //    newItem = response;

        //    response.subtotal =
        //        response.tea && response.cantidad > 1 ?
        //            (response.cantidad - 1) * response.precio :
        //        response.fresa && response.cantidad >= 3 ?
        //                response.cantidad * response.precio - Convert.ToDecimal(4.5) :
        //        response.cafe && response.cantidad >= 3 ?
        //             Math.Round(response.cantidad * (response.precio - response.precio * 2 / 3), 2) :
        //        response.cantidad * response.precio;


        //    responsesDto.ProductoList.Add(newItem);
        //}

        //public IEnumerable<Producto> Lista()
        //{
        //    return productoDto.ProductoList();
        //}
        //IEnumerable<Producto> IProductoRepository.Lista => throw new NotImplementedException();
        IEnumerable<Producto> IProductoRepository.Lista => productoDto.ProductoList;
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
