using CarRentalManagement.Client.Static;
using CarRentalManagement.Shared.Domain;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Reflection;
using System.Threading.Tasks;

namespace CarRentalManagement.Client.Pages.Models
{
    [Authorize]
    public partial class Index
    {
        [Inject]
        HttpClient client { get; set; }
        [Inject]
        IJSRuntime js { get; set; }

        private List<Model> Models;

        protected override async Task OnInitializedAsync ( )
{
            Models = await client.GetFromJsonAsync<List<Model>> (Endpoints.ModelsEndpoint);
        }

        async Task Delete (int modelId)
        {
            var model = Models.FirstOrDefault (m => m.Id == modelId);
            var confirm = await js.InvokeAsync<bool> ("confirm" , $"Are you sure? You are deleting {model.Name}");

            if (confirm)
            {
                await client.DeleteAsync ($"{Endpoints.ModelsEndpoint}/{model.Id}");
                Models.Remove (model);
                StateHasChanged();
            }

        }
    }
}
