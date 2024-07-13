using EjemploEntity.Models;

namespace EjemploEntity.Utilitarios
{
    public class PokeApi
    {
		private ControlError log = new ControlError();
        public async Task<Respuesta> GetPokeApi(string url)
        {
			var respuesta = new Respuesta();
			try
			{
                var client = new HttpClient();
                var request = new HttpRequestMessage(HttpMethod.Get, url);
                var response = await client.SendAsync(request);
                response.EnsureSuccessStatusCode();

                respuesta.Cod = "000";
                respuesta.Data = await response.Content.ReadAsStringAsync();
                respuesta.Mensaje = "Se consumio correcto";
            }
            catch (Exception ex)
			{
				log.LogErrorMetodos("PokeApi", "GetPokeApi", ex.Message);
			}
			return respuesta;
        }
    }
}
