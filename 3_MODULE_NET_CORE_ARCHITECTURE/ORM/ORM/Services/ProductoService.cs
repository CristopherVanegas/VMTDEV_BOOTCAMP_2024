using Microsoft.EntityFrameworkCore;
using ORM.Interface;
using ORM.Models;

namespace ORM.Services
{
    public class ProductoService : IProducto
    {
        private readonly VentasContext _context;
        public ProductoService(VentasContext context) 
        {
            this._context = context;
        }
        public async Task<List<Producto>> GetListaProductos(int productoID)
        {
            var respuesta = new List<Producto>();
            try
            {
                if (productoID == 0)
                {
                    respuesta = await _context.Productos.ToListAsync();
                }
                else
                {
                    respuesta = await _context.Productos.Where(x => x.ProductoId.Equals(productoID)).ToListAsync();
                }
            }
            catch (Exception)
            {

                throw;
            }

            return respuesta;
        }
        public async Task<List<Producto>> GetListaProductosMayoresA(double valor)
        {
            var respuesta = new List<Producto>();
            try
            {
                if (valor == 0)
                {
                    respuesta = await _context.Productos.ToListAsync();
                }
                else
                {
                    respuesta = await _context.Productos.Where(x => x.Precio.Equals(valor)).ToListAsync();
                }
            }
            catch (Exception)
            {

                throw;
            }

            return respuesta;
        }
    }
}
