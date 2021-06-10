using System.Collections.Generic;
using System.Net.Http;
using CarRentalManagement.Client.Static;
using CarRentalManagement.Shared.Domain;
using System.Net.Http.Json;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Authorization;
using CarRentalManagement.Client.Interfaces;

namespace CarRentalManagement.Client.Pages.Customers
{
    [Authorize]
    public partial class Create
    {
        [Inject] IHttpRepository<Customer> client { get; set; }
        [Inject] NavigationManager navigationManager { get; set; }

        Customer customer= new ();

        protected override async Task OnInitializedAsync ( )
        {
            await base.OnInitializedAsync();
        }

        private async Task CreateCustomer ( )
        {
            await client.Create (Endpoints.CustomersEndpoint , customer);
            navigationManager.NavigateTo ("/customers/");
        }
    }
}
