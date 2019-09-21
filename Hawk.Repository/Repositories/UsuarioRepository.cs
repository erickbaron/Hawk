using Hawk.Domain.Entities;
using Hawk.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hawk.Repository.Repositories
{
    public class UsuarioRepository : IHawkRepository<Usuario>
    {
        private HawkContext context;

        public UsuarioRepository(HawkContext context)
        {
            this.context = context;
        }


        public int Add(Usuario obj)
        {
            obj.RegistroAtivo = true;
            context.Usuarios.Add(obj);
            context.SaveChanges();
            return obj.Id;
        }

        public bool Update(Usuario obj)
        {
            obj.RegistroAtivo = true;
            context.Usuarios.Update(obj);
            return context.SaveChanges() == 1;
        }

        public bool Delete(int id)
        {
            var usuario = context.Usuarios.FirstOrDefault(t => t.Id == id);
            usuario.RegistroAtivo = false;
            context.Usuarios.Update(usuario);
            return context.SaveChanges() == 1;
        }

        public List<Usuario> FiltroParametrizado(int id_param1, int id_param2)
        {
            throw new NotImplementedException();
        }

        public Usuario ObterPeloId(int id)
        {
            return context.Usuarios.FirstOrDefault(t => t.RegistroAtivo && t.Id == id);
        }

        public List<Usuario> ObterTodos()
        {
            return context.Usuarios.Where(t => t.RegistroAtivo).ToList();
        }
    }
}