using Hawk.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hawk.Repository.Repositories
{
    public class EnderecoClienteRepository : IHawkRepository<EnderecoCliente>
    {
        private readonly HawkContext context;

        public EnderecoClienteRepository(HawkContext context)
        {
            this.context = context;
        }

        public int Add(EnderecoCliente entity)
        {
            entity.RegistroAtivo = true;
            context.EnderecosClientes.Add(entity);
            context.SaveChanges();
            return entity.Id;
        }

        public bool Delete(int id)
        {
            var enderecoCliente = context.EnderecosClientes.FirstOrDefault(t => t.Id == id);
            enderecoCliente.RegistroAtivo = false;
            context.EnderecosClientes.Update(enderecoCliente);
            return context.SaveChanges() > 0;
        }

        public EnderecoCliente ObterPeloId(int id)
        {
            return context.EnderecosClientes.FirstOrDefault(t => t.RegistroAtivo && t.Id == id);
        }

        public List<EnderecoCliente> ObterTodos()
        {
            return context.EnderecosClientes.Where(t => t.RegistroAtivo).ToList();
        }

        public bool Update(EnderecoCliente entity)
        {
            entity.RegistroAtivo = true;
            context.EnderecosClientes.Update(entity);
            return context.SaveChanges() > 0;
        }
    }
}
