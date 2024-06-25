using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Interfaces
{
    public interface ISaludo
    {
        Task<List<Persona>> Saludos(string id);
        Task<Respuesta> InsertPersona(Persona persona);
        Task<List<Persona>> UpdatePersona(string id);
    }
}
