using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using UniverseGames.Application.DTOs;
using UniverseGames.Infrastructure.Data;
using UniverseGames.Domain.Entities;

namespace UniverseGames.Api.Controllers
{
    [ApiController]
    [Route("api/usuarios")]
    public class UsuarioController : ControllerBase
    {
        private readonly AppDbContext _context;

        public UsuarioController(AppDbContext context)
        {
            _context = context;
        }

        // 🔥 GET - listar usuários
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var usuarios = await _context.Usuarios
                .Select(u => new UsuarioDto
                {
                    Email = u.Email,
                    Senha = u.Senha
                })
                .ToListAsync();

            return Ok(usuarios);
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

            return Ok("Usuário criado com sucesso");
        }

        // 🔥 LOGIN
        [HttpPost("login")]
        public async Task<IActionResult> Login(LoginDto login)
        {
            var usuario = await _context.Usuarios
                .FirstOrDefaultAsync(u => u.Email == login.Email);

            if (usuario == null)
                return Unauthorized("Usuário não encontrado");

            if (usuario.Senha != login.Senha)
                return Unauthorized("Senha inválida");

            return Ok("Login realizado");
        }
    }
}