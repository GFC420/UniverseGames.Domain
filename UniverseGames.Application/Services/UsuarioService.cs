using System;
using System.Collections.Generic;
using System.Text;
using UniverseGames.Application.DTOs;

namespace UniverseGames.Application.Services
{
    public class UsuarioService
    {
        private static List<UsuarioDto> usuarios = new();

        public void Add(UsuarioDto usuario)
        {
            usuarios.Add(usuario);
        }

        public List<UsuarioDto> GetAll()
        {
            return usuarios;
        }

        public UsuarioDto Login(string email, string senha)
        {
            return usuarios.FirstOrDefault(u => u.Email == email && u.Senha == senha);
        }
    }
}
