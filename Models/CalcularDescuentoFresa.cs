using System;

namespace Cajero.Models
{
    public class CalcularDescuentoFresa : CalcularDescuento
    {
        public override void Calcular(Producto producto)
        {
            producto.subtotal = producto.cantidad >= 3 ?
                       producto.cantidad * producto.precio - Convert.ToDecimal(4.5) :
               producto.cantidad * producto.precio;
        }
    }
}
