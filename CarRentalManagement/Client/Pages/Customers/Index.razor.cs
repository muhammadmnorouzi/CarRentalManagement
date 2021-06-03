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
    public partial class Index
    {
        [Inject]
        HttpClient client { get; set; }
        [Inject]
        IJSRuntime js { get; set; }

        private List<Customer> Customers;

        protected override async Task OnInitializedAsync ( )
        {
            Customers = await client.GetFromJsonAsync<List<Customer>> (Endpoints.CustomersEndpoint);
        }

        async Task Delete (int customerId)
        {
            var customer = Customers.FirstOrDefault (m => m.Id == customerId);
            var confirm = await js.InvokeAsync<bool> ("confirm" , $"Are you sure? You are deleting {customer.TaxId}");

            if (confirm)
            {
                await client.DeleteAsync ($"{Endpoints.CustomersEndpoint}/{customer.Id}");
                Customers.Remove (customer);
                StateHasChanged();
            }

        }
    }
}
