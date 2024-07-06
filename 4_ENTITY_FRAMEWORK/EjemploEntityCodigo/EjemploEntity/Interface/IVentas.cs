using EjemploEntity.Models;

namespace EjemploEntity.Interface
{
    public interface IVentas
    {
        Task<Respuesta> GetVentaCliente(int? numFact, string? fecha, string? vendedor, double? precio, int clienteId);
        Task<Respuesta> PostVenta(Venta venta);
        //Task<Respuesta> PutVenta(Venta venta);
        Task<Respuesta> GetVenta();
    }
}
