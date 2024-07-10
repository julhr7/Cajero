using Cajero.Interfaces;
using System;

namespace Cajero.Models
{
    public class CalcularDescuentoCafe : ICalcularDescuento
    {
        public decimal CalcularDescuento(Producto producto)
        {
            return producto.cantidad >= 3 ?
                Math.Round(producto.cantidad * (producto.precio - producto.precio * 2 / 3), 2) :
                producto.cantidad * producto.precio;
        }
    }
}
