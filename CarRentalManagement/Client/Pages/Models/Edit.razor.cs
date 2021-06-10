using System.Drawing;
using System.Net.Http;
using System.Net.Http.Json;
using System.Reflection;
using System.Threading.Tasks;
using CarRentalManagement.Client.Interfaces;
using CarRentalManagement.Client.Static;
using CarRentalManagement.Shared.Domain;
using Microsoft.AspNetCore.Components;

namespace CarRentalManagement.Client.Pages.Models
{
    public partial class Edit
    {
        [Inject] IHttpRepository<Model> client { get; set; }
        [Inject] NavigationManager navigationManager { get; set; }

        [Parameter] public int id { get; set; }
        public Model model { get; set; } = new ();

        protected override async Task OnParametersSetAsync ( )
        {
            model = await client.Get (Endpoints.ModelsEndpoint , id);
        }

        private async Task EditModel ( )
        {
            await client.Update (Endpoints.ModelsEndpoint , model , id);
            navigationManager.NavigateTo ("/models/");
        }

    }
}
