﻿// <auto-generated />
using System;
using Hawk.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Hawk.Repository.Migrations
{
    [DbContext(typeof(HawkContext))]
    partial class HawkContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Hawk.Domain.Entities.Carrinho", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("RegistroAtivo");

                    b.Property<int>("UsuarioId");

                    b.Property<decimal>("ValorTotal")
                        .HasColumnType("decimal(8,2)");

                    b.HasKey("Id");

                    b.HasIndex("UsuarioId");

                    b.ToTable("Carrinhos");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            RegistroAtivo = true,
                            UsuarioId = 1,
                            ValorTotal = 0m
                        },
                        new
                        {
                            Id = 2,
                            RegistroAtivo = true,
                            UsuarioId = 2,
                            ValorTotal = 0m
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
                            ClienteId = 2,
                            Cvc = "568",
                            DataVencimento = new DateTime(2010, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            NomeProprietario = "João Victor",
                            Numero = "5152158596235746",
                            RegistroAtivo = true
                        },
                        new
                        {
                            Id = 2,
                            ClienteId = 1,
                            Cvc = "846",
                            DataVencimento = new DateTime(2012, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            NomeProprietario = "Erick",
                            Numero = "2745805245830765",
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
                            Nome = "Periféricos",
                            RegistroAtivo = true
                        },
                        new
                        {
                            Id = 3,
                            Nome = "Games",
                            RegistroAtivo = true
                        },
                        new
                        {
                            Id = 4,
                            Nome = "Outros",
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
                            Nome = "Erick",
                            RegistroAtivo = true,
                            Telefone = "2036466360",
                            UsuarioId = 1
                        },
                        new
                        {
                            Id = 2,
                            Cpf = "59315639061",
                            DataNascimento = new DateTime(2012, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Nome = "João",
                            RegistroAtivo = true,
                            Telefone = "2012466360",
                            UsuarioId = 2
                        });
                });

            modelBuilder.Entity("Hawk.Domain.Entities.Compra", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CarrinhoId");

                    b.Property<int>("ClienteId");

                    b.Property<decimal?>("Desconto")
                        .HasColumnType("decimal(8,2)");

                    b.Property<bool>("RegistroAtivo");

                    b.Property<decimal>("ValorTotal")
                        .HasColumnType("decimal(8,2)");

                    b.HasKey("Id");

                    b.HasIndex("CarrinhoId");

                    b.HasIndex("ClienteId");

                    b.ToTable("Compras");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CarrinhoId = 1,
                            ClienteId = 1,
                            Desconto = 0m,
                            RegistroAtivo = true,
                            ValorTotal = 12333m
                        },
                        new
                        {
                            Id = 2,
                            CarrinhoId = 1,
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

                    b.Property<string>("Cep");

                    b.Property<string>("Cidade");

                    b.Property<string>("Cnpj");

                    b.Property<string>("Complemento");

                    b.Property<string>("Estado");

                    b.Property<string>("Logradouro");

                    b.Property<string>("Nome");

                    b.Property<string>("Numero");

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
                            Cep = "04180112",
                            Cidade = "São Paulo",
                            Cnpj = "81.197.017/0001-82",
                            Complemento = "",
                            Estado = "São Paulo",
                            Logradouro = "Rua Dos Atiradores",
                            Nome = "Ding Ltda",
                            Numero = "5222",
                            Ramo = "Eletrônicos",
                            RegistroAtivo = true,
                            Telefone = "2036466360",
                            UsuarioId = 1
                        },
                        new
                        {
                            Id = 2,
                            Cep = "04180112",
                            Cidade = "Terezina",
                            Cnpj = "83.757.980/0001-07",
                            Complemento = "",
                            Estado = "Piaui",
                            Logradouro = "Avenida Frei Serafim",
                            Nome = "Dong Ltda",
                            Numero = "8222",
                            Ramo = "Eletrônicos",
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
                });

            modelBuilder.Entity("Hawk.Domain.Entities.Estoque", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DataEntrada");

                    b.Property<int>("EmpresaId");

                    b.Property<string>("Entrada");

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
                            Entrada = "Entrada",
                            ProdutoId = 1,
                            Quantidade = 2,
                            RegistroAtivo = true
                        },
                        new
                        {
                            Id = 2,
                            DataEntrada = new DateTime(2012, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EmpresaId = 2,
                            Entrada = "Saida",
                            ProdutoId = 2,
                            Quantidade = 32,
                            RegistroAtivo = true
                        });
                });

            modelBuilder.Entity("Hawk.Domain.Entities.ItemCompra", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CarrinhoId");

                    b.Property<int>("CompraId");

                    b.Property<int>("ProdutoId");

                    b.Property<int>("Quantidade");

                    b.Property<bool>("RegistroAtivo");

                    b.Property<decimal>("Valor");

                    b.HasKey("Id");

                    b.HasIndex("CarrinhoId");

                    b.HasIndex("CompraId");

                    b.HasIndex("ProdutoId");

                    b.ToTable("ItensCompras");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CompraId = 1,
                            ProdutoId = 1,
                            Quantidade = 1,
                            RegistroAtivo = true,
                            Valor = 0m
                        },
                        new
                        {
                            Id = 2,
                            CompraId = 1,
                            ProdutoId = 2,
                            Quantidade = 3,
                            RegistroAtivo = true,
                            Valor = 0m
                        });
                });

            modelBuilder.Entity("Hawk.Domain.Entities.Produto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Altura");

                    b.Property<int?>("CategoriaId");

                    b.Property<int>("Comprimento");

                    b.Property<string>("Descricao");

                    b.Property<int?>("EmpresaId");

                    b.Property<int>("Largura");

                    b.Property<string>("Nome");

                    b.Property<string>("NomeArquivo");

                    b.Property<string>("NomeHash");

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
                            Altura = 2,
                            CategoriaId = 1,
                            Comprimento = 26,
                            Descricao = "Notebook Intel Core i7 8550U 15,6' 8GB HD 1 TB GeForce MX150 Windows 10",
                            EmpresaId = 2,
                            Largura = 38,
                            Nome = "Notebook Lenovo IdeaPad 330",
                            NomeArquivo = "imagem-1.jpg",
                            NomeHash = "",
                            Peso = 2m,
                            Promocao = false,
                            RegistroAtivo = true,
                            ValorCusto = 2100m,
                            ValorVenda = 2915m
                        },
                        new
                        {
                            Id = 2,
                            Altura = 14,
                            CategoriaId = 1,
                            Comprimento = 1,
                            Descricao = "Smartphone Samsung Galaxy S9 SM-G9600 128GB",
                            EmpresaId = 2,
                            Largura = 7,
                            Nome = "Smartphone Samsung Galaxy S9",
                            NomeArquivo = "imagem-2.jpg",
                            NomeHash = "",
                            Peso = 163m,
                            Promocao = false,
                            RegistroAtivo = true,
                            ValorCusto = 1300m,
                            ValorVenda = 1889m
                        },
                        new
                        {
                            Id = 3,
                            Altura = 136,
                            CategoriaId = 1,
                            Comprimento = 132,
                            Descricao = "Caixa de Som Xtreme 2 JBL Preta 40W RMS",
                            EmpresaId = 2,
                            Largura = 288,
                            Nome = "Caixa de Som Xtreme 2 JBL",
                            NomeArquivo = "imagem3.jpg",
                            NomeHash = "",
                            Peso = 3m,
                            Promocao = false,
                            RegistroAtivo = true,
                            ValorCusto = 500m,
                            ValorVenda = 949m
                        },
                        new
                        {
                            Id = 4,
                            Altura = 10,
                            CategoriaId = 2,
                            Comprimento = 5,
                            Descricao = "Headphone Bluetooth com Microfone JBL Tune 500BT",
                            EmpresaId = 2,
                            Largura = 5,
                            Nome = "Headphone JBL",
                            NomeArquivo = "imagem4.jpg",
                            NomeHash = "",
                            Peso = 100m,
                            Promocao = false,
                            RegistroAtivo = true,
                            ValorCusto = 98m,
                            ValorVenda = 198m
                        },
                        new
                        {
                            Id = 5,
                            Altura = 2,
                            CategoriaId = 3,
                            Comprimento = 2,
                            Descricao = "God of War é um jogo eletrônico de ação-aventura desenvolvido pela Santa Monica Studio e publicado pela Sony Interactive Entertainment.",
                            EmpresaId = 2,
                            Largura = 2,
                            Nome = "Game God Of War - PS4",
                            NomeArquivo = "imagem-5.jpg",
                            NomeHash = "",
                            Peso = 10m,
                            Promocao = false,
                            RegistroAtivo = true,
                            ValorCusto = 3m,
                            ValorVenda = 80m
                        });
                });

            modelBuilder.Entity("Hawk.Domain.Entities.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Hawk.Domain.Entities.UserRole", b =>
                {
                    b.Property<int>("UserId");

                    b.Property<int>("RoleId");

                    b.Property<int?>("RoleId1");

                    b.Property<int?>("UserId1");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.HasIndex("RoleId1");

                    b.HasIndex("UserId1");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Hawk.Domain.Entities.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash")
                        .HasColumnName("senha");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<bool>("RegistroAtivo")
                        .HasColumnName("registro_ativo");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasColumnName("nome")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers","dbo");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "d152a18a-19e9-4c02-8af9-d81287023789",
                            Email = "erick@gmail.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedEmail = "ERICK@GMAIL.COM",
                            NormalizedUserName = "Erick",
                            PasswordHash = "AQAAAAEAACcQAAAAELDMbLMCmZrqbqcxF5vpVa7kBAFmQLv9eOZZ6xZ1nuMJLq1JBOEzS+vFfMZH2d0zcw==",
                            PhoneNumberConfirmed = false,
                            RegistroAtivo = true,
                            TwoFactorEnabled = false,
                            UserName = "Erick"
                        },
                        new
                        {
                            Id = 2,
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "406f0fea-8f68-4aee-b8a9-8ed14208b36a",
                            Email = "joao@gmail.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedEmail = "JOAO@GMAIL.COM",
                            NormalizedUserName = "Joao",
                            PasswordHash = "AQAAAAEAACcQAAAAELDMbLMCmZrqbqcxF5vpVa7kBAFmQLv9eOZZ6xZ1nuMJLq1JBOEzS+vFfMZH2d0zcw==",
                            PhoneNumberConfirmed = false,
                            RegistroAtivo = true,
                            TwoFactorEnabled = false,
                            UserName = "Joao"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<int>("RoleId");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<int>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<int>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<int>("UserId");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<int>", b =>
                {
                    b.Property<int>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("Hawk.Domain.Entities.Carrinho", b =>
                {
                    b.HasOne("Hawk.Domain.Entities.Usuario", "Usuario")
                        .WithMany()
                        .HasForeignKey("UsuarioId")
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
                    b.HasOne("Hawk.Domain.Entities.Carrinho", "Carrinho")
                        .WithMany()
                        .HasForeignKey("CarrinhoId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Hawk.Domain.Entities.Cliente", "Cliente")
                        .WithMany()
                        .HasForeignKey("ClienteId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("Hawk.Domain.Entities.Empresa", b =>
                {
                    b.HasOne("Hawk.Domain.Entities.Usuario", "user")
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

            modelBuilder.Entity("Hawk.Domain.Entities.ItemCompra", b =>
                {
                    b.HasOne("Hawk.Domain.Entities.Carrinho")
                        .WithMany("ItensCompra")
                        .HasForeignKey("CarrinhoId");

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
                        .HasForeignKey("CategoriaId");

                    b.HasOne("Hawk.Domain.Entities.Empresa", "Empresa")
                        .WithMany()
                        .HasForeignKey("EmpresaId");
                });

            modelBuilder.Entity("Hawk.Domain.Entities.UserRole", b =>
                {
                    b.HasOne("Hawk.Domain.Entities.Role")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Hawk.Domain.Entities.Role", "Role")
                        .WithMany("UserRoles")
                        .HasForeignKey("RoleId1");

                    b.HasOne("Hawk.Domain.Entities.Usuario")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Hawk.Domain.Entities.Usuario", "User")
                        .WithMany("UserRoles")
                        .HasForeignKey("UserId1");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<int>", b =>
                {
                    b.HasOne("Hawk.Domain.Entities.Role")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<int>", b =>
                {
                    b.HasOne("Hawk.Domain.Entities.Usuario")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<int>", b =>
                {
                    b.HasOne("Hawk.Domain.Entities.Usuario")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<int>", b =>
                {
                    b.HasOne("Hawk.Domain.Entities.Usuario")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Restrict);
                });
#pragma warning restore 612, 618
        }
    }
}
