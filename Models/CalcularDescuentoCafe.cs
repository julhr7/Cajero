using System;

namespace Cajero.Models
{
    public class CalcularDescuentoCafe : CalcularDescuento
    {
        public override void Calcular(Producto producto)
        {
            producto.subtotal = producto.cantidad >= 3 ?
                Math.Round(producto.cantidad * (producto.precio - producto.precio * 2 / 3), 2) :
                producto.cantidad * producto.precio;
        }
    }
}
