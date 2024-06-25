using Microsoft.AspNetCore.Mvc;
using WebApplication1.Interfaces;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SaludoController : Controller
    {
        private readonly ISaludo _saludos;

        public SaludoController(ISaludo saludos) 
        {
            this._saludos = saludos;
        }

        [HttpGet]
        [Route("Saludos")]
        public async Task<List<Persona>> Saludos(string id)
        {
            var respuesta = new List<Persona>();
            try
            {
                respuesta = await _saludos.Saludos(id);
            }
            catch (Exception ex)
            {

                throw;
            }

            return respuesta;
        }

        [HttpPost]
        [Route("InsertPersona")]
        public async Task<Respuesta> InsertPersona([FromBody] Persona persona)
        {
            var respuesta = new Respuesta();
            try
            {
                respuesta = await _saludos.InsertPersona(persona);
            }
            catch (Exception)
            {

                throw;
            }
            return respuesta;
        }

        [HttpPost]
        [Route("UpdatePersona")]
        public async Task<List<Persona>> UpdatePersona(string id)
        {
            var respuesta = new List<Persona>();
            try
            {
                respuesta = await _saludos.Saludos(id);
            }
            catch (Exception ex)
            {

                throw;
            }

            return respuesta;
        }
    }
}
