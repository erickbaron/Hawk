using Hawk.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hawk.Repository.Repositories
{
    class EnderecoEmpresaRepository : IHawkRepository<EnderecoEmpresa>
    {
        private readonly HawkContext context;

        public EnderecoEmpresaRepository(HawkContext context)
        {
            this.context = context;
        }

        public int Add(EnderecoEmpresa entity)
        {
            entity.RegistroAtivo = true;
            context.EnderecosEmpresas.Add(entity);
            context.SaveChanges();
            return entity.Id;
        }

        public bool Delete(int id)
        {
            var enderecoEmpresa = context.EnderecosEmpresas.FirstOrDefault(t => t.Id == id);
            enderecoEmpresa.RegistroAtivo = false;
            context.EnderecosEmpresas.Update(enderecoEmpresa);
            return context.SaveChanges() > 0;
        }

        public EnderecoEmpresa ObterPeloId(int id)
        {
            return context.EnderecosEmpresas.FirstOrDefault(t => t.RegistroAtivo && t.Id == id);
        }

        public List<EnderecoEmpresa> ObterTodos()
        {
            return context.EnderecosEmpresas.Where(t => t.RegistroAtivo).ToList();
        }

        public bool Update(EnderecoEmpresa entity)
        {
            entity.RegistroAtivo = true;
            context.EnderecosEmpresas.Update(entity);
            return context.SaveChanges() > 0;
        }
    }
}
