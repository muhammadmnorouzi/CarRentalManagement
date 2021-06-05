using System;
using System.Threading.Tasks;
using CarRentalManagement.Client.IServices;
using Microsoft.AspNetCore.Components;

namespace CarRentalManagement.Client.Shared
{

    public partial class MainLayout : IDisposable
    {
        [Inject] IHttpInterceptorService httpInterceptor { get; set; }

        protected override async Task OnInitializedAsync ( )
        {
            httpInterceptor.MonitorEvent();
            await base.OnInitializedAsync();
        }

        public void Dispose ( )
        {
            httpInterceptor.DisposeEvent();
        }
    }
}
