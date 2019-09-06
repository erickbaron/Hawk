using Hawk.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hawk.Repository.Repositories
{
    public class ClienteRepository: IHawkRepository<Cliente>
    {
        private readonly HawkContext context;

        public ClienteRepository(HawkContext context)
        {
            this.context = context;
        }

        public int Add(Cliente entity)
        {
            entity.RegistroAtivo = true;
            context.Clientes.Add(entity);
            context.SaveChanges();
            return entity.Id;
        }

        public bool Delete(int id)
        {
            var cliente = context.Clientes.FirstOrDefault(t => t.Id == id);
            cliente.RegistroAtivo = false;
            context.Clientes.Update(cliente);
            return context.SaveChanges() > 0;
        }

        public Cliente ObterPeloId(int id)
        {
            return context.Clientes.FirstOrDefault(t => t.RegistroAtivo && t.Id == id);
        }

        public List<Cliente> ObterTodos()
        {
            return context.Clientes.Where(t => t.RegistroAtivo).ToList();
        }

        public bool Update(Cliente entity)
        {
            entity.RegistroAtivo = true;
            context.Clientes.Update(entity);
            return context.SaveChanges() > 0;
        }
    }
}
