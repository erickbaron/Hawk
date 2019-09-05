using Hawk.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hawk.Repository.Repositories
{
    public class EmpresaRepository : IHawkRepository<Empresa>
    {
        private  HawkContext context;

        public EmpresaRepository(HawkContext context)
        {
            this.context = context;
        }

        public int Add(Empresa entity)
        {
            entity.RegistroAtivo = true;
            context.Empresas.Add(entity);
            context.SaveChanges();
            return entity.Id;
        }

        public bool Delete(int id)
        {
            var empresa = context.Empresas.FirstOrDefault(t => t.Id == id);
            empresa.RegistroAtivo = false;
            context.Empresas.Update(empresa);
            return context.SaveChanges() > 0;
        }

        public Empresa ObterPeloId(int id)
        {
            return context.Empresas.FirstOrDefault(t => t.RegistroAtivo && t.Id == id);
        }

        public List<Empresa> ObterTodos()
        {
            return context.Empresas.Where(t => t.RegistroAtivo).ToList();
        }

        public bool Update(Empresa entity)
        {
            entity.RegistroAtivo = true;
            context.Empresas.Update(entity);
            return context.SaveChanges() > 0;
        }
    }
}
