using System;
using System.Collections.Generic;
using System.Text;
using UniverseGames.Domain.Entities;
namespace UniverseGames.Domain.Interfaces;

public interface IProdutoRepository
{
    Task<IEnumerable<Produto>> ListarTodosAsync();
    Task<Produto?> ObterPorIdAsync(int id);

    Task AdicionarAsync(Produto produto);
    Task AtualizarAsync(Produto produto);
    Task RemoverAsync(int id);
}
