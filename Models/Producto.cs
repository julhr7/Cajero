using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace Cajero.Models
{
    public class Producto
    {
        [Required(ErrorMessage = "Ingrese código")]
        public string codigo {  get; set; }

        [Required(ErrorMessage = "Ingrese producto")]
        public string producto { get; set; }

        [Required(ErrorMessage = "Ingrese precio")]
        public decimal precio { get; set; }

        [Required(ErrorMessage = "Ingrese cantidad")]
        public int cantidad { get; set; }

        //public decimal? subtotal { get { return precio * cantidad; } }

        public decimal subtotal { get; set; }

        public bool tea { get; set; }
        public bool fresa { get; set; }
        public bool cafe { get; set; }
    }
}
