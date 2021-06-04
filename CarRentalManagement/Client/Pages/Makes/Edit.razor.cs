using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using CarRentalManagement.Client.Static;
using CarRentalManagement.Shared.Domain;
using Microsoft.AspNetCore.Components;

namespace CarRentalManagement.Client.Pages.Makes
{
    public partial class Edit
    {
        [Inject] HttpClient client { get; set; }
        [Inject] NavigationManager navigationManager { get; set; }

        [Parameter] public int id { get; set; }
        public Make make{ get; set; } = new ();

        protected override async Task OnParametersSetAsync ( )
        {
            make =  await client.GetFromJsonAsync<Make>($"{Endpoints.MakesEndpoint}/{id}");
        }

        private async Task EditMake ( )
        {
            await client.PutAsJsonAsync ($"{Endpoints.MakesEndpoint}/{id}" , make);
            navigationManager.NavigateTo ("/makes/");
        }

    }
}
