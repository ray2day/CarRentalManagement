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
    public partial class FormComponent
    {
        [Inject] HttpClient _client { get; set; }

        [Parameter] public bool Disabled { get; set; } = false;
        [Parameter] public Booking booking { get; set; }
        [Parameter] public string ButtonText { get; set; } = "Save";
        [Parameter] public EventCallback OnValidSubmit { get; set; }

        private IList<Vehicle> Vehicles;
        private IList<Customer> Customers;

        protected async override Task OnInitializedAsync()
        {
            Customers = await _client.GetFromJsonAsync<List<Customer>>(Endpoints.CustomersEndpoint);
            Vehicles = await _client.GetFromJsonAsync<List<Vehicle>>(Endpoints.VehiclesEndpoint);
        }
    }
}
