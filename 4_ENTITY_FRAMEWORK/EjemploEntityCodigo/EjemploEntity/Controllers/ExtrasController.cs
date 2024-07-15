using EjemploEntity.Models;
using EjemploEntity.Utilitarios;
using Microsoft.AspNetCore.Mvc;

namespace EjemploEntity.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ExtrasController : Controller
    {
        private ControlError log = new ControlError();
        private PokeApi pokeApi = new PokeApi();
        private ChuckNorrisApi chuckNorrisApi = new ChuckNorrisApi();
        private readonly IConfiguration _configuration;

        public ExtrasController(IConfiguration configuration)
        {
            this._configuration = configuration;
        }

        [HttpGet]
        [Route("GetPokeApi")]
        public async Task<Respuesta> GetPokeApi()
        {
            var respuesta = new Respuesta();
            try
            {
                var url = _configuration.GetSection("Keys:UrlPokeApi").Value!;

                respuesta = await pokeApi.GetPokeApi(url);
            }
            catch (Exception ex)
            {
                log.LogErrorMetodos("ExtrasController", "GetPokeApi", ex.Message);
            }

            return respuesta;
        }

        [HttpGet]
        [Route("CnCategories")]
        public async Task<Respuesta> CnCategories()
        {
            var respuesta = new Respuesta();
            try
            {
                var url = _configuration.GetSection("Keys:CnCategories").Value!;

                respuesta = await chuckNorrisApi.CnCategories(url);
            }
            catch (Exception ex)
            {
                log.LogErrorMetodos("ExtrasController", "CnCategories", ex.Message);
            }

            return respuesta;
        }
        
        [HttpGet]
        [Route("CnJokes")]
        public async Task<Respuesta> CnJokes()
        {
            var respuesta = new Respuesta();
            try
            {
                var url = _configuration.GetSection("Keys:CnRandomJokes").Value!;

                respuesta = await chuckNorrisApi.CnJokes(url);
            }
            catch (Exception ex)
            {
                log.LogErrorMetodos("ExtrasController", "CnJokes", ex.Message);
            }

            return respuesta;
        }

        [HttpGet]
        [Route("CnJokesByCateg")]
        public async Task<Respuesta> CnJokesByCateg(string category)
        {
            var respuesta = new Respuesta();
            try
            {
                var url = _configuration.GetSection("Keys:CnRandomJokes").Value!;

                respuesta = await chuckNorrisApi.CnJokesByCateg(url, category);
            }
            catch (Exception ex)
            {
                log.LogErrorMetodos("ExtrasController", "CnJokesByCateg", ex.Message);
            }
            return respuesta;
        }
    }
}
