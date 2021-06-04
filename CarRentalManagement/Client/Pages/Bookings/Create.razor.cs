using System.Collections.Generic;
using System.Net.Http;
using CarRentalManagement.Client.Static;
using CarRentalManagement.Shared.Domain;
using System.Net.Http.Json;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Authorization;
using System;

namespace CarRentalManagement.Client.Pages.Bookings
{
    [Authorize]
    public partial class Create
    {
        [Inject]
        HttpClient client { get; set; }
        [Inject] 
        NavigationManager navigationManager { get; set; }

        Booking booking= new(){ DateOut = DateTime.Now.Date };
        private IEnumerable<Vehicle> Vehicles;
        private IEnumerable<Customer> Customers;

        protected override async Task OnInitializedAsync ( )
        {
            Vehicles = await client.GetFromJsonAsync<List<Vehicle>> (Endpoints.VehiclesEndpoint);
            Customers = await client.GetFromJsonAsync<List<Customer>> (Endpoints.CustomersEndpoint);
        }

        private async Task CreateBooking ( )
        {
            await client.PostAsJsonAsync (Endpoints.BookingsEndpoint , booking);
            navigationManager.NavigateTo ("/bookings/");
        }
    }
}
