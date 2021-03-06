using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Security.Principal;
using System.Threading.Tasks;
using CarRentalManagement.Client.Interfaces;
using CarRentalManagement.Client.Static;
using CarRentalManagement.Shared.Domain;
using Microsoft.AspNetCore.Components;

namespace CarRentalManagement.Client.Pages.Bookings
{
    public partial class FormComponent
    {
        [Inject] IHttpRepository<Vehicle> vehiclesRepository { get; set; }
        [Inject] IHttpRepository<Customer> customersRepository { get; set; }

        [Parameter] public Booking Booking { get; set; }
        [Parameter] public string ButtonText { get; set; }
        [Parameter] public EventCallback OnValidSubmit { get; set; }
        [Parameter] public bool Disabled { get; set; } = false;

        // TODO : dynamic styling by class attribute
        //[Parameter] public string @class { get; set; } = ;

        private IEnumerable<Vehicle> Vehicles;
        private IEnumerable<Customer> Customers;

        protected override async Task OnInitializedAsync ( )
        {
            Vehicles = await vehiclesRepository.GetAll (Endpoints.VehiclesEndpoint);
            Customers = await customersRepository.GetAll (Endpoints.CustomersEndpoint);
        }
    }
}
