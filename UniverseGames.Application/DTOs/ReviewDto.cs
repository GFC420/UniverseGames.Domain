using System;
using System.Collections.Generic;
using System.Text;

namespace UniverseGames.Application.DTOs
{
    public class ReviewDto
    {
        public int ProdutoId { get; set; }
        public string Comentario { get; set; }
        public int Nota { get; set; }
    }
}
