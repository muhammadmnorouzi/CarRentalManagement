using System.Threading.Tasks;

namespace CarRentalManagement.Client.Interfaces
{
    public interface IHttpInterceptorService
    {
        void DisposeEvent ( );
        void MonitorEvent ( );
    }
}