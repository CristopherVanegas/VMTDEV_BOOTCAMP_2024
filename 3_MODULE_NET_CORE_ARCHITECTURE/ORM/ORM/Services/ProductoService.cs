using Microsoft.AspNetCore.Mvc;
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
        public async Task<List<Producto>> GetListaProductosPrecio(double valor)
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

        public async Task<Respuesta> PostProducto([FromBody] Producto producto)
        {
            var respuesta = new Respuesta();

            try
            {
                var query = _context.Productos.OrderByDescending(x => x.ProductoId).Select(x => x.ProductoId).FirstOrDefault();

                producto.ProductoId = Convert.ToInt32(query) + 1;
                producto.FechaHoraReg = DateTime.Now;

                _context.Productos.Add(producto);
                await _context.SaveChangesAsync();

                respuesta.Cod = "000";
                respuesta.Mensaje = "Se inserto correctamente";
            }
            catch (Exception ex)
            {
                respuesta.Cod = "999";
                respuesta.Mensaje = $"Se presenta un error: {ex.Message}";
                throw;
            }
            return respuesta;
        }

        public async Task<Respuesta> PutProducto(Producto producto)
        {
            var respuesta = new Respuesta();

            try
            {
                _context.Productos.Update(producto);
                await _context.SaveChangesAsync();

                respuesta.Cod = "000";
                respuesta.Mensaje = "Se inserto correctamente";
            }
            catch (Exception ex)
            {
                respuesta.Cod = "999";
                respuesta.Mensaje = $"Se presenta un error: {ex.Message}";
                throw;
            }
            return respuesta;
        }
    }
}
