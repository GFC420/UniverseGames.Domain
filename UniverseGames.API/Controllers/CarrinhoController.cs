using Microsoft.AspNetCore.Mvc;
using UniverseGames.Application.DTOs;

namespace UniverseGamess.Api.Controllers
{
    [ApiController]
    [Route("api/carrinho")]
    public class CarrinhoController : ControllerBase
    {
        private static List<ItemPedidoDto> carrinho = new();

        [HttpPost]
        public IActionResult Add(ItemPedidoDto item)
        {
            carrinho.Add(item);
            return Ok("Adicionado ao carrinho");
        }

        [HttpGet]
        public IActionResult Get() => Ok(carrinho);
    }
}
