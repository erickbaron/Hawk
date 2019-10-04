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
                    Nome = "Notebook Lenovo IdeaPad 330",
                    Descricao = "Notebook Intel Core i7 8550U 15,6' 8GB HD 1 TB GeForce MX150 Windows 10",
                    ValorCusto = 2100,
                    ValorVenda = 2915,
                    Altura = 2,
                    Largura = 38,
                    Comprimento = 26,
                    Peso = 2,
                    Promocao = false,
                    NomeArquivo = "imagem-1.jpg",
                    NomeHash = "",
                    RegistroAtivo = true,

                    EmpresaId = 1,
                    CategoriaId = 1,
                },
                new Produto()
                {
                    Id = 2,
                    Nome = "Smartphone Samsung Galaxy S9",
                    Descricao = "Smartphone Samsung Galaxy S9 SM-G9600 128GB",
                    ValorCusto = 1300,
                    ValorVenda = 1889,
                    Altura = 14,
                    Largura = 7,
                    Comprimento = 1,
                    Peso = 163,
                    Promocao = false,
                    NomeArquivo = "imagem-2.jpg",
                    NomeHash = "",

                    RegistroAtivo = true,

                    EmpresaId = 2,
                    CategoriaId = 2,
                },
                new Produto()
                {
                    Id = 3,
                    Nome = "Caixa de Som Xtreme 2 JBL",
                    Descricao = "Caixa de Som Xtreme 2 JBL Preta 40W RMS",
                    ValorCusto = 500,
                    ValorVenda = 949,
                    Altura = 136,
                    Largura = 288,
                    Comprimento = 132,
                    Peso = 3,
                    Promocao = false,
                    NomeArquivo = "imagem3.jpg",
                    NomeHash = "",
                    RegistroAtivo = true,

                    EmpresaId = 1,
                    CategoriaId = 1,
                },
                new Produto()
                {
                    Id = 4,
                    Nome = "Headphone JBL",
                    Descricao = "Headphone Bluetooth com Microfone JBL Tune 500BT",
                    ValorCusto = 98,
                    ValorVenda = 198,
                    Altura = 10,
                    Largura = 5,
                    Comprimento = 5,
                    Peso = 100,
                    Promocao = false,
                    NomeArquivo = "imagem4.jpg",
                    NomeHash = "",

                    RegistroAtivo = true,

                    EmpresaId = 2,
                    CategoriaId = 2,
                },                
                new Produto()
                {
                    Id = 5,
                    Nome = "Game God Of War - PS4",
                    Descricao = "God of War é um jogo eletrônico de ação-aventura desenvolvido pela Santa Monica Studio e publicado pela Sony Interactive Entertainment.",
                    ValorCusto = 3,
                    ValorVenda = 80,
                    Altura = 2,
                    Largura = 2,
                    Comprimento = 2,
                    Peso = 10,
                    Promocao = false,
                    NomeArquivo = "imagem-5.jpg",
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
                    Quantidade = 1,
                    RegistroAtivo = true

                },
                new ItemCompra()
                {
                    Id = 2,
                    CompraId = 1,
                    ProdutoId = 2,
                    Quantidade = 3,
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
