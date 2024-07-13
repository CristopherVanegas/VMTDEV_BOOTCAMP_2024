using EjemploEntity.DTOs;
using EjemploEntity.Models;
using Newtonsoft.Json;

namespace EjemploEntity.Utilitarios
{
    public class ChuckNorrisApi
    {
        private ControlError log = new ControlError();
        public async Task<Respuesta> GetChuckNorrisCategoriesApi(string url)
        {
            var respuesta = new Respuesta();
            try
            {
                var client = new HttpClient();
                var request = new HttpRequestMessage(HttpMethod.Get, url);
                var response = await client.SendAsync(request);
                response.EnsureSuccessStatusCode();

                var json = await response.Content.ReadAsStringAsync();

                respuesta.Cod = "000";
                respuesta.Data = JsonConvert.DeserializeObject<List<string>>(json);
                respuesta.Mensaje = "Se consumio correcto";
            }
            catch (Exception ex)
            {
                log.LogErrorMetodos("ChuckNorrisApi", "GetChuckNorrisCategoriesApi", ex.Message);
            }
            return respuesta;
        }

        public async Task<Respuesta> GetChuckNorrisJokesApi(string url)
        {
            var respuesta = new Respuesta();
            try
            {
                var client = new HttpClient();
                var request = new HttpRequestMessage(HttpMethod.Get, url);
                var response = await client.SendAsync(request);
                response.EnsureSuccessStatusCode();

                var json = await response.Content.ReadAsStringAsync();

                respuesta.Cod = "000";
                respuesta.Data = JsonConvert.DeserializeObject<ChuckNorrisJokesDto>(json);
                respuesta.Mensaje = "Se consumio correcto";
            }
            catch (Exception ex)
            {
                log.LogErrorMetodos("ChuckNorrisApi", "GetChuckNorrisJokesApi", ex.Message);
            }
            return respuesta;
        }
    }
}
