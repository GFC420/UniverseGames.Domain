using System;
using System.Collections.Generic;
using System.Text;
using UniverseGames.Application.DTOs;

namespace UniverseGames.Application.Services
{
    public class PedidoService
    {
        private static List<PedidoDto> pedidos = new();

        public List<PedidoDto> GetAll() => pedidos;

        public void Criar(PedidoDto pedido)
        {
            pedidos.Add(pedido);
        }
    }
}
