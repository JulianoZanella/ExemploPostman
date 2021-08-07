using ExemploPostman.DTO;
using ExemploPostman.Repositorios;
using ExemploPostman.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ExemploPostman.Controllers
{
    [ApiController]
    [Route("v1/conta")]
    public class HomeController : ControllerBase
    {
        [HttpPost]
        [Route("login")]
        [AllowAnonymous]
        public ActionResult Autenticar([FromBody] UsuarioDTO usuarioDTO)
        {
            var usuario = UsuarioRepositorio.Get(usuarioDTO.LoginConvertido, usuarioDTO.SenhaConvertida);

            if (usuario == null)
                return NotFound(new { message = "Usuário ou senha inválidos" });

            var token = TokenService.GerarToken(usuario);
            return Ok(new
            {
                usuario = usuario.Login,
                token
            });
        }

        [HttpGet]
        [Route("login")]
        [Authorize]
        public string ObterLogin() => User.Identity.Name;
    }
}
