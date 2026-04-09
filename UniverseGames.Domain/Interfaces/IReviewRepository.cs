using System;
using System.Collections.Generic;
using System.Text;
using UniverseGames.Domain.Entities;

namespace UniverseGames.Domain.Interfaces
{
    public interface IReviewRepository
    {
        Task<IEnumerable<Review>> ObterPorProdutoAsync(int produtoId);
        Task AdicionarAsync(Review review);
    }
}
