using CarRentalManagement.Client.Static;
using CarRentalManagement.Shared.Domain;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace CarRentalManagement.Client.Pages.Colours
{
    [Authorize]
    public partial class Index
    {
        [Inject]
        HttpClient client { get; set; }
        [Inject]
        IJSRuntime js { get; set; }

        private List<Colour> Colours;

        protected override async Task OnInitializedAsync ( )
        {
            Colours = await client.GetFromJsonAsync<List<Colour>> (Endpoints.ColoursEndpoint);
        }

        async Task Delete (int colourId)
        {
            var colour = Colours.FirstOrDefault (m => m.Id == colourId);
            var confirm = await js.InvokeAsync<bool> ("confirm" , $"Are you sure? You are deleting {colour.Name}");

            if (confirm)
            {
                await client.DeleteAsync ($"{Endpoints.ColoursEndpoint}/{colour.Id}");
                Colours.Remove (colour);
                StateHasChanged();
            }

        }
    }
}
