using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using UniverseGames.Application.DTOs;
using UniverseGames.Application.Services;
using UniverseGames.Domain.Entities;
using UniverseGames.Infrastructure.Data;

namespace UniverseGames.Api.Controllers
{
    [ApiController]
    [Route("api/usuarios")]
    public class UsuarioController : ControllerBase
    {
        private readonly AppDbContext _context;
        private readonly UsuarioService _usuarioService;

        public UsuarioController(AppDbContext context, UsuarioService usuarioService)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
            _usuarioService = usuarioService ?? throw new ArgumentNullException(nameof(usuarioService));
        }

        // 🔥 POST - criar usuário
        [HttpPost]
        public async Task<IActionResult> Create(UsuarioDto dto)
        {
            var usuario = new Usuario
            {
                Email = dto.Email,
                Senha = dto.Senha
            };

            _context.Usuarios.Add(usuario);
            await _context.SaveChangesAsync();

            var result = new { message = "Usuário criado com sucesso", id = usuario.Id };
            return CreatedAtAction(nameof(ObterPorId), new { id = usuario.Id }, result);
        }

        // GET por id usado por CreatedAtAction
        [HttpGet("{id}")]
        public async Task<IActionResult> ObterPorId(int id)
        {
            var usuario = await _context.Usuarios.FindAsync(id);
            if (usuario == null)
                return NotFound(new { message = "Usuário não encontrado" });

            var dto = new UsuarioDto
            {
                Id = usuario.Id,
                Email = usuario.Email,
                Senha = usuario.Senha
            };

            return Ok(dto);
        }

        // 🔥 LOGIN
        [HttpPost("login")]
        public async Task<IActionResult> Login(LoginDto login)
        {
            var usuario = await _context.Usuarios
                .FirstOrDefaultAsync(u => u.Email == login.Email);

            if (usuario == null)
                return Unauthorized(new { message = "Usuário não encontrado" });

            if (usuario.Senha != login.Senha)
                return Unauthorized(new { message = "Senha inválida" });

            return Ok(new { message = "Login realizado" });
        }

        [HttpGet]
        public async Task<IActionResult> ListarTodos()
        {
            var usuarios = await _usuarioService.ListarTodosAsync();
            return Ok(usuarios);
        }
    }
}