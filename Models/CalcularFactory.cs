using System;

namespace Cajero.Models
{
    public class CalcularFactory
    {
        public CalcularDescuento create(Producto producto) {
            try
            {
                return (CalcularDescuento)Activator.CreateInstance(Type.GetType($"Cajero.Models.CalcularDescuento{producto.descuento}"));
            }
            catch
            {
                return null;
            }
        }
    }
}
