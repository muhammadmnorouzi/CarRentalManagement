using System.Collections.Generic;
using System.Net.Http;
using CarRentalManagement.Client.Static;
using CarRentalManagement.Shared.Domain;
using System.Net.Http.Json;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Authorization;
using CarRentalManagement.Client.Interfaces;

namespace CarRentalManagement.Client.Pages.Vehicles
{
    [Authorize]
    public partial class Create
    {
        [Inject] IHttpRepository<Vehicle> client { get; set; }
        [Inject] NavigationManager navigationManager { get; set; }

        Vehicle vehicle = new ();

        protected override async Task OnInitializedAsync ( )
        {
            await base.OnInitializedAsync();
        }

        private async Task CreateVehicle ( )
        {
            await client.Create (Endpoints.VehiclesEndpoint , vehicle);
            navigationManager.NavigateTo ("/vehicles/");
        }
    }
}
