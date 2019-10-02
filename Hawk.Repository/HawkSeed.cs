using Hawk.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hawk.Repository
{
    public static class HawkSeed
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            #region categorias
            modelBuilder.Entity<Categoria>().HasData(
                new Categoria()
                {
                    Id = 1,
                    Nome = "Eletronicos",
                    RegistroAtivo = true
                },
                new Categoria()
                {
                    Id = 2,
                    Nome = "Periféricos",
                    RegistroAtivo = true
                });
            #endregion

            #region Usuario  
            modelBuilder.Entity<Usuario>().HasData(
                new Usuario()
                {
                    Id = 1,
                    UserName = "Erick",
                    NormalizedUserName = "Erick",
                    Email = "erick@gmail.com",
                    NormalizedEmail = "erick@gmail.com".ToUpper(),
                    PasswordHash = "AQAAAAEAACcQAAAAELDMbLMCmZrqbqcxF5vpVa7kBAFmQLv9eOZZ6xZ1nuMJLq1JBOEzS+vFfMZH2d0zcw==",
                    RegistroAtivo = true
                },
                new Usuario()
                {
                    Id = 2,
                    UserName = "Joao",
                    NormalizedUserName = "Joao",
                    Email = "joao@gmail.com",
                    NormalizedEmail = "joao@gmail.com".ToUpper(),
                    PasswordHash = "AQAAAAEAACcQAAAAELDMbLMCmZrqbqcxF5vpVa7kBAFmQLv9eOZZ6xZ1nuMJLq1JBOEzS+vFfMZH2d0zcw==",
                    //Administrador = true,
                    RegistroAtivo = true
                });
            #endregion

            #region empresa
            modelBuilder.Entity<Empresa>().HasData(
                new Empresa()
                {
                    Id = 1,
                    Nome = "WEG",
                    Cnpj = "81.197.017/0001-82",
                    Telefone = "2036466360",
                    Ramo = "lojinha",
                    Estado = "Sao Paulo",
                    Cidade = "Sao Paulo",
                    Cep = "04180112",
                    Logradouro = "virando a esquina",
                    Numero = "1222",
                    Complemento = "Casa",
                    RegistroAtivo = true,

                    UsuarioId = 1
                },
                new Empresa()
                {
                    Id = 2,
                    Nome = "Mercosul",
                    Cnpj = "83.757.980/0001-07",
                    Telefone = "2036466370",
                    Ramo = "óculos",
                    Estado = "Piaui",
                    Cidade = "Terezina",
                    Cep = "04180112",
                    Logradouro = "Rua Piaui",
                    Numero = "1222",
                    Complemento = "Apartamento",
                    RegistroAtivo = true,

                    UsuarioId = 2
                });
            #endregion

            #region produto
            modelBuilder.Entity<Produto>().HasData(
                new Produto()
                {
                    Id = 1,
                    Nome = "nokia tijolao",
                    Descricao = "se derubar abre uma cratera",
                    ValorCusto = 2,
                    ValorVenda = 10,
                    Altura = 1,
                    Largura = 2,
                    Comprimento = 3,
                    Peso = 10,
                    Promocao = false,
                    NomeArquivo = "imagem2.jpg",
                    NomeHash = "",
                    RegistroAtivo = true,

                    EmpresaId = 1,
                    CategoriaId = 1,
                },
                new Produto()
                {
                    Id = 2,
                    Nome = "bola quadrada",
                    Descricao = "o kiko sempre quis uma ",
                    ValorCusto = 3,
                    ValorVenda = 100,
                    Altura = 2,
                    Largura = 2,
                    Comprimento = 2,
                    Peso = 10,
                    Promocao = false,
                    NomeArquivo = "imagem.jpg",
                    NomeHash = "",

                    RegistroAtivo = true,

                    EmpresaId = 2,
                    CategoriaId = 2,
                },
                new Produto()
                {
                    Id = 3,
                    Nome = "asdsadasd asdasdasdasd",
                    Descricao = "dasdadatera",
                    ValorCusto = 2,
                    ValorVenda = 10,
                    Altura = 1,
                    Largura = 2,
                    Comprimento = 3,
                    Peso = 10,
                    Promocao = false,
                    NomeArquivo = "imagem2.jpg",
                    NomeHash = "",
                    RegistroAtivo = true,

                    EmpresaId = 1,
                    CategoriaId = 1,
                },
                new Produto()
                {
                    Id = 4,
                    Nome = "blablabla blabla",
                    Descricao = "sdadaads ",
                    ValorCusto = 3,
                    ValorVenda = 100,
                    Altura = 2,
                    Largura = 2,
                    Comprimento = 2,
                    Peso = 10,
                    Promocao = false,
                    NomeArquivo = "imagem.jpg",
                    NomeHash = "",

                    RegistroAtivo = true,

                    EmpresaId = 2,
                    CategoriaId = 2,
                },
                new Produto()
                {
                    Id = 5,
                    Nome = "blablabla blabla",
                    Descricao = "sdadaads ",
                    ValorCusto = 3,
                    ValorVenda = 100,
                    Altura = 2,
                    Largura = 2,
                    Comprimento = 2,
                    Peso = 10,
                    Promocao = false,
                    NomeArquivo = "imagem.jpg",
                    NomeHash = "",

                    RegistroAtivo = true,

                    EmpresaId = 2,
                    CategoriaId = 2,
                },
                new Produto()
                {
                    Id = 6,
                    Nome = "blablabla blabla",
                    Descricao = "sdadaads ",
                    ValorCusto = 3,
                    ValorVenda = 100,
                    Altura = 2,
                    Largura = 2,
                    Comprimento = 2,
                    Peso = 10,
                    Promocao = false,
                    NomeArquivo = "imagem.jpg",
                    NomeHash = "",

                    RegistroAtivo = true,

                    EmpresaId = 2,
                    CategoriaId = 2,
                },
                new Produto()
                {
                    Id = 7,
                    Nome = "blablabla blabla",
                    Descricao = "sdadaads ",
                    ValorCusto = 3,
                    ValorVenda = 100,
                    Altura = 2,
                    Largura = 2,
                    Comprimento = 2,
                    Peso = 10,
                    Promocao = false,
                    NomeArquivo = "imagem.jpg",
                    NomeHash = "",

                    RegistroAtivo = true,

                    EmpresaId = 2,
                    CategoriaId = 2,
                },
                new Produto()
                {
                    Id = 8,
                    Nome = "blablabla blabla",
                    Descricao = "sdadaads ",
                    ValorCusto = 3,
                    ValorVenda = 100,
                    Altura = 2,
                    Largura = 2,
                    Comprimento = 2,
                    Peso = 10,
                    Promocao = false,
                    NomeArquivo = "imagem.jpg",
                    NomeHash = "",

                    RegistroAtivo = true,

                    EmpresaId = 2,
                    CategoriaId = 2,
                }
                );
            #endregion

            #region compra 
            modelBuilder.Entity<Compra>().HasData(
                new Compra()
                {
                    Id = 1,
                    ValorTotal = 12333,
                    Desconto = 0,
                    RegistroAtivo = true,


                    ClienteId = 1,
                    CarrinhoId = 1
                },
                new Compra()
                {
                    Id = 2,
                    ValorTotal = 1433,
                    Desconto = 2,
                    RegistroAtivo = true,

                    ClienteId = 2,
                    CarrinhoId = 1

                });
            #endregion

            #region estoque
            modelBuilder.Entity<Estoque>().HasData(
                new Estoque()
                {
                    Id = 1,
                    Quantidade = 2,

                    Entrada = "entrada",
                    DataEntrada = new DateTime(2012, 10, 12),

                    EmpresaId = 1,
                    ProdutoId = 1,
                    RegistroAtivo = true

                },
                new Estoque()
                {
                    Id = 2,
                    Quantidade = 32,
                    Entrada = "saida",
                    DataEntrada = new DateTime(2012, 10, 12),

                    EmpresaId = 2,
                    ProdutoId = 2,
                    RegistroAtivo = true


                });
            #endregion

            #region Carrinho
            modelBuilder.Entity<Carrinho>().HasData(
                new Carrinho()
                {
                    Id = 1,
                    RegistroAtivo = true,
                    UsuarioId = 1,
                    ValorTotal = 0
                },
                new Carrinho()
                {
                    Id = 2,
                    RegistroAtivo = true,
                    UsuarioId = 2,
                    ValorTotal = 0

                });
            #endregion

            #region itemCompra 
            modelBuilder.Entity<ItemCompra>().HasData(
                new ItemCompra()
                {
                    Id = 1,
                    CompraId = 1,
                    ProdutoId = 1,
                    RegistroAtivo = true

                },
                new ItemCompra()
                {
                    Id = 2,
                    CompraId = 1,
                    ProdutoId = 2,
                    RegistroAtivo = true,

                });
            #endregion



            #region cliente 
            modelBuilder.Entity<Cliente>().HasData(
                new Cliente()
                {
                    Id = 1,
                    Nome = "irineu",
                    Cpf = "59315617061",
                    DataNascimento = new DateTime(2012, 10, 12),
                    Telefone = "2036466360",

                    RegistroAtivo = true,
                    UsuarioId = 1,

                },
                new Cliente()
                {
                    Id = 2,
                    Nome = "jose",
                    Cpf = "59315639061",
                    DataNascimento = new DateTime(2012, 10, 12),
                    Telefone = "2012466360",
                    RegistroAtivo = true,

                    UsuarioId = 2,
                });
            #endregion

            #region cartão
            modelBuilder.Entity<Cartao>().HasData(
                new Cartao()
                {
                    Id = 1,
                    Numero = "123576123",
                    NomeProprietario = "jose",
                    DataVencimento = new DateTime(2010, 12, 12),
                    Cvc = "123",
                    RegistroAtivo = true,

                    ClienteId = 1


                },
                new Cartao()
                {
                    Id = 2,
                    Numero = "12357343",
                    NomeProprietario = "joao",
                    DataVencimento = new DateTime(2012, 10, 12),
                    Cvc = "123",
                    RegistroAtivo = true,

                    ClienteId = 1
                });
            #endregion

        }
    }
}
