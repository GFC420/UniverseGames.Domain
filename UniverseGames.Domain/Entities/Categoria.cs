using System;
using System.Collections.Generic;
using System.Text;

namespace UniverseGames.Domain.Entities
{
    public class Categoria
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        public List<Produto> Produtos { get; set; }
    }
}
