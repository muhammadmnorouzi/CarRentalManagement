using System.Collections.Generic;
using System.Net.Http;
using CarRentalManagement.Client.Static;
using CarRentalManagement.Shared.Domain;
using System.Net.Http.Json;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Authorization;
using CarRentalManagement.Client.Interfaces;

namespace CarRentalManagement.Client.Pages.Makes
{
    [Authorize]
    public partial class Create
    {
        [Inject] IHttpRepository<Make> client { get; set; }
        [Inject] NavigationManager navigationManager { get; set; }

        Make make= new ();

        protected override async Task OnInitializedAsync ( )
        {
            await base.OnInitializedAsync();
        }

        private async Task CreateMake ( )
        {
            await client.Create (Endpoints.MakesEndpoint , make);
            navigationManager.NavigateTo ("/makes/");
        }
    }
}
