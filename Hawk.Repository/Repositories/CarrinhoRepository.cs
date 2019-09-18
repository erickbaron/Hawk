using Hawk.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hawk.Repository.Repositories
{
    public class CarrinhoRepository : IHawkRepository<Carrinho>
    {
        private readonly HawkContext context;

        public CarrinhoRepository(HawkContext context)
        {
            this.context = context;
        }

        public int Add(Carrinho entity)
        {
            entity.RegistroAtivo = true;
            context.Carrinhos.Add(entity);
            context.SaveChanges();
            return entity.Id;
        }

        public bool Delete(int id)
        {
            var carrinho = context.Carrinhos.FirstOrDefault(t => t.Id == id);
            carrinho.RegistroAtivo = false;
            context.Carrinhos.Update(carrinho);
            return context.SaveChanges() > 0;
        }

        public Carrinho ObterPeloId(int id)
        {
            return context.Carrinhos.FirstOrDefault(t => t.RegistroAtivo && t.Id == id);
        }

        public List<Carrinho> ObterTodos()
        {
            return context.Carrinhos.Where(t => t.RegistroAtivo).ToList();
        }

        public bool Update(Carrinho entity)
        {
            entity.RegistroAtivo = true;
            context.Carrinhos.Update(entity);
            return context.SaveChanges() > 0;
        }
    }
}
