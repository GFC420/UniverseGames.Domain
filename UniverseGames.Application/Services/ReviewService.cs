using System;
using System.Collections.Generic;
using System.Text;
using UniverseGames.Application.DTOs;

namespace UniverseGames.Application.Services
{
    public class ReviewService
    {
        private static List<ReviewDto> reviews = new();

        public void Add(ReviewDto review)
        {
            reviews.Add(review);
        }

        public List<ReviewDto> GetByProduto(int produtoId)
        {
            return reviews.Where(r => r.ProdutoId == produtoId).ToList();
        }
    }
}
