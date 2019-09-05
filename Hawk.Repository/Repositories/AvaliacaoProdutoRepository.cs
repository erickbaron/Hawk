using Hawk.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hawk.Repository.Repositories
{
    public class AvaliacaoProdutoRepository : IHawkRepository<AvaliacaoProduto>
    {
        private readonly HawkContext context;

        public AvaliacaoProdutoRepository(HawkContext context)
        {
            this.context = context;
        }

        public int Add(AvaliacaoProduto entity)
        {
            entity.RegistroAtivo = true;
            context.AvaliacoesProdutos.Add(entity);
            context.SaveChanges();
            return entity.Id;
        }

        public bool Delete(int id)
        {
            var avaliacaoProduto = context.AvaliacoesProdutos.FirstOrDefault(t => t.Id == id);
            avaliacaoProduto.RegistroAtivo = false;
            context.AvaliacoesProdutos.Update(avaliacaoProduto);
            return context.SaveChanges() > 0;
        }

        public AvaliacaoProduto ObterPeloId(int id)
        {
            return context.AvaliacoesProdutos.FirstOrDefault(t => t.RegistroAtivo && t.Id == id);
        }

        public List<AvaliacaoProduto> ObterTodos()
        {
            return context.AvaliacoesProdutos.Where(t => t.RegistroAtivo).ToList();
        }

        public bool Update(AvaliacaoProduto entity)
        {
            entity.RegistroAtivo = true;
            context.AvaliacoesProdutos.Update(entity);
            return context.SaveChanges() > 0;
        }
    }
}
