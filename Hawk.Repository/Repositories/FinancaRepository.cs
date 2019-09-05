using Hawk.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hawk.Repository.Repositories
{
    public class FinancaRepository : IHawkRepository<Financa>
    {
        private readonly HawkContext context;

        public FinancaRepository(HawkContext context)
        {
            this.context = context;
        }

        public int Add(Financa entity)
        {
            entity.RegistroAtivo = true;
            context.Financas.Add(entity);
            context.SaveChanges();
            return entity.Id;
        }

        public bool Delete(int id)
        {
            var financa = context.Financas.FirstOrDefault(t => t.Id == id);
            financa.RegistroAtivo = false;
            context.Financas.Update(financa);
            return context.SaveChanges() > 0;
        }

        public Financa ObterPeloId(int id)
        {
            return context.Financas.FirstOrDefault(t => t.RegistroAtivo && t.Id == id);
        }

        public List<Financa> ObterTodos()
        {
            return context.Financas.Where(t => t.RegistroAtivo).ToList();
        }

        public bool Update(Financa entity)
        {
            entity.RegistroAtivo = true;
            context.Financas.Update(entity);
            return context.SaveChanges() > 0;
        }
    }
}
