using System;
using System.Collections.Generic;
using System.Text;
using global::UniverseGames.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using UniverseGames.Domain.Entities;

namespace UniverseGames.Infrastructure.Data
{
    
      public class AppDbContext : DbContext
        {
            public AppDbContext(DbContextOptions<AppDbContext> options)
                : base(options)
            {
            }

            public DbSet<Usuario> Usuarios { get; set; }
            public DbSet<Produto> Produtos { get; set; }
            public DbSet<Categoria> Categorias { get; set; }
            public DbSet<Pedido> Pedidos { get; set; }
            public DbSet<ItemPedido> ItensPedido { get; set; }
            //public DbSet<Review> Reviews { get; set; }
            //public DbSet<Pagamento> Pagamentos { get; set; }
            //public DbSet<Carrinho> Carrinhos { get; set; }
        }
    }

