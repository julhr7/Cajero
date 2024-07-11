namespace Cajero.Models
{
    public class CalcularDescuentoTe : CalcularDescuento
    {
        public override void Calcular(Producto producto)
        {
            producto.subtotal =  producto.cantidad > 1 ?
                    (producto.cantidad - 1) * producto.precio :
                    producto.cantidad * producto.precio;
        }
    }
}
