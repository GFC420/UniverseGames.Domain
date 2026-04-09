using System;
using System.Collections.Generic;
using System.Text;

namespace UniverseGames.Domain.Entities
{
    public class Review
    {
        public int Id { get; set; }

        public int ProdutoId { get; set; }
        public Produto Produto { get; set; }

        public string Comentario { get; set; }
        public int Nota { get; set; }
    }
}
