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
    public partial class FormComponent
    {
        [Inject] HttpClient _client { get; set; }

        private IList<Make> Makes;
        private IList<Model> Models;
        private IList<Colour> Colours;

        protected async override Task OnInitializedAsync()
        {
            Models = await _client.GetFromJsonAsync<List<Model>>(Endpoints.ModelsEndpoint);
            Colours = await _client.GetFromJsonAsync<List<Colour>>(Endpoints.ColoursEndpoint);
            Makes = await _client.GetFromJsonAsync<List<Make>>(Endpoints.MakesEndpoint);
        }

        [Parameter] public bool Disabled { get; set; } = false;
        [Parameter] public Vehicle vehicle { get; set; }
        [Parameter] public string ButtonText { get; set; } = "Save";
        [Parameter] public EventCallback OnValidSubmit { get; set; }
    }
}
