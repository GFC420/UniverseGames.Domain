using Microsoft.AspNetCore.Mvc;
using UniverseGames.Application.DTOs;
using UniverseGames.Application.Services;

namespace UniverseGames.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ClienteController : ControllerBase
    {
        // Construtor e Injeção de Dependência (Baseado na linha 14-19 da imagem 2)
        // private readonly IClienteService _clienteService;
        // public ClienteController(IClienteService clienteService)
        // {
        //     _clienteService = clienteService;
        // }

        [HttpGet]
        public async Task<IActionResult> ListarTodos()
        {
            // Lógica para listar clientes
            return Ok();
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> ObterPorId(int id)
        {
            // Lógica para buscar um cliente específico
            return Ok();
        }

        [HttpPost]
        public async Task<IActionResult> Criar([FromBody] object clienteDto)
        {
            try
            {
                // Lógica para criar cliente
                return CreatedAtAction(nameof(ObterPorId), new { id = 1 }, clienteDto);
            }
            catch (Exception ex)
            {
                return Conflict(new { mensagem = ex.Message });
            }
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Atualizar(int id, [FromBody] object clienteDto)
        {
            try
            {
                // Lógica para atualizar
                return NoContent();
            }
            catch (Exception ex)
            {
                return NotFound(new { mensagem = ex.Message });
            }
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Remover(int id)
        {
            try
            {
                // Lógica para remover
                return NoContent();
            }
            catch (Exception ex)
            {
                return NotFound(new { mensagem = ex.Message });
            }
        }
    }
}