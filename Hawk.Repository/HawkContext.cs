using Hawk.Domain.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace Hawk.Repository
{

    public class HawkContext : IdentityDbContext<Usuario, Role, int, IdentityUserClaim<int>, UserRole, IdentityUserLogin<int>, IdentityRoleClaim<int>, IdentityUserToken<int>>

    {
        public HawkContext(DbContextOptions<HawkContext> options) : base(options) { }

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<AvaliacaoEmpresa> AvaliacoesEmpresas { get; set; }
        public DbSet<AvaliacaoProduto> AvaliacoesProdutos { get; set; }
        public DbSet<Carrinho> Carrinhos { get; set; }
        public DbSet<Cartao> Cartoes { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Compra> Compras { get; set; }
        public DbSet<Empresa> Empresas { get; set; }
        public DbSet<EnderecoCliente> EnderecosClientes { get; set; }
        public DbSet<Estoque> Estoques { get; set; }
        public DbSet<ItemCompra> ItensCompras { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<ProdutoFavorito> ProdutosFavoritos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Usuario>().ToTable("usuarios", "dbo");
                //modelBuilder.Entity<Usuario>(user => {
                //    user.ToTable("usuarios");
                //    user.Property(p => p.UserName).HasColumnName("nome");
                //    user.Property(p => p.PasswordHash).HasColumnName("senha");
            modelBuilder.Entity<UserRole>(userRole =>
            {
                userRole.HasKey(ur => new { ur.UserId, ur.RoleId });

                userRole.HasOne(ur => ur.Role)
                    .WithMany(r => r.UserRoles)
                    .HasForeignKey(ur => ur.RoleId)
                    .IsRequired();

                userRole.HasOne(ur => ur.User)
                    .WithMany(r => r.UserRoles)
                    .HasForeignKey(ur => ur.UserId)
                    .IsRequired();
            }
            );
            var cascadeFKs = modelBuilder.Model.GetEntityTypes()
                 .SelectMany(t => t.GetForeignKeys())
                 .Where(fk => !fk.IsOwnership && fk.DeleteBehavior == DeleteBehavior.Cascade);

            foreach (var fk in cascadeFKs)
                fk.DeleteBehavior = DeleteBehavior.Restrict;

            modelBuilder.Seed();

            base.OnModelCreating(modelBuilder);
        }
    }
}
