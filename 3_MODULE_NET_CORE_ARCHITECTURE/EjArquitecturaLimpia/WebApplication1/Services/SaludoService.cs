using Microsoft.AspNetCore.Mvc;
using WebApplication1.Interfaces;
using WebApplication1.Models;

namespace WebApplication1.Services
{
    public class SaludoService : ISaludo
    {
        public async Task<List<Persona>> Saludos(string id)
        {
            var listaPersonas = new List<Persona>();

            try
            {
                var query = LlenarPersonasEnt();

                if (id.Equals("0"))
                {
                    listaPersonas = query;
                }
                else
                {
                    listaPersonas = query.Where(x => x.id.Equals(id)).ToList();
                }
            }
            catch (Exception)
            {

                throw;
            }
            return listaPersonas;
        }

        public List<Persona> LlenarPersonasEnt()
        {
            var respuesta = new Persona();
            var respuesta2 = new Persona();
            var respuesta3 = new Persona();
            var listaPersonas = new List<Persona>();
            try
            {
                respuesta.id = "1";
                respuesta.nombre = "Cristopher";
                respuesta.apellido= "Vanegas";
                respuesta.edad = "19";
                respuesta.celTelefono = "0939500816";
                respuesta.direccion = "Cdla. Guangala";
                respuesta.email = "cristopher.platzi@gmail.com";

                listaPersonas.Add(respuesta);

                respuesta2.id = "2";
                respuesta2.nombre = "Melani";
                respuesta2.apellido= "Gaibor";
                respuesta2.edad = "26";
                respuesta2.celTelefono = "1112223333";
                respuesta2.direccion = "Cdla. Guangala";
                respuesta2.email = "cristopher.platzi@gmail.com";

                listaPersonas.Add(respuesta2);

                respuesta3.id = "3";
                respuesta3.nombre = "Adali";
                respuesta3.apellido= "Delgado";
                respuesta3.edad = "24";
                respuesta3.celTelefono = "0939500816";
                respuesta3.direccion = "Cdla. Guangala";
                respuesta3.email = "cristopher.platzi@gmail.com";

                listaPersonas.Add(respuesta3);
            }
            catch (Exception)
            {

                throw;
            }
            return listaPersonas;
        }

        public async Task<Respuesta> InsertPersona(Persona persona)
        {
            var respuesta = new Respuesta();
            try
            {
                var query = LlenarPersonasEnt();

                var id = query.Select(x => x.id).OrderDescending().FirstOrDefault();

                persona.id = Convert.ToString(Convert.ToInt32(id) + 1);
                
                query.Add(persona);

                respuesta.cod = "000";
                respuesta.data = query;
                respuesta.mensaje = "Ok, se inserto sin novedad";
            }
            catch (Exception)
            {

                throw;
            }
            return respuesta;
        }

        public async Task<List<Persona>> UpdatePersona(string id)
        {
            var listaPersonas = new List<Persona>();

            try
            {
                var query = LlenarPersonasEnt();

                if (listaPersonas.Select(x => x.id).Equals(id))
                {
                    listaPersonas = query;
                }
                else
                {
                    listaPersonas = query.Where(x => x.id.Equals(id)).ToList();
                }
            }
            catch (Exception)
            {

                throw;
            }
            return listaPersonas;
        }
    }
}
