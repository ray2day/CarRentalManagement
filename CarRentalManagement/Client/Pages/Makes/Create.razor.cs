using CarRentalManagement.Client.Static;
using CarRentalManagement.Shared.Domain;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace CarRentalManagement.Client.Pages.Makes
{
    public partial class Create
    {
        [Inject] HttpClient _client { get; set; }
        [Inject] NavigationManager _navManager { get; set; }

        Make make = new Make();

        private async Task CreateMake()
        {
            await _client.PostAsJsonAsync(Endpoints.MakesEndpoint, make);
            _navManager.NavigateTo("/makes/");
        }
    }
}
