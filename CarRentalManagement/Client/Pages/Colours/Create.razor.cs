using System.Collections.Generic;
using System.Net.Http;
using CarRentalManagement.Client.Static;
using CarRentalManagement.Shared.Domain;
using System.Net.Http.Json;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Authorization;

namespace CarRentalManagement.Client.Pages.Colours
{
    [Authorize]
    public partial class Create
    {
        [Inject]
        HttpClient client { get; set; }
        [Inject] 
        NavigationManager navigationManager { get; set; }

        Colour colour= new ();

        protected override async Task OnInitializedAsync ( )
        {
            await base.OnInitializedAsync();
        }

        private async Task CreateColour ( )
        {
            await client.PostAsJsonAsync (Endpoints.ColoursEndpoint , colour);
            navigationManager.NavigateTo ("/colours/");
        }
    }
}
