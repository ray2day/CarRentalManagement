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
    public partial class Edit
    {
        [Inject] HttpClient _client { get; set; }
        [Inject] NavigationManager _navManager { get; set; }

        [Parameter] public int id { get; set; }
        Make make = new Make();

        protected async override Task OnParametersSetAsync()
        {
            make = await _client.GetFromJsonAsync<Make>($"{Endpoints.MakesEndpoint}/{id}");
        }

        async Task EditMake()
        {
            await _client.PutAsJsonAsync($"{Endpoints.MakesEndpoint}/{id}", make);
            _navManager.NavigateTo("/makes/");
        }
    }
}
