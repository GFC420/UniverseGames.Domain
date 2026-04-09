
using Microsoft.AspNetCore.Mvc;
using UniverseGames.Application.DTOs;
namespace UniverseGamess.Api.Controllers
{


    [ApiController]
    [Route("api/reviews")]
    public class ReviewController : ControllerBase
    {
        private static List<ReviewDto> reviews = new();

        [HttpPost]
        public IActionResult Add(ReviewDto r)
        {
            reviews.Add(r);
            return Ok("Review adicionada");
        }

        [HttpGet("{produtoId}")]
        public IActionResult Get(int produtoId)
        {
            return Ok(reviews.Where(r => r.ProdutoId == produtoId));
        }
    }
}

