
using Microsoft.AspNetCore.Mvc;
using UniverseGames.Application.DTOs;
namespace UniverseGamess.Api.Controllers
{

    [ApiController]
    [Route("api/pagamento")]
    public class PagamentoController : ControllerBase
    {
        [HttpPost]
        public IActionResult Pagar(PagamentoDto pagamento)
        {
            return Ok(new
            {
                status = "Aprovado",
                pedido = pagamento.PedidoId
            });
        }
    }
}
