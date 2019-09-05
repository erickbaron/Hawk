﻿// <auto-generated />
using System;
using Hawk.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Hawk.Repository.Migrations
{
    [DbContext(typeof(HawkContext))]
    [Migration("20190905122403_Adicionar categorias")]
    partial class Adicionarcategorias
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Hawk.Domain.Entities.AvaliacaoEmpresa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Comentario");

                    b.Property<int>("EmpresaId");

                    b.Property<decimal>("Nota")
                        .HasColumnType("decimal(2,1)");

                    b.Property<bool>("RegistroAtivo");

                    b.HasKey("Id");

                    b.HasIndex("EmpresaId");

                    b.ToTable("AvaliacoesEmpresas");
                });

            modelBuilder.Entity("Hawk.Domain.Entities.AvaliacaoProduto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Comentario");

                    b.Property<decimal>("Nota")
                        .HasColumnType("decimal(2,1)");

                    b.Property<int>("ProdutoId");

                    b.Property<bool>("RegistroAtivo");

                    b.HasKey("Id");

                    b.HasIndex("ProdutoId");

                    b.ToTable("AvaliacoesProdutos");
                });

            modelBuilder.Entity("Hawk.Domain.Entities.Cartao", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ClienteId");

                    b.Property<string>("Cvc");

                    b.Property<DateTime>("DataVencimento");

                    b.Property<string>("NomeProprietario");

                    b.Property<string>("Numero");

                    b.Property<bool>("RegistroAtivo");

                    b.HasKey("Id");

                    b.HasIndex("ClienteId");

                    b.ToTable("Cartoes");
                });

            modelBuilder.Entity("Hawk.Domain.Entities.Categoria", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nome");

                    b.Property<bool>("RegistroAtivo");

                    b.HasKey("Id");

                    b.ToTable("Categorias");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Nome = "Eletronicos",
                            RegistroAtivo = true
                        },
                        new
                        {
                            Id = 2,
                            Nome = "Calabresa",
                            RegistroAtivo = true
                        });
                });

            modelBuilder.Entity("Hawk.Domain.Entities.Cliente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Cpf");

                    b.Property<DateTime>("DataNascimento");

                    b.Property<string>("Nome");

                    b.Property<bool>("RegistroAtivo");

                    b.Property<string>("Telefone");

                    b.Property<int>("UsuarioId");

                    b.HasKey("Id");

                    b.HasIndex("UsuarioId");

                    b.ToTable("Clientes");
                });

            modelBuilder.Entity("Hawk.Domain.Entities.Compra", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ClienteId");

                    b.Property<decimal>("Desconto")
                        .HasColumnType("decimal(8,2)");

                    b.Property<bool>("RegistroAtivo");

                    b.Property<decimal>("ValorTotal")
                        .HasColumnType("decimal(8,2)");

                    b.HasKey("Id");

                    b.HasIndex("ClienteId");

                    b.ToTable("Compras");
                });

            modelBuilder.Entity("Hawk.Domain.Entities.Empresa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Cnpj");

                    b.Property<string>("Nome");

                    b.Property<string>("Ramo");

                    b.Property<bool>("RegistroAtivo");

                    b.Property<string>("Telefone");

                    b.Property<int>("UsuarioId");

                    b.HasKey("Id");

                    b.HasIndex("UsuarioId");

                    b.ToTable("Empresas");
                });

            modelBuilder.Entity("Hawk.Domain.Entities.EnderecoCliente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Cep");

                    b.Property<string>("Cidade");

                    b.Property<int>("ClienteId");

                    b.Property<string>("Complemento");

                    b.Property<string>("Estado");

                    b.Property<string>("Logradouro");

                    b.Property<string>("Numero");

                    b.Property<bool>("RegistroAtivo");

                    b.HasKey("Id");

                    b.HasIndex("ClienteId");

                    b.ToTable("EnderecosClientes");
                });

            modelBuilder.Entity("Hawk.Domain.Entities.EnderecoEmpresa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Cep");

                    b.Property<string>("Cidade");

                    b.Property<string>("Complemento");

                    b.Property<int>("EmpresaId");

                    b.Property<string>("Estado");

                    b.Property<string>("Logradouro");

                    b.Property<string>("Numero");

                    b.Property<bool>("RegistroAtivo");

                    b.HasKey("Id");

                    b.HasIndex("EmpresaId");

                    b.ToTable("EnderecosEmpresas");
                });

            modelBuilder.Entity("Hawk.Domain.Entities.Estoque", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DataEntrada");

                    b.Property<int>("EmpresaId");

                    b.Property<bool>("Entrada");

                    b.Property<int>("ProdutoId");

                    b.Property<int>("Quantidade");

                    b.HasKey("Id");

                    b.HasIndex("EmpresaId");

                    b.HasIndex("ProdutoId");

                    b.ToTable("Estoques");
                });

            modelBuilder.Entity("Hawk.Domain.Entities.Financa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CompraId");

                    b.Property<int>("EmpresaId");

                    b.Property<decimal>("Lucro")
                        .HasColumnType("decimal(8,2)");

                    b.Property<bool>("RegistroAtivo");

                    b.Property<decimal>("ValorCusto")
                        .HasColumnType("decimal(8,2)");

                    b.Property<decimal>("ValorVenda")
                        .HasColumnType("decimal(8,2)");

                    b.HasKey("Id");

                    b.HasIndex("CompraId");

                    b.HasIndex("EmpresaId");

                    b.ToTable("Financas");
                });

            modelBuilder.Entity("Hawk.Domain.Entities.ItemCompra", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CompraId");

                    b.Property<int>("ProdutoId");

                    b.Property<bool>("RegistroAtivo");

                    b.Property<decimal>("ValorItem")
                        .HasColumnType("decimal(8,2)");

                    b.HasKey("Id");

                    b.HasIndex("CompraId");

                    b.HasIndex("ProdutoId");

                    b.ToTable("ItensCompras");
                });

            modelBuilder.Entity("Hawk.Domain.Entities.Produto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Altura");

                    b.Property<int>("CategoriaId");

                    b.Property<int>("Comprimento");

                    b.Property<string>("Descricao");

                    b.Property<int>("EmpresaId");

                    b.Property<int>("Largura");

                    b.Property<string>("Nome");

                    b.Property<decimal>("Peso")
                        .HasColumnType("decimal(8,2)");

                    b.Property<bool>("Promocao");

                    b.Property<bool>("RegistroAtivo");

                    b.Property<decimal>("ValorCusto")
                        .HasColumnType("decimal(8,2)");

                    b.Property<decimal>("ValorVenda")
                        .HasColumnType("decimal(8,2)");

                    b.HasKey("Id");

                    b.HasIndex("CategoriaId");

                    b.HasIndex("EmpresaId");

                    b.ToTable("Produtos");
                });

            modelBuilder.Entity("Hawk.Domain.Entities.ProdutoFavorito", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ClienteId");

                    b.Property<int>("ProdutoId");

                    b.Property<bool>("RegistroAtivo");

                    b.HasKey("Id");

                    b.HasIndex("ClienteId");

                    b.HasIndex("ProdutoId");

                    b.ToTable("ProdutosFavoritos");
                });

            modelBuilder.Entity("Hawk.Domain.Entities.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Administrador");

                    b.Property<string>("Email");

                    b.Property<string>("Nome");

                    b.Property<bool>("RegistroAtivo");

                    b.Property<string>("Senha");

                    b.HasKey("Id");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("Hawk.Domain.Entities.AvaliacaoEmpresa", b =>
                {
                    b.HasOne("Hawk.Domain.Entities.Empresa", "Empresa")
                        .WithMany()
                        .HasForeignKey("EmpresaId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("Hawk.Domain.Entities.AvaliacaoProduto", b =>
                {
                    b.HasOne("Hawk.Domain.Entities.Produto", "Produto")
                        .WithMany()
                        .HasForeignKey("ProdutoId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("Hawk.Domain.Entities.Cartao", b =>
                {
                    b.HasOne("Hawk.Domain.Entities.Cliente", "Cliente")
                        .WithMany()
                        .HasForeignKey("ClienteId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("Hawk.Domain.Entities.Cliente", b =>
                {
                    b.HasOne("Hawk.Domain.Entities.Usuario", "Usuario")
                        .WithMany()
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("Hawk.Domain.Entities.Compra", b =>
                {
                    b.HasOne("Hawk.Domain.Entities.Cliente", "Cliente")
                        .WithMany()
                        .HasForeignKey("ClienteId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("Hawk.Domain.Entities.Empresa", b =>
                {
                    b.HasOne("Hawk.Domain.Entities.Usuario", "Usuario")
                        .WithMany()
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("Hawk.Domain.Entities.EnderecoCliente", b =>
                {
                    b.HasOne("Hawk.Domain.Entities.Cliente", "Cliente")
                        .WithMany()
                        .HasForeignKey("ClienteId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("Hawk.Domain.Entities.EnderecoEmpresa", b =>
                {
                    b.HasOne("Hawk.Domain.Entities.Empresa", "Empresa")
                        .WithMany()
                        .HasForeignKey("EmpresaId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("Hawk.Domain.Entities.Estoque", b =>
                {
                    b.HasOne("Hawk.Domain.Entities.Empresa", "Empresa")
                        .WithMany()
                        .HasForeignKey("EmpresaId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Hawk.Domain.Entities.Produto", "Produto")
                        .WithMany()
                        .HasForeignKey("ProdutoId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("Hawk.Domain.Entities.Financa", b =>
                {
                    b.HasOne("Hawk.Domain.Entities.Compra", "Compra")
                        .WithMany()
                        .HasForeignKey("CompraId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Hawk.Domain.Entities.Empresa", "Empresa")
                        .WithMany()
                        .HasForeignKey("EmpresaId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("Hawk.Domain.Entities.ItemCompra", b =>
                {
                    b.HasOne("Hawk.Domain.Entities.Compra", "Compra")
                        .WithMany()
                        .HasForeignKey("CompraId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Hawk.Domain.Entities.Produto", "Produto")
                        .WithMany()
                        .HasForeignKey("ProdutoId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("Hawk.Domain.Entities.Produto", b =>
                {
                    b.HasOne("Hawk.Domain.Entities.Categoria", "Categoria")
                        .WithMany()
                        .HasForeignKey("CategoriaId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Hawk.Domain.Entities.Empresa", "Empresa")
                        .WithMany()
                        .HasForeignKey("EmpresaId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("Hawk.Domain.Entities.ProdutoFavorito", b =>
                {
                    b.HasOne("Hawk.Domain.Entities.Cliente", "Cliente")
                        .WithMany()
                        .HasForeignKey("ClienteId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Hawk.Domain.Entities.Produto", "Produto")
                        .WithMany()
                        .HasForeignKey("ProdutoId")
                        .OnDelete(DeleteBehavior.Restrict);
                });
#pragma warning restore 612, 618
        }
    }
}