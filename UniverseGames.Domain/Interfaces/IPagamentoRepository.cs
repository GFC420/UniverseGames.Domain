using System;
using System.Collections.Generic;
using System.Text;
using UniverseGames.Domain.Entities;

namespace UniverseGames.Domain.Interfaces
{
    public interface IPagamentoRepository
    {
        Task ProcessarAsync(Pagamento pagamento);
        Task<Pagamento?> ObterPorPedidoAsync(int pedidoId);
    }
}
