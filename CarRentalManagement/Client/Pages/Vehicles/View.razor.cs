using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using CarRentalManagement.Client.Static;
using CarRentalManagement.Shared.Domain;
using Microsoft.AspNetCore.Components;

namespace CarRentalManagement.Client.Pages.Vehicles
{
    public partial class View
    {
        [Inject] HttpClient  client{ get; set; }

        [Parameter] public int id { get; set; }

        public Vehicle vehicle { get; set; } = new ();

        protected override async Task OnParametersSetAsync ( )
        {
            vehicle = await client.GetFromJsonAsync<Vehicle> ($"{Endpoints.VehiclesEndpoint}/{id}");
        }
    }
}
