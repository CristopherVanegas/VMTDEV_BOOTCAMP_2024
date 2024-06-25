using ORM.Models;

namespace ORM.Interface
{
    public interface IProducto
    {
        Task<List<Producto>> GetListaProductos(int productoID);
    }
}
