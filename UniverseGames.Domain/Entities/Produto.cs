using System;
using System.Collections.Generic;
using System.Text;

namespace UniverseGames.Domain.Entities
{
    public class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public decimal Preco { get; set; }

        public int CategoriaId { get; set; }
        public Categoria Categoria { get; set; }

        public List<Review> Reviews { get; set; }
    }
}
