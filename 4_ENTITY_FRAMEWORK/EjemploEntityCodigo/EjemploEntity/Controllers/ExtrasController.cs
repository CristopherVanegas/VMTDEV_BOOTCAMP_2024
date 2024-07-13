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
        [Route("ChuckNorrisCategories")]
        public async Task<Respuesta> ChuckNorrisCategories()
        {
            var respuesta = new Respuesta();
            try
            {
                var url = _configuration.GetSection("Keys:ChuckNorrisCategoriesApi").Value!;

                respuesta = await chuckNorrisApi.GetChuckNorrisCategoriesApi(url);
            }
            catch (Exception ex)
            {
                log.LogErrorMetodos("ExtrasController", "ChuckNorrisCategories", ex.Message);
            }

            return respuesta;
        }

        
        [HttpGet]
        [Route("GetChuckNorrisJokes")]
        public async Task<Respuesta> GetChuckNorrisJokes()
        {
            var respuesta = new Respuesta();
            try
            {
                var url = _configuration.GetSection("Keys:ChuckNorrisJokesApi").Value!;

                respuesta = await chuckNorrisApi.GetChuckNorrisJokesApi(url);
            }
            catch (Exception ex)
            {
                log.LogErrorMetodos("ExtrasController", "GetChuckNorrisJokes", ex.Message);
            }

            return respuesta;
        }
    }
}
