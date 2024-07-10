using System.Collections.Generic;
using System.Linq;

namespace Cajero.Models.DTO
{
    public class ProductoDto
    {
        public ProductoDto()
        {
            this.ProductoList = new List<Producto>();
        }
        public List<Producto> ProductoList { get; set; }
        public decimal? total
        {
            get { return ProductoList.Sum(x => x.subtotal); }
        }
    }
}
