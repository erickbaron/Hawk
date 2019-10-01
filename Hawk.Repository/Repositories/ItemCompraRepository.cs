using Hawk.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hawk.Repository.Repositories
{
    public class ItemCompraRepository : IHawkRepository<ItemCompra>
    {
        private readonly HawkContext context;

        public ItemCompraRepository(HawkContext context)
        {
            this.context = context;
        }

        public int Add(ItemCompra entity)
        {
            entity.RegistroAtivo = true;
            context.ItensCompras.Add(entity);
            context.SaveChanges();
            return entity.Id;
        }

        public bool Delete(int id)
        {
            var itemCompra = context.ItensCompras.FirstOrDefault(t => t.Id == id);
            itemCompra.RegistroAtivo = false;
            context.ItensCompras.Update(itemCompra);
            return context.SaveChanges() > 0;
        }

        public ItemCompra ObterPeloId(int id)
        {
            return context.ItensCompras.FirstOrDefault(t => t.RegistroAtivo && t.Id == id);
        }

        public List<ItemCompra> ObterTodos()
        {
            return context.ItensCompras
                .Include(x => x.Produto)
                .Where(t => t.RegistroAtivo).ToList();
        }

        public bool Update(ItemCompra entity)
        {
            entity.RegistroAtivo = true;
            context.ItensCompras.Update(entity);
            return context.SaveChanges() > 0;
        }
    }
}
