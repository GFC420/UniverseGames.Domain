using System;
using System.Collections.Generic;
using System.Text;
using UniverseGames.Domain.Entities;

namespace UniverseGames.Domain.Interfaces
{
    public interface ICarrinhoRepository
    {
        Task<Carrinho?> ObterPorUsuarioAsync(int usuarioId);

        Task AdicionarItemAsync(int usuarioId, ItemPedido item);
        Task LimparAsync(int usuarioId);
    }
}
