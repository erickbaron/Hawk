using System.Collections.Generic;
using System.Linq;
using Hawk.Domain.Entities;

namespace Hawk.Repository.Repositories
{
    public class CartaoRepository : IHawkRepository<Cartao>
    {
        private HawkContext context;

        public CartaoRepository(HawkContext context)
        {
            this.context = context;
        }

        public int Add(Cartao entity)
        {
            entity.RegistroAtivo = true;
            context.Cartoes.Add(entity);
            context.SaveChanges();
            return entity.Id;
        }

        public bool Delete(int id)
        {
            var cartao = context.Cartoes.FirstOrDefault(t => t.Id == id);
            cartao.RegistroAtivo = false;
            context.Cartoes.Update(cartao);
            return context.SaveChanges() > 0;
        }

        public Cartao ObterPeloId(int id)
        {
            return context.Cartoes.FirstOrDefault(t => t.RegistroAtivo && t.Id == id);
        }

        public List<Cartao> ObterTodos()
        {
            return context.Cartoes.Where(t => t.RegistroAtivo).ToList();
        }

        public bool Update(Cartao entity)
        {
            entity.RegistroAtivo = true;
            context.Cartoes.Update(entity);
            return context.SaveChanges() > 0;
        }
    }
}