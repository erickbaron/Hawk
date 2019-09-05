using Hawk.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hawk.Repository.Repositories
{
    class ProdutoFavoritoRepository : IHawkRepository<ProdutoFavorito>
    {
        private readonly HawkContext context;

        public ProdutoFavoritoRepository(HawkContext context)
        {
            this.context = context;
        }

        public int Add(ProdutoFavorito entity)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public ProdutoFavorito ObterPeloId(int id)
        {
            throw new NotImplementedException();
        }

        public List<ProdutoFavorito> ObterTodos()
        {
            throw new NotImplementedException();
        }

        public bool Update(ProdutoFavorito entity)
        {
            throw new NotImplementedException();
        }
    }
}
