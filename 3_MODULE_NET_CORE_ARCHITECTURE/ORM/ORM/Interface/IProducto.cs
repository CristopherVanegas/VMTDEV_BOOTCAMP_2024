using Microsoft.AspNetCore.Mvc;
using ORM.Models;

namespace ORM.Interface
{
    public interface IProducto
    {
        Task<List<Producto>> GetListaProductos(int productoID);
        Task<List<Producto>> GetListaProductosPrecio(double valor);
        Task<Respuesta> PostProducto(Producto producto);
        Task<Respuesta> PutProducto(Producto producto);
    }
}
