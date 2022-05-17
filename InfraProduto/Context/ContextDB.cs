using APIProdutos.Mapping;
using APIProdutos.Models;
using Microsoft.EntityFrameworkCore;

namespace APIProdutos.Context
{
    public class ContextDB : DbContext
    {
        public ContextDB(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Produto> Produtos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ProdutoMapping());

            base.OnModelCreating(modelBuilder);
        }
    }
}
