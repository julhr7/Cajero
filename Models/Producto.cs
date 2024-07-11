using System.ComponentModel.DataAnnotations;

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

        public decimal subtotal { get; set; }

        public CalcularTipo descuento { get; set; }
    }
}
