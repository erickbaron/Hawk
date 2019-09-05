using Hawk.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hawk.Repository.Repositories
{
    public class CategoriaRepository : IHawkRepository<Categoria>
    {
        private readonly HawkContext context;

        public CategoriaRepository(HawkContext context)
        {
            this.context = context;
        }

        public int Add(Categoria entity)
        {
            entity.RegistroAtivo = true;
            context.Categorias.Add(entity);
            context.SaveChanges();
            return entity.Id;
        }

        public bool Delete(int id)
        {
            var cliente = context.Categorias.FirstOrDefault(t => t.Id == id);
            cliente.RegistroAtivo = false;
            context.Categorias.Update(cliente);
            return context.SaveChanges() > 0;
        }

        public Categoria ObterPeloId(int id)
        {
             return context.Categorias.FirstOrDefault(t => t.RegistroAtivo && t.Id == id);
        }

        public List<Categoria> ObterTodos()
        {
            return context.Categorias.Where(t => t.RegistroAtivo).ToList();
        }

        public bool Update(Categoria entity)
        {
            entity.RegistroAtivo = true;
            context.Categorias.Update(entity);
            return context.SaveChanges() > 0;
        }
    }
}
