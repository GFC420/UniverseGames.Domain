using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UniverseGames.Application.DTOs;
using UniverseGames.Domain.Interfaces;

namespace UniverseGames.Application.Services
{
    public class UsuarioService
    {
        private static List<UsuarioDto> usuarios = new();
        private readonly IUsuarioRepository _usuarioRepository;

        public UsuarioService(IUsuarioRepository usuarioRepository)
        {
            _usuarioRepository = usuarioRepository ?? throw new ArgumentNullException(nameof(usuarioRepository));
        }

        public void Add(UsuarioDto usuario)
        {
            usuarios.Add(usuario);
        }

        public async Task<IEnumerable<UsuarioDto>> ListarTodosAsync()
        {
                var usuarios = await _usuarioRepository.ListarTodosAsync();
            return usuarios.Select(u => new UsuarioDto
            {
                Id = u.Id,
                Email = u.Email,
                Senha = u.Senha,
            });
        }

        public UsuarioDto Login(string email, string senha)
        {
            return usuarios.FirstOrDefault(u => u.Email == email && u.Senha == senha);
        }
    }
}
