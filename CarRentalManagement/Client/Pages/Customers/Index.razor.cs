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

namespace CarRentalManagement.Client.Pages.Customers
{
    [Authorize]
    public partial class Index : IDisposable
    {
        [Inject] IHttpRepository<Customer> client { get; set; }
        [Inject] IJSRuntime js { get; set; }

        private IList<Customer> Customers;

        protected override async Task OnInitializedAsync ( )
        {
            Customers = await client.GetAll (Endpoints.CustomersEndpoint);
        }

        protected override async Task OnAfterRenderAsync (bool firstRender)
        {
            await js.InvokeVoidAsync ("addDataTable" , "#customersTable");

        }

        public void Dispose ( )
        {
            js.InvokeVoidAsync ("dataTablesDispose" , "#customersTable");
        }

        async Task Delete (int customerId)
        {
            var customer = Customers.FirstOrDefault (m => m.Id == customerId);
            var confirm = await js.InvokeAsync<bool> ("confirm" , $"Are you sure? You are deleting {customer.TaxId}");

            if (confirm)
            {
                await client.Delete (Endpoints.CustomersEndpoint , customer.Id);
                Customers.Remove (customer);
                StateHasChanged ();
            }

        }
    }
}
