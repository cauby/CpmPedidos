using CpmPedidos.Dominio;
using Microsoft.EntityFrameworkCore;

namespace CpmPedidos.Repositorio
{
    public class AplicacaoDbContext: DbContext 
    {
        public DbSet<Cidade> ?Cidades { get; set; }
        public DbSet<Cliente> ?Clientes { get; set; }
        public DbSet<CategoriaProduto> ?CategoriaProduto { get; set; }
        public DbSet<Produto> ?Produtos { get; set; }
        public DbSet<PromocaoProduto> ?PromocoesProdutos { get; set; }
        public DbSet<Combo> ?Combos { get; set; }
        public DbSet<Pedido> ?Pedidos { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(GetType().Assembly);
        }

        public AplicacaoDbContext()
        {
            ChangeTracker.AutoDetectChangesEnabled = false;
        }

        public AplicacaoDbContext(DbContextOptions<AplicacaoDbContext> options) : base(options)
        {
            ChangeTracker.AutoDetectChangesEnabled = false;
        }
    }
}
