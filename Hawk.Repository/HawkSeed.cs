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
                    Nome = "Calabresa",
                    RegistroAtivo = true
                });
            #endregion

            #region Usuario  
            modelBuilder.Entity<Usuario>().HasData(
                new Usuario()
                {
                    Id = 1,
                    Nome = "Erick",
                    Email = "erickbaron@gmail.com",
                    Senha = "1234",
                    Administrador = false,
                    RegistroAtivo = true
                },
                new  Usuario()
                {
                    Id = 2,
                    Nome = "Joao",
                    Email = "Jozinho@gmail.com",
                    Senha = "4321",
                    Administrador = true,
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
                    RegistroAtivo = true,

                    UsuarioId = 1
                },
                new Empresa()
                {
                    Id = 2,
                    Nome = "Hanes",
                    Cnpj = "83.757.980/0001-07",
                    Telefone = "2036466370",
                    Ramo = "comida",
                    RegistroAtivo = true,

                    UsuarioId = 2
                });
            #endregion

            #region EndereçoEmpresa
            modelBuilder.Entity<EnderecoEmpresa>().HasData(
                new EnderecoEmpresa()
                {
                    Id = 1,
                    Estado ="Sao Paulo",
                    Cidade ="Sao Paulo",
                    Cep = "04180112",
                    Logradouro ="virando a esquina",
                    Numero = "1222",
                    Complemento = " ",
                    RegistroAtivo = true,
                     
                    EmpresaId = 1
                },
                new EnderecoEmpresa()
                {
                    Id = 2,
                    Estado = "Rio de janeiro",
                    Cidade = "rio de janeiro",
                    Cep = "04180113",
                    Logradouro = "Rua principal",
                    Numero = "123",
                    Complemento = " ",
                    RegistroAtivo = true,

                    EmpresaId = 2
                });
            #endregion

            #region EndereçoCliente
            modelBuilder.Entity<EnderecoCliente>().HasData(
                new EnderecoCliente()
                {
                    Id = 1,
                    Estado = "Sao Paulo",
                    Cidade = "Sao Paulo",
                    Cep = "04180112",
                    Logradouro = "virando a esquina",
                    Numero = "1222",
                    Complemento = " ",
                    RegistroAtivo = true,

                    ClienteId = 1
                },
                new EnderecoCliente()
                {
                    Id = 2,
                    Estado = "Rio de janeiro",
                    Cidade = "rio de janeiro",
                    Cep = "04180113",
                    Logradouro = "Rua principal",
                    Numero = "123",
                    Complemento = " ",
                    RegistroAtivo = true,

                    ClienteId = 2
                });
            #endregion

            #region AvaliaçãoEmpresa
            modelBuilder.Entity<AvaliacaoEmpresa>().HasData(
                new AvaliacaoEmpresa()
                {
                    Id = 1,
                    Comentario = "hfgghsdgfhsdgfjhgs",
                    Nota = 5,
                    RegistroAtivo = true,

                   EmpresaId =1
                },
                new AvaliacaoEmpresa()
                {
                    Id = 2,
                    Comentario = "ehuehuehueheu",
                    Nota = 4,
                    RegistroAtivo = true,

                    EmpresaId = 1
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
                    RegistroAtivo = true,

                    EmpresaId = 2,
                    CategoriaId = 2,
                });
            #endregion

            #region compra 
            modelBuilder.Entity<Compra>().HasData(
                new Compra()
                {
                    Id = 1,
                    ValorTotal = 12333,
                    Desconto = 0,
                    RegistroAtivo = true,

                    ClienteId= 1
                },
                new Compra()
                {
                    Id = 2,
                    ValorTotal = 1433,
                    Desconto = 2,
                    RegistroAtivo = true,

                    ClienteId = 2

                });
            #endregion

            #region estoque
            modelBuilder.Entity<Estoque>().HasData(
                new Estoque()
                {
                    Id = 1,
                    Quantidade = 2,
                    Entrada = true,
                    DataEntrada =  new DateTime(2012, 10, 12),

                    EmpresaId = 1,
                    ProdutoId = 1
                },
                new Estoque ()
                {
                    Id = 2,
                    Quantidade = 32,
                    Entrada = false,
                    DataEntrada = new DateTime(2012, 10, 12),

                    EmpresaId = 2,
                    ProdutoId = 2

                });
                #endregion

            #region finaças
            modelBuilder.Entity<Financa>().HasData(
                 new Financa()
                 {
                     Id = 1,
                     ValorCusto = 2,
                     ValorVenda = 200,
                     Lucro = 198,
                     RegistroAtivo = true,

                     CompraId = 1,
                     EmpresaId = 1
                         
                 },
                 new Financa()
                 {
                     Id = 2,
                     ValorCusto = 3,
                     ValorVenda = 303,
                     Lucro = 300,
                     RegistroAtivo = true,

                     CompraId = 2,
                     EmpresaId = 2

                 });
            #endregion

            #region itemCompra 
            modelBuilder.Entity<ItemCompra>().HasData(
                new ItemCompra()
                {
                    Id = 1,
                    ValorItem = 2,
                    RegistroAtivo = true,

                    ProdutoId = 1,
                    CompraId = 1
                },
                new ItemCompra()
                {
                    Id = 2,
                    ValorItem = 1123,
                    RegistroAtivo = true,

                    ProdutoId = 2,
                    CompraId = 2
                });
            #endregion

            #region produtoFavorito
            modelBuilder.Entity<ProdutoFavorito>().HasData(
                new ProdutoFavorito()
                {
                    Id = 1,
                    RegistroAtivo =true,

                    ProdutoId = 1,
                    ClienteId =1
                },
                new ProdutoFavorito()
                {
                    Id = 2,
                    RegistroAtivo = true,

                    ProdutoId = 2,
                    ClienteId = 2
                });
            #endregion

            #region cliente 
            modelBuilder.Entity<Cliente>().HasData(
                new Cliente()
                {
                    Id = 1,
                   Nome = "irineu",
                   Cpf = "59315617061",
                   DataNascimento= new DateTime(2012, 10, 12),
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

                    UsuarioId = 1,
                });
            #endregion

            #region valiliaçãoProduto
            modelBuilder.Entity<AvaliacaoProduto>().HasData(
                new AvaliacaoProduto()
                {
                    Id = 1,
                    Comentario = "abfkjgadkfgakf",
                    Nota = 5,
                    RegistroAtivo = true,
                     
                    ProdutoId =1
                },
                new AvaliacaoProduto()
                {
                    Id = 2,
                    Comentario = "fçaksdçmakd",
                    Nota = 5,
                    RegistroAtivo = true,

                    ProdutoId = 1
                });
            #endregion

            #region cartão
            modelBuilder.Entity<Cartao>().HasData(
                new Cartao()
                {
                    Id = 1,
                    Numero= "123576123",
                    NomeProprietario = "jose",
                    DataVencimento = new DateTime (2010,12,12),
                    Cvc = "123",
                    RegistroAtivo =true,

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
