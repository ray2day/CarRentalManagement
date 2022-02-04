using CarRentalManagement.Client.Static;
using CarRentalManagement.Shared.Domain;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace CarRentalManagement.Client.Pages.Vehicles
{
    public partial class Edit
    {
        [Inject] HttpClient _client { get; set; }
        [Inject] NavigationManager _navManager { get; set; }

        [Parameter] public int id { get; set; }
        Vehicle vehicle = new Vehicle();

        protected async override Task OnParametersSetAsync()
        {
            vehicle = await _client.GetFromJsonAsync<Vehicle>($"{Endpoints.VehiclesEndpoint}/{id}");
        }

        async Task EditVehicle()
        {
            await _client.PutAsJsonAsync($"{Endpoints.VehiclesEndpoint}/{id}", vehicle);
            _navManager.NavigateTo("/vehicles/");
        }
    }
}
