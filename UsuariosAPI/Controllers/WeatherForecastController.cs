using Microsoft.AspNetCore.Mvc;

namespace UsuariosAPI.Controllers
{
    [ApiController]
    [Route("usuarios")]
    public class WeatherForecastController : ControllerBase
    {
        public List<Usuario> Usuarios = new List<Usuario>();


        [HttpGet]
        public IEnumerable<Usuario> Get()
        {
            return Usuarios;
        }

        [HttpPost]
        public void Post(Usuario usuario)
        {
            Usuarios.Add(usuario);
        }

        [HttpPut]
        public void Put(Usuario usuario)
        {
            var usuarioAtualizar = Usuarios.FirstOrDefault(u => u.Id == usuario.Id);
            usuarioAtualizar.Name = usuario.Name;


        }
    }
}