using Cajero.Interfaces;

namespace Cajero.Models
{
    public class CalcularDescuentoTe : ICalcularDescuento
    {
        public decimal CalcularDescuento(Producto producto)
        {
            return producto.cantidad > 1 ?
                    (producto.cantidad - 1) * producto.precio: 
                    producto.cantidad * producto.precio; ;
        }
    }
}
