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

namespace CarRentalManagement.Client.Pages.Vehicles
{
    [Authorize]
    public partial class Index : IDisposable
    {
        [Inject] IHttpRepository<Vehicle> client { get; set; }
        [Inject] IJSRuntime js { get; set; }

        private IList<Vehicle> Vehicles;

        protected override async Task OnInitializedAsync ( )
        {
            Vehicles = await client.GetAll (Endpoints.VehiclesEndpoint);
        }

        protected override async Task OnAfterRenderAsync (bool firstRender)
        {
            await js.InvokeVoidAsync ("addDataTable" , "#vehicleTable");

        }

        public void Dispose ( )
        {
            js.InvokeVoidAsync ("dataTablesDispose" , "#vehicleTable");
        }

        async Task Delete (int VehicleId)
        {
            var Vehicle = Vehicles.FirstOrDefault (m => m.Id == VehicleId);
            var confirm = await js.InvokeAsync<bool> ("confirm" , $"Are you sure? You are deleting {Vehicle}");

            if (confirm)
            {
                await client.Delete (Endpoints.VehiclesEndpoint ,Vehicle.Id);
                Vehicles.Remove (Vehicle);
                StateHasChanged ();
            }

        }


    }
}
