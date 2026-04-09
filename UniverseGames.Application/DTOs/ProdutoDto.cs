using System;
using System.Collections.Generic;
using System.Text;

namespace UniverseGames.Application.DTOs
{
    public class ProdutoDto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public decimal Preco { get; set; }
        public int CategoriaId { get; set; }
    }
}
