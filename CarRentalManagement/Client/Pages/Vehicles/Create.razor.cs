﻿using CarRentalManagement.Client.Static;
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
    public partial class Create
    {
        [Inject] HttpClient _client { get; set; }
        [Inject] NavigationManager _navManager { get; set; }

        Vehicle vehicle = new Vehicle();

        private async Task CreateVehicle()
        {
            await _client.PostAsJsonAsync(Endpoints.VehiclesEndpoint, vehicle);
            _navManager.NavigateTo("/vehicles/");
        }
    }
}