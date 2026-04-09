using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
// Verifique se o caminho do seu DbContext é este mesmo:
// using UniverseGames.Infrastructure.Data; 

namespace UniverseGames.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DashboardController : ControllerBase
    {
        // Injeção do Banco de Dados
        private readonly UniverseGamesDbContext _db;

        public DashboardController(UniverseGamesDbContext db)
        {
            _db = db;
        }

        [HttpGet]
        public async Task<IActionResult> GetDashboard()
        {
            // 1. Total de Vendas (Soma de pedidos finalizados)
            var totalVendas = await _db.Pedidos
                .Where(p => p.Status == "Finalizado")
                .SumAsync(p => (decimal?)p.Total) ?? 0m;

            // 2. Contagens Gerais
            var totalClientes = await _db.Clientes.CountAsync();
            var totalProdutos = await _db.Produtos.CountAsync();
            var totalPedidos = await _db.Pedidos.CountAsync();

            // 3. Status dos Pedidos
            var pedidosPend = await _db.Pedidos.CountAsync(p => p.Status == "Pendente");
            var pedidosConcl = await _db.Pedidos.CountAsync(p => p.Status == "Finalizado");
            var pedidosCanc = await _db.Pedidos.CountAsync(p => p.Status == "Cancelado");

            // 4. Pedidos por mês (últimos 6 meses)
            var inicio = DateTime.Today.AddMonths(-5).Date;
            var pedidosPorMes = await _db.Pedidos
                .Where(p => p.DataPedido >= inicio)
                .GroupBy(p => new { p.DataPedido.Year, p.DataPedido.Month })
                .Select(g => new
                {
                    Ano = g.Key.Year,
                    Mes = g.Key.Month,
                    Total = g.Count()
                })
                .OrderBy(g => g.Ano).ThenBy(g => g.Mes)
                .ToListAsync();

            // Retorno do objeto anônimo (igual à imagem 1)
            return Ok(new
            {
                totalVendas,
                totalClientes,
                totalProdutos,
                totalPedidos,
                pedidosPendentes = pedidosPend,
                pedidosConcluidos = pedidosConcl,
                pedidosCancelados = pedidosCanc,
                pedidosPorMes
            });
        }
    }
}