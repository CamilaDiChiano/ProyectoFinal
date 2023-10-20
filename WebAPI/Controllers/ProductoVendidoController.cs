using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SistemaGestionBussiness;
using SistemaGestionEntities;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductoVendidoController : ControllerBase
    {
        [HttpGet(Name = "Lista de ProductoVendido")]

        public IEnumerable<ProductoVendido> Get()
        {
            return ProductoVendidoBussiness.ListarProductoVendido().ToArray();
        }

        [HttpDelete(Name = "Eliminar ProductoVendido")]

        public void Delete([FromBody] int id)
        {
            ProductoVendidoBussiness.EliminarProductoVendido(id);
        }

        [HttpPut(Name = "Modificar ProductoVendido")]

        public void Put([FromBody] ProductoVendido productoVendido)
        {
            ProductoVendidoBussiness.ModificarProductoVendido(productoVendido);
        }

        [HttpPost(Name = "Crear ProductoVendido")]

        public void Post([FromBody] ProductoVendido productoVendido)
        {
            ProductoVendidoBussiness.ModificarProductoVendido(productoVendido);
        }


    }
}
