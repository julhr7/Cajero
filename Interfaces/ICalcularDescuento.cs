using Cajero.Models;

namespace Cajero.Interfaces
{
    public interface ICalcularDescuento
    {
        decimal CalcularDescuento(Producto producto);
    }
}
