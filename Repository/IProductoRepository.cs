using Cajero.Models;
using Cajero.Models.DTO;
using System.Collections.Generic;

namespace Cajero.Repository
{
    public interface IProductoRepository
    {
        ProductoDto Producto { get; }

        void guardar(Producto producto);
    }
}
