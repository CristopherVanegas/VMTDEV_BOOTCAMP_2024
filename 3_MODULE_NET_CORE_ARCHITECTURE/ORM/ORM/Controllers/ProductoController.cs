﻿using Microsoft.AspNetCore.Mvc;
using ORM.Interface;
using ORM.Models;

namespace ORM.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductoController : Controller
    {
        private readonly IProducto _pproducto;

        public ProductoController(IProducto producto)
        {
            this._pproducto = producto;
        }

        [HttpGet]
        [Route("GetListaProductos")]
        public async Task<List<Producto>> GetListaProductos(int productoID)
        {
            var respuesta = new List<Producto>();
            try
            {
                respuesta = await _pproducto.GetListaProductos(productoID);
            }
            catch (Exception)
            {

                throw;
            }

            return respuesta;
        }

        [HttpGet]
        [Route("GetListaProductosPrecio")]
        public async Task<List<Producto>> GetListaProductosPrecio(double valor)
        {
            var respuesta = new List<Producto>();
            try
            {
                respuesta = await _pproducto.GetListaProductosPrecio(valor);
            }
            catch (Exception)
            {

                throw;
            }

            return respuesta;
        }

        [HttpPost]
        [Route("PostProducto")]
        public async Task<Respuesta> PostProducto([FromBody] Producto producto)
        {
            var respuesta = new Respuesta();
            try
            {
                respuesta = await _pproducto.PostProducto(producto);
            }
            catch (Exception)
            {

                throw;
            }
            return respuesta;
        }

        [HttpPut]
        [Route("PutProducto")]
        public async Task<Respuesta> PutProducto([FromBody] Producto producto)
        {
            var respuesta = new Respuesta();
            try
            {
                respuesta = await _pproducto.PutProducto(producto);
            }
            catch (Exception)
            {

                throw;
            }
            return respuesta;
        }
    }
}
