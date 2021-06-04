using System.Drawing;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using CarRentalManagement.Client.Static;
using CarRentalManagement.Shared.Domain;
using Microsoft.AspNetCore.Components;

namespace CarRentalManagement.Client.Pages.Customers
{
    public partial class Edit
    {
        [Inject] HttpClient client { get; set; }
        [Inject] NavigationManager navigationManager { get; set; }

        [Parameter] public int id { get; set; }
        public Customer customer{ get; set; } = new ();

        protected override async Task OnParametersSetAsync ( )
{
            customer =  await client.GetFromJsonAsync<Customer> ($"{Endpoints.CustomersEndpoint}/{id}");
        }

        private async Task EditCustomer( )
        {
            await client.PutAsJsonAsync ($"{Endpoints.CustomersEndpoint}/{id}" , customer);
            navigationManager.NavigateTo ("/customers/");
        }

    }
}
