﻿using CarRentalManagement.Client.Contracts;
using CarRentalManagement.Client.Static;
using CarRentalManagement.Shared.Domain;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace CarRentalManagement.Client.Pages.Models
{
    public partial class Create
    {
        [Inject] IHttpRepository<Model> _client { get; set; }
        [Inject] NavigationManager _navManager { get; set; }

        Model model = new Model();

        private async Task CreateModel()
        {
            await _client.Create(Endpoints.ModelsEndpoint, model);
            _navManager.NavigateTo("/models/");
        }
    }
}
