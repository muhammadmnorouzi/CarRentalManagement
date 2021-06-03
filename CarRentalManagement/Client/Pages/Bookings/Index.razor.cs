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

namespace CarRentalManagement.Client.Pages.Bookings
{
    [Authorize]
    public partial class Index
    {
        [Inject]
        HttpClient client { get; set; }
        [Inject]
        IJSRuntime js { get; set; }

        private List<Booking> Bookings;

        protected override async Task OnInitializedAsync ( )
        {
            Bookings = await client.GetFromJsonAsync<List<Booking>> (Endpoints.BookingsEndpoint);
        }

        async Task Delete (int bookingId)
        {
            var booking = Bookings.FirstOrDefault (m => m.Id == bookingId);
            var confirm = await js.InvokeAsync<bool> ("confirm" , $"Are you sure? You are deleting booking with tax id: {booking.Customer.TaxId}");

            if (confirm)
            {
                await client.DeleteAsync ($"{Endpoints.CustomersEndpoint}/{booking.Id}");
                Bookings.Remove (booking);
                StateHasChanged();
            }

        }
    }
}
