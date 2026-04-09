using Microsoft.AspNetCore.Mvc;
using UniverseGames.Application.DTOs;

namespace UniverseGamess.Api.Controllers
{
    [ApiController]
    [Route("api/pedidos")]
    public class PedidoController : ControllerBase
    {
        private static List<PedidoDto> pedidos = new();

        [HttpPost]
        public IActionResult Criar(PedidoDto pedido)
        {
            pedidos.Add(pedido);
            return Ok("Pedido criado");
        }

        [HttpGet]
        public IActionResult Get() => Ok(pedidos);
    }
}
