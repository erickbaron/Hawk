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
    [Migration("20190910121956_corrigidoEstoque")]
    partial class corrigidoEstoque
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

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Comentario = "hfgghsdgfhsdgfjhgs",
                            EmpresaId = 1,
                            Nota = 5m,
                            RegistroAtivo = true
                        },
                        new
                        {
                            Id = 2,
                            Comentario = "ehuehuehueheu",
                            EmpresaId = 1,
                            Nota = 4m,
                            RegistroAtivo = true
                        });
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

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Comentario = "abfkjgadkfgakf",
                            Nota = 5m,
                            ProdutoId = 1,
                            RegistroAtivo = true
                        },
                        new
                        {
                            Id = 2,
                            Comentario = "fçaksdçmakd",
                            Nota = 5m,
                            ProdutoId = 1,
                            RegistroAtivo = true
                        });
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

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ClienteId = 1,
                            Cvc = "123",
                            DataVencimento = new DateTime(2010, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            NomeProprietario = "jose",
                            Numero = "123576123",
                            RegistroAtivo = true
                        },
                        new
                        {
                            Id = 2,
                            ClienteId = 1,
                            Cvc = "123",
                            DataVencimento = new DateTime(2012, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            NomeProprietario = "joao",
                            Numero = "12357343",
                            RegistroAtivo = true
                        });
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

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Cpf = "59315617061",
                            DataNascimento = new DateTime(2012, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Nome = "irineu",
                            RegistroAtivo = true,
                            Telefone = "2036466360",
                            UsuarioId = 1
                        },
                        new
                        {
                            Id = 2,
                            Cpf = "59315639061",
                            DataNascimento = new DateTime(2012, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Nome = "jose",
                            RegistroAtivo = true,
                            Telefone = "2012466360",
                            UsuarioId = 1
                        });
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

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ClienteId = 1,
                            Desconto = 0m,
                            RegistroAtivo = true,
                            ValorTotal = 12333m
                        },
                        new
                        {
                            Id = 2,
                            ClienteId = 2,
                            Desconto = 2m,
                            RegistroAtivo = true,
                            ValorTotal = 1433m
                        });
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

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Cnpj = "81.197.017/0001-82",
                            Nome = "WEG",
                            Ramo = "lojinha",
                            RegistroAtivo = true,
                            Telefone = "2036466360",
                            UsuarioId = 1
                        },
                        new
                        {
                            Id = 2,
                            Cnpj = "83.757.980/0001-07",
                            Nome = "Hanes",
                            Ramo = "comida",
                            RegistroAtivo = true,
                            Telefone = "2036466370",
                            UsuarioId = 2
                        });
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

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Cep = "04180112",
                            Cidade = "Sao Paulo",
                            ClienteId = 1,
                            Complemento = " ",
                            Estado = "Sao Paulo",
                            Logradouro = "virando a esquina",
                            Numero = "1222",
                            RegistroAtivo = true
                        },
                        new
                        {
                            Id = 2,
                            Cep = "04180113",
                            Cidade = "rio de janeiro",
                            ClienteId = 2,
                            Complemento = " ",
                            Estado = "Rio de janeiro",
                            Logradouro = "Rua principal",
                            Numero = "123",
                            RegistroAtivo = true
                        });
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

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Cep = "04180112",
                            Cidade = "Sao Paulo",
                            Complemento = " ",
                            EmpresaId = 1,
                            Estado = "Sao Paulo",
                            Logradouro = "virando a esquina",
                            Numero = "1222",
                            RegistroAtivo = true
                        },
                        new
                        {
                            Id = 2,
                            Cep = "04180113",
                            Cidade = "rio de janeiro",
                            Complemento = " ",
                            EmpresaId = 2,
                            Estado = "Rio de janeiro",
                            Logradouro = "Rua principal",
                            Numero = "123",
                            RegistroAtivo = true
                        });
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

                    b.Property<bool>("RegistroAtivo");

                    b.HasKey("Id");

                    b.HasIndex("EmpresaId");

                    b.HasIndex("ProdutoId");

                    b.ToTable("Estoques");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DataEntrada = new DateTime(2012, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EmpresaId = 1,
                            Entrada = true,
                            ProdutoId = 1,
                            Quantidade = 2,
                            RegistroAtivo = true
                        },
                        new
                        {
                            Id = 2,
                            DataEntrada = new DateTime(2012, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EmpresaId = 2,
                            Entrada = false,
                            ProdutoId = 2,
                            Quantidade = 32,
                            RegistroAtivo = true
                        });
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

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CompraId = 1,
                            EmpresaId = 1,
                            Lucro = 198m,
                            RegistroAtivo = true,
                            ValorCusto = 2m,
                            ValorVenda = 200m
                        },
                        new
                        {
                            Id = 2,
                            CompraId = 2,
                            EmpresaId = 2,
                            Lucro = 300m,
                            RegistroAtivo = true,
                            ValorCusto = 3m,
                            ValorVenda = 303m
                        });
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

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CompraId = 1,
                            ProdutoId = 1,
                            RegistroAtivo = true,
                            ValorItem = 2m
                        },
                        new
                        {
                            Id = 2,
                            CompraId = 2,
                            ProdutoId = 2,
                            RegistroAtivo = true,
                            ValorItem = 1123m
                        });
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

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Altura = 1,
                            CategoriaId = 1,
                            Comprimento = 3,
                            Descricao = "se derubar abre uma cratera",
                            EmpresaId = 1,
                            Largura = 2,
                            Nome = "nokia tijolao",
                            Peso = 10m,
                            Promocao = false,
                            RegistroAtivo = true,
                            ValorCusto = 2m,
                            ValorVenda = 10m
                        },
                        new
                        {
                            Id = 2,
                            Altura = 2,
                            CategoriaId = 2,
                            Comprimento = 2,
                            Descricao = "o kiko sempre quis uma ",
                            EmpresaId = 2,
                            Largura = 2,
                            Nome = "bola quadrada",
                            Peso = 10m,
                            Promocao = false,
                            RegistroAtivo = true,
                            ValorCusto = 3m,
                            ValorVenda = 100m
                        });
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

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ClienteId = 1,
                            ProdutoId = 1,
                            RegistroAtivo = true
                        },
                        new
                        {
                            Id = 2,
                            ClienteId = 2,
                            ProdutoId = 2,
                            RegistroAtivo = true
                        });
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

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Administrador = false,
                            Email = "erickbaron@gmail.com",
                            Nome = "Erick",
                            RegistroAtivo = true,
                            Senha = "1234"
                        },
                        new
                        {
                            Id = 2,
                            Administrador = true,
                            Email = "Jozinho@gmail.com",
                            Nome = "Joao",
                            RegistroAtivo = true,
                            Senha = "4321"
                        });
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