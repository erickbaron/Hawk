using Hawk.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hawk.Repository
{
    public interface ICarrinhoRepository
    {
        int Add(Carrinho entity);

        bool Update(Carrinho entity);

        bool Delete(int id);

        List<Carrinho> ObterTodos();

        Carrinho ObterPeloId(int id);

        Carrinho ObterCarrinhoAbertoPeloIdUsuario(int idUsuario);
    }
}
