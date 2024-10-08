﻿using EjemploEntity.Interface;
using EjemploEntity.Models;
using EjemploEntity.Utilitarios;
using Microsoft.EntityFrameworkCore;

namespace EjemploEntity.Services
{
    public class CatalogoService : ICatalogo
    {
        //INYECCION DE DEPENDENCIA
        private readonly VentasContext _context;
        private ControlError Log = new ControlError();

        public CatalogoService(VentasContext context)
        {
            this._context = context;
        }

        public async Task<Respuesta> GetCategoria()
        {
            var respuesta = new Respuesta();
            try
            {
                respuesta.Cod = "000";
                respuesta.Data = await _context.Categoria.ToListAsync();
                respuesta.Mensaje = "Se inserto correctamente";
            }
            catch (Exception ex)
            {
                respuesta.Cod = "999";
                Log.LogErrorMetodos("CatalogoService", "GetCategoria", ex.Message);
            }
            return respuesta;
        }

        public async Task<Respuesta> GetMarca()
        {
            var respuesta = new Respuesta();
            try
            {
                respuesta.Cod = "000";
                respuesta.Data = await _context.Marcas.ToListAsync();
                respuesta.Mensaje = "Se inserto correctamente";
            }
            catch (Exception ex)
            {
                respuesta.Cod = "999";
                Log.LogErrorMetodos("CatalogoService", "GetMarca", ex.Message);
            }
            return respuesta;
        }

        public async Task<Respuesta> GetModelo()
        {
            var respuesta = new Respuesta();
            try
            {
                respuesta.Cod = "000";
                respuesta.Data = await _context.Modelos.ToListAsync();
                respuesta.Mensaje = "Se inserto correctamente";
            }
            catch (Exception ex)
            {
                respuesta.Cod = "999";
                Log.LogErrorMetodos("CatalogoService", "GetModelo", ex.Message);
                throw;
            }
            return respuesta;
        }

        public async Task<Respuesta> GetSucursal()
        {
            var respuesta = new Respuesta();
            try
            {
                respuesta.Cod = "000";
                respuesta.Data = await _context.Sucursals.ToListAsync();
                respuesta.Mensaje = "Se inserto correctamente";
            }
            catch (Exception ex)
            {
                respuesta.Cod = "999";
                Log.LogErrorMetodos("CatalogoService", "GetSucursal", ex.Message);
            }
            return respuesta;
        }
    }
}
