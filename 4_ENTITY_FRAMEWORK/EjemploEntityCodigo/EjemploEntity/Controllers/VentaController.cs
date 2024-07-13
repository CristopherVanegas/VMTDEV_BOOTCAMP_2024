﻿using EjemploEntity.Interface;
using EjemploEntity.Models;
using EjemploEntity.Utilitarios;
using Microsoft.AspNetCore.Mvc;

namespace EjemploEntity.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class VentaController : Controller
    {
        private readonly IVentas _ventas;
        private ControlError Log = new ControlError();

        public VentaController(IVentas ventas)
        {
            this._ventas = ventas;
        }

        [HttpGet]
        [Route("GetVentaCliente")]
        public async Task<Respuesta> GetVentaCliente(int? numFact, string? fecha, string? vendedor, double? precio, int clienteId)
        {
            var respuesta = new Respuesta();
            try
            {
                respuesta = await _ventas.GetVentaCliente(numFact, fecha, vendedor, precio, clienteId);
            }
            catch (Exception ex)
            {
                respuesta.Cod = "999";
                Log.LogErrorMetodos("VentaController", "GetVentaCliente", ex.Message);
            }
            return respuesta;
        }

        [HttpPost]
        [Route("PostVenta")]
        public async Task<Respuesta> PostVenta([FromBody] Venta venta)
        {
            var respuesta = new Respuesta();
            try
            {
                respuesta = await _ventas.PostVenta(venta);
            }
            catch (Exception ex)
            {
                respuesta.Cod = "999";
                Log.LogErrorMetodos("VentaController", "PostVenta", ex.Message);
            }
            return respuesta;
        }

        //[HttpPut]
        //[Route("PutVenta")]
        //public async Task<Respuesta> PutVenta([FromBody] Venta venta)
        //{
        //    var respuesta = new Respuesta();
        //    try
        //    {
        //        respuesta = await _ventas.PutVenta(venta);
        //    }
        //    catch (Exception)
        //    {

        //        throw;
        //    }
        //    return respuesta;
        //}

        [HttpGet]
        [Route("GetVenta")]
        public async Task<Respuesta> GetVenta()
        {
            var respuesta = new Respuesta();
            try
            {
                respuesta = await _ventas.GetVenta(); // llama al metodo de Interfaz venta
            }
            catch (Exception ex)
            {
                respuesta.Cod = "999";
                Log.LogErrorMetodos("VentaController", "GetVenta", ex.Message);
            }
            return respuesta;
        }
    }
}