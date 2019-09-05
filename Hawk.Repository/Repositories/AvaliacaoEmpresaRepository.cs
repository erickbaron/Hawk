using Hawk.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hawk.Repository.Repositories
{
    class AvaliacaoEmpresaRepository : IHawkRepository<AvaliacaoEmpresa>
    {
        private readonly HawkContext context;

        public AvaliacaoEmpresaRepository(HawkContext context)
        {
            this.context = context;
        }

        public int Add(AvaliacaoEmpresa entity)
        {
            entity.RegistroAtivo = true;
            context.AvaliacoesEmpresas.Add(entity);
            context.SaveChanges();
            return entity.Id;
        }

        public bool Delete(int id)
        {
            var avaliacaoempresa = context.AvaliacoesEmpresas.FirstOrDefault(t => t.Id == id);
            avaliacaoempresa.RegistroAtivo = false;
            context.AvaliacoesEmpresas.Update(avaliacaoempresa);
            return context.SaveChanges() > 0;
        }

        public AvaliacaoEmpresa ObterPeloId(int id)
        {
            return context.AvaliacoesEmpresas.FirstOrDefault(t => t.RegistroAtivo && t.Id == id);
        }

        public List<AvaliacaoEmpresa> ObterTodos()
        {
            return context.AvaliacoesEmpresas.Where(t => t.RegistroAtivo).ToList();
        }

        public bool Update(AvaliacaoEmpresa entity)
        {
            entity.RegistroAtivo = true;
            context.AvaliacoesEmpresas.Update(entity);
            return context.SaveChanges() > 0;
        }
    }
}
