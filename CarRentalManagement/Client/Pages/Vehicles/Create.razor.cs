using System.Collections.Generic;
using System.Net.Http;
using CarRentalManagement.Client.Static;
using CarRentalManagement.Shared.Domain;
using System.Net.Http.Json;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Authorization;

namespace CarRentalManagement.Client.Pages.Vehicles
{
    [Authorize]
    public partial class Create
    {
        [Inject]
        HttpClient client { get; set; }
        [Inject] 
        NavigationManager navigationManager { get; set; }

        Vehicle vehicle = new ();
        private IEnumerable<Make> Makes;
        private IEnumerable<Model> Models;
        private IEnumerable<Colour> Colours;

        protected override async Task OnInitializedAsync ( )
        {
            Makes = await client.GetFromJsonAsync<List<Make>> (Endpoints.MakesEndpoint);
            Models = await client.GetFromJsonAsync<List<Model>> (Endpoints.ModelsEndpoint);
            Colours = await client.GetFromJsonAsync<List<Colour>> (Endpoints.ColoursEndpoint);
        }

        private async Task CreateVehicle ( )
        {
            await client.PostAsJsonAsync (Endpoints.VehiclesEndpoint , vehicle);
            navigationManager.NavigateTo ("/vehicles/");
        }
    }
}
