using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SistemaGestionBussiness;
using SistemaGestionEntities;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VentaController : ControllerBase
    {
        [HttpGet(Name = "Lista de venta")]

        public IEnumerable<Venta> Get()
        {
            return VentaBussiness.ListarVentaData().ToArray();
        }

        [HttpDelete(Name = "Eliminar Venta")]

        public void Delete([FromBody] int id)
        {
            VentaBussiness.EliminarVenta(id);
        }

        [HttpPut(Name = "Modificar Venta")]

        public void put([FromBody] Venta venta)
        {
            VentaBussiness.ModificarVentaData(venta);
        }

        [HttpPost(Name = "Crear Venta")]

        public void Post([FromBody] Venta venta)
        {
            VentaBussiness.ModificarVentaData(venta);
        }

    }
}
