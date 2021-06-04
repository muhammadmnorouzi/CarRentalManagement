using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using CarRentalManagement.Client.Static;
using CarRentalManagement.Shared.Domain;
using Microsoft.AspNetCore.Components;

namespace CarRentalManagement.Client.Pages.Vehicles
{
    public partial class FormComponent
    {
        [Inject] HttpClient client { get; set; }

        [Parameter] public Vehicle Vehicle{ get; set; }
        [Parameter] public string ButtonText { get; set; }
        [Parameter] public EventCallback OnValidSubmit { get; set; }

        // TODO : dynamic styling by class attribute
        //[Parameter] public string @class { get; set; } = ;

        private IEnumerable<Make> Makes;
        private IEnumerable<Model> Models;
        private IEnumerable<Colour> Colours;

        protected override async Task OnInitializedAsync ( )
        {
            Makes = await client.GetFromJsonAsync<List<Make>> (Endpoints.MakesEndpoint);
            Models = await client.GetFromJsonAsync<List<Model>> (Endpoints.ModelsEndpoint);
            Colours = await client.GetFromJsonAsync<List<Colour>> (Endpoints.ColoursEndpoint);
        }

        
    }
}
