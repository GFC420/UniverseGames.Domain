using System;
using System.Collections.Generic;
using System.Text;

namespace UniverseGames.Domain.Entities
{
    public class Carrinho
    {
        public int Id { get; set; }

        public int UsuarioId { get; set; }

        public List<ItemPedido> Itens { get; set; }
    }
}
