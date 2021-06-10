using System.Drawing;
using System.Net.Http;
using System.Net.Http.Json;
using System.Reflection;
using System.Threading.Tasks;
using CarRentalManagement.Client.Interfaces;
using CarRentalManagement.Client.Static;
using CarRentalManagement.Shared.Domain;
using Microsoft.AspNetCore.Components;

namespace CarRentalManagement.Client.Pages.Vehicles
{
    public partial class Edit
    {
        [Inject] IHttpRepository<Vehicle> client { get; set; }
        [Inject] NavigationManager navigationManager { get; set; }

        [Parameter] public int id { get; set; }
        public Vehicle vehicle { get; set; } = new ();

        protected override async Task OnParametersSetAsync ( )
        {
            vehicle = await client.Get (Endpoints.VehiclesEndpoint,id);
        }

        private async Task EditVehicle ( )
        {
            await client.Update (Endpoints.VehiclesEndpoint, vehicle , id);
            navigationManager.NavigateTo ("/vehicles/");
        }

    }
}
