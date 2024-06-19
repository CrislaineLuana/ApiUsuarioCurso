using ApiUsuarioCurso.Dto.Usuario;
using ApiUsuarioCurso.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiUsuarioCurso.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {






        [HttpPost("register")]
        public IActionResult RegistrarUsuario(UsuarioCriacaoDto usuario)
        {
            return Ok();
        }



    }
}
