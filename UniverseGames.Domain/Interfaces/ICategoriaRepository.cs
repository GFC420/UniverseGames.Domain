using System;
using System.Collections.Generic;
using System.Text;
using UniverseGames.Domain.Entities;

namespace UniverseGames.Domain.Interfaces;


public interface ICategoriaRepository
{
    Task<IEnumerable<Categoria>> ListarTodosAsync();
    Task<Categoria?> ObterPorIdAsync(int id);

    Task AdicionarAsync(Categoria categoria);
    Task AtualizarAsync(Categoria categoria);
    Task RemoverAsync(int id);
}