using CarRentalManagement.Client.Static;
using CarRentalManagement.Shared.Domain;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Reflection;
using System.Threading.Tasks;

namespace CarRentalManagement.Client.Pages.Vehicles
{
    [Authorize]
    public partial class Index
    {
        [Inject]
        HttpClient client { get; set; }
        [Inject]
        IJSRuntime js { get; set; }

        private List<Vehicle> Vehicles;

        protected override async Task OnInitializedAsync ( )
{
            Vehicles = await client.GetFromJsonAsync<List<Vehicle>> (Endpoints.VehiclesEndpoint);
        }

        async Task Delete (int VehicleId)
        {
            var Vehicle = Vehicles.FirstOrDefault (m => m.Id == VehicleId);
            var confirm = await js.InvokeAsync<bool> ("confirm" , $"Are you sure? You are deleting {Vehicle}");

            if (confirm)
            {
                await client.DeleteAsync ($"{Endpoints.VehiclesEndpoint}/{Vehicle.Id}");
                Vehicles.Remove (Vehicle);
                StateHasChanged();
            }

        }
    }
}
