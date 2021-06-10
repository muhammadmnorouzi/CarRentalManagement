using System.Drawing;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using CarRentalManagement.Client.Interfaces;
using CarRentalManagement.Client.Static;
using CarRentalManagement.Shared.Domain;
using Microsoft.AspNetCore.Components;

namespace CarRentalManagement.Client.Pages.Colours
{
    public partial class Edit
    {
        [Inject] IHttpRepository<Colour> client { get; set; }
        [Inject] NavigationManager navigationManager { get; set; }

        [Parameter] public int id { get; set; }
        public Colour colour{ get; set; } = new ();

        protected override async Task OnParametersSetAsync ( )
{
            colour =  await client.Get (Endpoints.ColoursEndpoint , id);
        }

        private async Task EditColour( )
        {
            await client.Update (Endpoints.ColoursEndpoint,colour,id);
            navigationManager.NavigateTo ("/colours/");
        }

    }
}
