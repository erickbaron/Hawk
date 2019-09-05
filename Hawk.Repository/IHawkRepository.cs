using Hawk.Domain;
using System.Collections.Generic;

namespace Hawk.Repository
{
    public interface IHawkRepository<T>
    {
        
        int Add(T entity);

        bool Update(T entity);

        bool Delete(int id);

        List<T> ObterTodos();

        T ObterPeloId(int id);
    }

}