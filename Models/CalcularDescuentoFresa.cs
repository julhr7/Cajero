using Cajero.Interfaces;
using System;

namespace Cajero.Models
{
    public class CalcularDescuentoFresa : ICalcularDescuento
    {
        public decimal CalcularDescuento(Producto producto)
        {
            return producto.cantidad >= 3 ?
                        producto.cantidad * producto.precio - Convert.ToDecimal(4.5) :
                producto.cantidad * producto.precio;
        }
    }
}
