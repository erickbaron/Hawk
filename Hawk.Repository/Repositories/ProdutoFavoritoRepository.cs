using Hawk.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
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
            entity.RegistroAtivo = true;
            context.ProdutosFavoritos.Add(entity);
            context.SaveChanges();
            return entity.Id;
        }

        public bool Delete(int id)
        {
            var produtoFavorito = context.ProdutosFavoritos.FirstOrDefault(t => t.Id == id);
            produtoFavorito.RegistroAtivo = false;
            context.ProdutosFavoritos.Update(produtoFavorito);
            return context.SaveChanges() > 0;
        }

        public ProdutoFavorito ObterPeloId(int id)
        {
            return context.ProdutosFavoritos.FirstOrDefault(t => t.RegistroAtivo && t.Id == id);
        }

        public List<ProdutoFavorito> ObterTodos()
        {
            return context.ProdutosFavoritos.Where(t => t.RegistroAtivo).ToList();
        }

        public bool Update(ProdutoFavorito entity)
        {
            entity.RegistroAtivo = true;
            context.ProdutosFavoritos.Update(entity);
            return context.SaveChanges() > 0;
        }
    }
}
