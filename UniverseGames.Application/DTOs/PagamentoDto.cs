using System;
using System.Collections.Generic;
using System.Text;

namespace UniverseGames.Application.DTOs
{
    public class PagamentoDto
    {
        public int PedidoId { get; set; }
        public string Metodo { get; set; } // PIX, Cartão
    }
}
