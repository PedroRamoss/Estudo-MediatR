using System.Collections.Generic;
using System.Threading.Tasks;

namespace CQRS.Artigo.Repository.Interfaces
{
    public interface IRepository<T> where T : class
    {
        Task<IEnumerable<T>> GetAll();

        Task<T> Get(int id);
        Task Add(T item);

        Task Edit(T item);

        Task Delete(int id);
    }
}
