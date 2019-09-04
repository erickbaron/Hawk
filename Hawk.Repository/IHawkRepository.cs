using Hawk.Domain;
namespace Hawk.Repository
{
    public interface IHawkRepository
    {
        //GERAL
         void Add<T> (T entity) where T : class;

         void Update<T> (T entity) where T : class;

         void Delete<T> (T entity) where T : class;

         Task<bool> SaveChangesAsync();

         //CARTÃO
         Task<Cartao> GetCartaoAsyncById(int ClienteId);

         //ENDEREÇO
         Task<EnderecoCliente> GetEnderecoAsyncById(int ClienteId);
    }

}