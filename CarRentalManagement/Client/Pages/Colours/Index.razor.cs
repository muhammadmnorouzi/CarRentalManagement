using CarRentalManagement.Client.Interfaces;
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
    public partial class Index : IDisposable
    {
        [Inject] IHttpRepository<Colour> client { get; set; }
        [Inject] IJSRuntime js { get; set; }

        private IList<Colour> Colours;

        protected override async Task OnInitializedAsync ( )
        {
            Colours = await client.GetAll (Endpoints.ColoursEndpoint);
        }

        protected override async Task OnAfterRenderAsync (bool firstRender)
        {
            await js.InvokeVoidAsync ("addDataTable" , "#coloursTable");

        }

        public void Dispose ( )
        {
            js.InvokeVoidAsync ("dataTablesDispose" , "#coloursTable");
        }

        async Task Delete (int colourId)
        {
            var colour = Colours.FirstOrDefault (m => m.Id == colourId);
            var confirm = await js.InvokeAsync<bool> ("confirm" , $"Are you sure? You are deleting {colour.Name}");

            if (confirm)
            {
                await client.Delete (Endpoints.ColoursEndpoint , colour.Id);
                Colours.Remove (colour);
                StateHasChanged ();
            }

        }
    }
}
