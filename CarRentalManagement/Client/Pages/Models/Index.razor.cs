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
using System.Reflection;
using System.Threading.Tasks;

namespace CarRentalManagement.Client.Pages.Models
{
    [Authorize]
    public partial class Index : IDisposable
    {
        [Inject] IHttpRepository<Model> client { get; set; }
        [Inject] IJSRuntime js { get; set; }

        private IList<Model> Models;

        protected override async Task OnInitializedAsync ( )
        {
            Models = await client.GetAll (Endpoints.ModelsEndpoint);
        }

        protected override async Task OnAfterRenderAsync (bool firstRender)
        {
            await js.InvokeVoidAsync ("addDataTable" , "#modelsTable");

        }

        public void Dispose ( )
        {
            js.InvokeVoidAsync ("dataTablesDispose" , "#modelsTable");
        }

        async Task Delete (int modelId)
        {
            var model = Models.FirstOrDefault (m => m.Id == modelId);
            var confirm = await js.InvokeAsync<bool> ("confirm" , $"Are you sure? You are deleting {model.Name}");

            if (confirm)
            {
                await client.Delete (Endpoints.ModelsEndpoint , model.Id);
                Models.Remove (model);
                StateHasChanged ();
            }

        }
    }
}
