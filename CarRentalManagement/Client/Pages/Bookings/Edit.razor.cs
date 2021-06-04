using System.Drawing;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using CarRentalManagement.Client.Static;
using CarRentalManagement.Shared.Domain;
using Microsoft.AspNetCore.Components;

namespace CarRentalManagement.Client.Pages.Bookings
{
    public partial class Edit
    {
        [Inject] HttpClient client { get; set; }
        [Inject] NavigationManager navigationManager { get; set; }

        [Parameter] public int id { get; set; }
        public Booking booking { get; set; } = new ();

        protected override async Task OnParametersSetAsync ( )
        {
            booking = await client.GetFromJsonAsync<Booking> ($"{Endpoints.BookingsEndpoint}/{id}");
        }

        private async Task EditBooking ( )
        {
            await client.PutAsJsonAsync ($"{Endpoints.BookingsEndpoint}/{id}" , booking);
            navigationManager.NavigateTo ("/bookings/");
        }

    }
}
