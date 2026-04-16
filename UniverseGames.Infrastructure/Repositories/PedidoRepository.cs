using Microsoft.EntityFrameworkCore;
using UniverseGames.Domain.Entities;
using UniverseGames.Domain.Interfaces;
using UniverseGames.Infrastructure.Data;

namespace UniverseGames.Infrastructure.Repositories
{
    public class PedidoRepository : IPedidoRepository
    {
        private readonly AppDbContext _context;

        public PedidoRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Pedido>> ListarTodosAsync()
        {
            return await _context.Pedidos
                .Include(p => p.Itens)
                .ThenInclude(i => i.Produto)
                .ToListAsync();
        }

        public async Task AdicionarAsync(Pedido pedido)
        {
            _context.Pedidos.Add(pedido);
            await _context.SaveChangesAsync();
        }

        public Task<Pedido?> ObterPorIdAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}