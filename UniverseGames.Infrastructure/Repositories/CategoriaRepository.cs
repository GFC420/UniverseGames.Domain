using Microsoft.EntityFrameworkCore;
using UniverseGames.Domain.Entities;
using UniverseGames.Domain.Interfaces;
using UniverseGames.Infrastructure.Data;

namespace UniverseGames.Infrastructure.Repositories
{
    public class CategoriaRepository : ICategoriaRepository
    {
        private readonly AppDbContext _context;

        public CategoriaRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Categoria>> ListarTodosAsync()
        {
            return await _context.Categorias.ToListAsync();
        }

        public async Task AdicionarAsync(Categoria categoria)
        {
            _context.Categorias.Add(categoria);
            await _context.SaveChangesAsync();
        }

        public Task<Categoria?> ObterPorIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task AtualizarAsync(Categoria categoria)
        {
            throw new NotImplementedException();
        }

        public Task RemoverAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}