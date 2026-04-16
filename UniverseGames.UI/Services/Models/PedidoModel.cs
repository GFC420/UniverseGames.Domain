using System;
using System.Collections.Generic;

namespace UniverseGames.UI.Models
{
    public class PedidoModel
    {
        public int Id { get; set; }
        public int UsuarioId { get; set; }
        public DateTime Data { get; set; }
        public decimal Total { get; set; }




        public List<ItemPedidoModel> Itens { get; set; }
    }
}