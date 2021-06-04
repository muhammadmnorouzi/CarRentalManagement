using System.Collections.Generic;
using System.Threading.Tasks;

namespace CarRentalManagement.Client.IServices
{
    public interface IHttpService
    {
        void SetBaseAddress (string baseAddress);
        Task<bool> Put<T> (T entity);
        Task<TResult> Post<T, TResult> (T entity);
        Task<bool> Delete(int id);
        Task<TResult> Get<TResult> (int entityId);
        Task<IEnumerable<TResult>> GetAll<TResult> ();
    }
}
