using System.Drawing;
using System.Net.Http;
using System.Net.Http.Json;
using System.Reflection;
using System.Threading.Tasks;
using CarRentalManagement.Client.Static;
using CarRentalManagement.Shared.Domain;
using Microsoft.AspNetCore.Components;

namespace CarRentalManagement.Client.Pages.Vehicles
{
    public partial class Edit
    {
        [Inject] HttpClient client { get; set; }
        [Inject] NavigationManager navigationManager { get; set; }

        [Parameter] public int id { get; set; }
        public Vehicle vehicle{ get; set; } = new ();

        protected override async Task OnParametersSetAsync ( )
{
            vehicle =  await client.GetFromJsonAsync<Vehicle> ($"{Endpoints.VehiclesEndpoint}/{id}");
        }

        private async Task EditVehicle( )
        {
            await client.PutAsJsonAsync ($"{Endpoints.VehiclesEndpoint}/{id}" , vehicle);
            navigationManager.NavigateTo ("/vehicles/");
        }

    }
}
