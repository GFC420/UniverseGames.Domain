using System;
using System.Collections.Generic;
using System.Text;
using UniverseGames.Application.DTOs;

namespace UniverseGames.Application.Services
{
    public class CarrinhoService
    {
        private static List<ItemPedidoDto> carrinho = new();

        public List<ItemPedidoDto> GetAll() => carrinho;

        public void Add(ItemPedidoDto item)
        {
            carrinho.Add(item);
        }

        public void Clear()
        {
            carrinho.Clear();
        }
    }
}
