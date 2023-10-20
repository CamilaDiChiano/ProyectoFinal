using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SistemaGestionBussiness;
using SistemaGestionEntities;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        [HttpGet(Name ="Lista de Usuario")]

        public IEnumerable <Usuario> Get()
        {
            return UsuarioBussiness.ListarUsuario().ToArray();
        }

        [HttpDelete(Name = "Eliminar Usuario")]

        public void Delete([FromBody] int id)
        {
          UsuarioBussiness.EliminarUsuario(id);
        }

        [HttpPut(Name = "Modificar Usuario")]

        public void Put([FromBody] Usuario usuario)
        {
            UsuarioBussiness.ModificarUsuario(usuario);
        }

        [HttpPost(Name = "Crear Usuario")]

        public void Post([FromBody] Usuario usuario)
        {
            UsuarioBussiness.ModificarUsuario(usuario);
        }

    }
}
