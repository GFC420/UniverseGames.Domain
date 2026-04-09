using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using UniverseGames.Application.DTOs;

namespace UniverseGames.Application.Services
{
 

    public class ProdutoService
    {
        private static List<ProdutoDto> produtos = new();

        public List<ProdutoDto> GetAll()
        {
            return produtos;
        }

        public ProdutoDto GetById(int id)
        {
            return produtos.FirstOrDefault(p => p.Id == id);
        }

        public void Add(ProdutoDto produto)
        {
            produtos.Add(produto);
        }

        public void Update(int id, ProdutoDto produto)
        {
            var existente = GetById(id);
            if (existente != null)
            {
                produtos.Remove(existente);
                produtos.Add(produto);
            }
        }

        public void Delete(int id)
        {
            var produto = GetById(id);
            if (produto != null)
                produtos.Remove(produto);
        }
    }
}
