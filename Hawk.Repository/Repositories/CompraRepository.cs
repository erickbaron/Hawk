using Hawk.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hawk.Repository.Repositories
{
    public class CompraRepository : IHawkRepository<Compra>
    {
        private readonly HawkContext context; 

        public CompraRepository(HawkContext context)
        {
            this.context = context;
        }


        public int Add(Compra entity)
        {
            entity.RegistroAtivo = true;
            context.Compras.Add(entity);
            context.SaveChanges();
            return entity.Id;
        }

        public bool Delete(int id)
        {
            var compra = context.Compras.FirstOrDefault(t => t.Id == id);
            compra.RegistroAtivo = false;
            context.Compras.Update(compra);
            return context.SaveChanges() > 0;
        }

        public Compra ObterPeloId(int id)
        {
            return context.Compras.FirstOrDefault(t => t.RegistroAtivo && t.Id == id);
        }

        public List<Compra> ObterTodos()
        {
            return context.Compras.Where(t => t.RegistroAtivo).ToList();
        }

        public bool Update(Compra entity)
        {
            entity.RegistroAtivo = true;
            context.Compras.Update(entity);
            return context.SaveChanges() > 0;
        }
    }
}
