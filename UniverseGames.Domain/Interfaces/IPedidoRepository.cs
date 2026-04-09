using System;
using System.Collections.Generic;
using System.Text;
using UniverseGames.Domain.Entities;

namespace UniverseGames.Domain.Interfaces
{
    public interface IPedidoRepository
    {
        Task<IEnumerable<Pedido>> ListarTodosAsync();
        Task<Pedido?> ObterPorIdAsync(int id);

        Task AdicionarAsync(Pedido pedido);
    }
}
