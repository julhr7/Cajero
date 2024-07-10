using Cajero.Models.DTO;
using Cajero.Models;
using System.Collections.Generic;

namespace Cajero.Repository
{
    public class ProductoLista
    {
        public static ProductoDto productoDto = new ProductoDto();
        public static IEnumerable<Producto> Responses
        {
            get
            {
                return productoDto.ProductoList;
            }
        }
    }
}
