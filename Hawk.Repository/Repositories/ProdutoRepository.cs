using Hawk.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hawk.Repository.Repositories
{
    public class ProdutoRepository : IHawkRepository<Produto>
    {
        private readonly HawkContext context;

        public ProdutoRepository(HawkContext context)
        {
            this.context = context;
        }

        public int Add(Produto entity)
        {
            entity.RegistroAtivo = true;
            context.Produtos.Add(entity);
            context.SaveChanges();
            return entity.Id;
        }

        public bool Delete(int id)
        {
            var produto = context.Produtos.FirstOrDefault(t => t.Id == id);
            produto.RegistroAtivo = false;
            context.Produtos.Update(produto);
            return context.SaveChanges() > 0;
        }

        public Produto ObterPeloId(int id)
        {
            return context.Produtos.FirstOrDefault(t => t.RegistroAtivo && t.Id == id);
        }

        public List<Produto> ObterTodos()
        {
            return context.Produtos.Where(t => t.RegistroAtivo).ToList();
        }

        public bool Update(Produto entity)
        {
            entity.RegistroAtivo = true;
            context.Produtos.Update(entity);
            return context.SaveChanges() > 0;
        }

        public Produto ObterPeloNomeHash(string hash)
        {
            return this.context.Produtos.FirstOrDefault(x => x.NomeHash == hash);
        }
    }
}
