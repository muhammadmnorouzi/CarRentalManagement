using System.Collections.Generic;
using System.Net.Http;
using CarRentalManagement.Client.Static;
using CarRentalManagement.Shared.Domain;
using System.Net.Http.Json;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Authorization;
using System;
using CarRentalManagement.Client.Interfaces;

namespace CarRentalManagement.Client.Pages.Bookings
{
    [Authorize]
    public partial class Create
    {
        [Inject] IHttpRepository<Booking> client { get; set; }
        [Inject] NavigationManager navigationManager { get; set; }

        Booking booking= new(){ DateOut = DateTime.Now.Date };
        

        private async Task CreateBooking ( )
        {
            await client.Create (Endpoints.BookingsEndpoint , booking);
            navigationManager.NavigateTo ("/bookings/");
        }
    }
}
