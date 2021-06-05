using System.Threading.Tasks;

namespace CarRentalManagement.Client.IServices
{
    public interface IHttpInterceptorService
    {
        void DisposeEvent ( );
        void MonitorEvent ( );
    }
}