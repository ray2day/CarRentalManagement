using CarRentalManagement.Client.Contracts;
using CarRentalManagement.Client.Static;
using CarRentalManagement.Shared.Domain;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace CarRentalManagement.Client.Pages.Colours
{
    public partial class View
    {
        [Inject] IHttpRepository<Colour> _client { get; set; }
        [Inject] NavigationManager _navManager { get; set; }

        [Parameter] public int id { get; set; }
        Colour colour = new Colour();

        protected async override Task OnParametersSetAsync()
        {
            colour = await _client.Get(Endpoints.ColoursEndpoint, id);
        }
    }
}
