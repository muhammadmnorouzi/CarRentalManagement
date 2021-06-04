using System.Collections.Generic;
using System.Threading.Tasks;
using CarRentalManagement.Shared.Domain;

namespace CarRentalManagement.Client.IRepositories
{
    public interface IBaseRepository<T> where T : BaseDomainModel
    {
        Task Delete(int id);
        Task<IEnumerable<T>> GetAll();
        Task<T> Get(int id);
        Task<T> Add(T entity);
        Task Update(T entity);
    }
}
