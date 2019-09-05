using System.Collections.Generic;
using System.Linq;
using Hawk.Domain.Entities;

namespace Hawk.Repository.Repositories
{
    public class UsuarioRepository : IHawkRepository<Usuario>
    {
        private HawkContext context;

        public UsuarioRepository(HawkContext context)
        {
            this.context = context;
        }

        public int Add(Usuario entity)
        {
            entity.RegistroAtivo = true;
            context.Usuarios.Add(entity);
            context.SaveChanges();
            return entity.Id;
        }

        public bool Delete(int id)
        {
            var cartao = context.Usuarios.FirstOrDefault(t => t.Id == id);
            cartao.RegistroAtivo = false;
            context.Usuarios.Update(cartao);
            return context.SaveChanges() > 0;
        }

        public Usuario ObterPeloId(int id)
        {
            return context.Usuarios.FirstOrDefault(t => t.RegistroAtivo && t.Id == id);
        }

        public List<Usuario> ObterTodos()
        {
            return context.Usuarios.Where(t => t.RegistroAtivo).ToList();
        }

        public bool Update(Usuario entity)
        {
            entity.RegistroAtivo = true;
            context.Usuarios.Update(entity);
            return context.SaveChanges() > 0;
        }
    }
}