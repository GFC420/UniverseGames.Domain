using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography;
using System.Text;
using UniverseGames.Domain.Entities;
using UniverseGames.Infrastructure.Data;

namespace UniverseGames.Infrastructure.Data
{
    public static class DatabaseSeeder
    {
        public static async Task SeedAsync(AppDbContext db)
        {
            await db.Database.MigrateAsync();

            await SeedUsuariosAsync(db);
            await SeedCategoriasAsync(db);
            await SeedProdutosAsync(db);
            await SeedPedidosAsync(db);
        }

        // 👤 USUÁRIOS
        private static async Task SeedUsuariosAsync(AppDbContext db)
        {
            if (await db.Usuarios.AnyAsync()) return;

            db.Usuarios.AddRange(
                new Usuario { Email = "admin@gamer.com", Senha = GerarHash("123") },
                new Usuario { Email = "player1@gamer.com", Senha = GerarHash("123") },
                new Usuario { Email = "player2@gamer.com", Senha = GerarHash("123") }
            );

            await db.SaveChangesAsync();
        }

        // 🎮 CATEGORIAS
        private static async Task SeedCategoriasAsync(AppDbContext db)
        {
            if (await db.Categorias.AnyAsync()) return;

            db.Categorias.AddRange(
                new Categoria { Nome = "Teclados Gamer" },
                new Categoria { Nome = "Mouses Gamer" },
                new Categoria { Nome = "Headsets" },
                new Categoria { Nome = "Monitores" }
            );

            await db.SaveChangesAsync();
        }

        // 🖥️ PRODUTOS
        private static async Task SeedProdutosAsync(AppDbContext db)
        {
            if (await db.Produtos.AnyAsync()) return;

            var categorias = await db.Categorias.ToListAsync();
            int Cat(string nome) => categorias.First(c => c.Nome == nome).Id;

            db.Produtos.AddRange(
                new Produto { Nome = "Teclado Mecânico RGB", Preco = 350, CategoriaId = Cat("Teclados Gamer") },
                new Produto { Nome = "Mouse Gamer 16000 DPI", Preco = 220, CategoriaId = Cat("Mouses Gamer") },
                new Produto { Nome = "Headset Surround 7.1", Preco = 400, CategoriaId = Cat("Headsets") },
                new Produto { Nome = "Monitor 144Hz", Preco = 1500, CategoriaId = Cat("Monitores") }
            );

            await db.SaveChangesAsync();
        }

        // 🧾 PEDIDOS
        private static async Task SeedPedidosAsync(AppDbContext db)
        {
            if (await db.Pedidos.AnyAsync()) return;

            var usuarios = await db.Usuarios.ToListAsync();
            var produtos = await db.Produtos.ToListAsync();

            if (!usuarios.Any() || !produtos.Any()) return;

            var pedido = new Pedido
            {
                UsuarioId = usuarios.First().Id,
                Data = DateTime.Now,
                Itens = new List<ItemPedido>()
            };

            pedido.Itens.Add(new ItemPedido
            {
                ProdutoId = produtos[0].Id,
                Quantidade = 2
            });

            pedido.Itens.Add(new ItemPedido
            {
                ProdutoId = produtos[1].Id,
                Quantidade = 1
            });

            db.Pedidos.Add(pedido);

            await db.SaveChangesAsync();
        }

        // 🔐 HASH
        private static string GerarHash(string texto)
        {
            var bytes = SHA256.HashData(Encoding.UTF8.GetBytes(texto));
            return Convert.ToHexString(bytes).ToLower();
        }
    }
}
