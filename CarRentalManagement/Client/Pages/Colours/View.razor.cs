using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using CarRentalManagement.Client.Static;
using CarRentalManagement.Shared.Domain;
using Microsoft.AspNetCore.Components;

namespace CarRentalManagement.Client.Pages.Colours
{
    public partial class View
    {
        [Inject] HttpClient client { get; set; }

        [Parameter] public int id { get; set; }
        public Colour colour { get; set; } = new ();

        protected override async Task OnParametersSetAsync ( )
        {
            colour = await client.GetFromJsonAsync<Colour> ($"{Endpoints.ColoursEndpoint}/{id}");
        }
    }
}
