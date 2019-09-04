using Microsoft.EntityFrameworkCore;

namespace Hawk.Repository
{
    public class HawkContext : DbContext
    {
        public HawkContext(DbContextOptions<HawkContext> options) : base(options) { }
          
            public DbSet<Usuario> Usuarios { get; set; }
            public DbSet<AvaliacaoEmpresa> AvaliacoesEmpresas { get; set; }
            public DbSet<AvaliacaoProduto> AvaliacoesProdutos { get; set; }
            public DbSet<Cartao> Cartoes { get; set; }
            public DbSet<Categorias> Categorias { get; set; }
            public DbSet<Cliente> Clientes { get; set; }
            public DbSet<Compra> Compras { get; set; }
            public DbSet<Empresa> Empresas { get; set; }
            public DbSet<EnderecoCliente> EnderecosClientes { get; set; }
            public DbSet<EnderecoEmpresa> EnderecosEmpresas { get; set; }
            public DbSet<Estoque> Estoques { get; set; }
            public DbSet<Financa> Financas { get; set; }
            public DbSet<ItemCompra> ItensCompras { get; set; }
            public DbSet<Produto> Produtos { get; set; }
            public DbSet<ProdutoFavorito> ProdutosFavoritos { get; set; }
            
    }
}
