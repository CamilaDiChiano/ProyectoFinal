using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SistemaGestionBussiness;
using SistemaGestionEntities;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductoController : ControllerBase
    {
        [HttpPost(Name = "Crear Producto")]

        public void Post([FromBody] Producto producto)
        {
            ProductoBussiness.ModificarProducto(producto);
        }

        [HttpDelete(Name = "Eliminar Producto")]

        public void Delete([FromBody] int id)
        {
            ProductoBussiness.EliminarProducto(id);
        }

        [HttpPut(Name = "Modificar Producto")]

        public void Put([FromBody] Producto producto)
        {
            ProductoBussiness.ModificarProducto(producto);
        }


    }
}
