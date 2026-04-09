using System;
using System.Collections.Generic;
using System.Text;
using UniverseGames.Application.DTOs;

namespace UniverseGames.Application.Services
{
    public class CategoriaService
    {
        private static List<CategoriaDto> categorias = new();

        public List<CategoriaDto> GetAll() => categorias;

        public void Add(CategoriaDto categoria)
        {
            categorias.Add(categoria);
        }
    }
}
