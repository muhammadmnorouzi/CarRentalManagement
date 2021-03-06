using System.Collections.Generic;
using System.Net.Http;
using CarRentalManagement.Client.Static;
using CarRentalManagement.Shared.Domain;
using System.Net.Http.Json;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Authorization;
using CarRentalManagement.Client.Interfaces;

namespace CarRentalManagement.Client.Pages.Models
{
    [Authorize]
    public partial class Create
    {
        [Inject] IHttpRepository<Model> client { get; set; }
        [Inject] 
        NavigationManager navigationManager { get; set; }

        Model model= new ();

        protected override async Task OnInitializedAsync ( )
        {
            await base.OnInitializedAsync();
        }

        private async Task CreateModel ( )
        {
            await client.Create (Endpoints.ModelsEndpoint , model);
            navigationManager.NavigateTo ("/models/");
        }
    }
}
