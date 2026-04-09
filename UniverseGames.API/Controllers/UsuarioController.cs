using Microsoft.AspNetCore.Mvc;
using UniverseGames.Application.DTOs;

namespace UniverseGamess.Api.Controllers
{
    [ApiController]
    [Route("api/usuarios")]
    public class UsuarioController : ControllerBase
    {
        private static List<UsuarioDto> usuarios = new();

        [HttpPost]
        public IActionResult Create(UsuarioDto u)
        {
            usuarios.Add(u);
            return Ok("Usuário criado");
        }

        [HttpGet]
        public IActionResult Get() => Ok(usuarios);
    }
}
