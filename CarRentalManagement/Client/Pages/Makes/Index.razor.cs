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

namespace CarRentalManagement.Client.Pages.Makes
{
    [Authorize]
    public partial class Index:IDisposable
    {
        [Inject] IHttpRepository<Make> client { get; set; }
        [Inject] IJSRuntime js { get; set; }

        private IList<Make> Makes;

        protected override async Task OnInitializedAsync ( )
        {
            Makes = await client.GetAll(Endpoints.MakesEndpoint);
        }

        protected override async Task OnAfterRenderAsync (bool firstRender)
        {
            await js.InvokeVoidAsync ("addDataTable" , "#makesTable");

        }

        public void Dispose ( )
        {
            js.InvokeVoidAsync ("dataTablesDispose" , "#makesTable");
        }

        async Task Delete (int modelId)
        {
            var make = Makes.FirstOrDefault (m => m.Id == modelId);
            var confirm = await js.InvokeAsync<bool> ("confirm" , $"Are you sure? You are deleting {make.Name}");

            if (confirm)
            {
                await client.Delete (Endpoints.MakesEndpoint,make.Id);
                Makes.Remove (make);
                StateHasChanged();
            }

        }
    }
}
