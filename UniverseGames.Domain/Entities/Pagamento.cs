using System;
using System.Collections.Generic;
using System.Text;

namespace UniverseGames.Domain.Entities
{
    public class Pagamento
    {
        public int Id { get; set; }

        public int PedidoId { get; set; }
        public Pedido Pedido { get; set; }

        public string Metodo { get; set; } // PIX, Cartão
        public string Status { get; set; } // Aprovado, Pendente
    }
}
