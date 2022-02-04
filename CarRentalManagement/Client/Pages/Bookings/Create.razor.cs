using CarRentalManagement.Client.Static;
using CarRentalManagement.Shared.Domain;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace CarRentalManagement.Client.Pages.Bookings
{
    public partial class Create
    {
        [Inject] HttpClient _client { get; set; }
        [Inject] NavigationManager _navManager { get; set; }

        Booking booking = new Booking
        {
            DateOut = DateTime.Now.Date
        };


        private async Task CreateBooking()
        {
            await _client.PostAsJsonAsync(Endpoints.BookingsEndpoint, booking);
            _navManager.NavigateTo("/bookings/");
        }
    }
}
