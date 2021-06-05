using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarRentalManagement.Shared.Domain;
using Microsoft.AspNetCore.Components;

namespace CarRentalManagement.Client.Pages.Colours
{
    public partial class FormComponent
    {
        [Parameter] public Colour Colour{ get; set; }
        [Parameter] public string ButtonText { get; set; }
        [Parameter] public EventCallback OnValidSubmit { get; set; }
        [Parameter] public bool Disabled { get; set; } = false;

        // TODO : dynamic styling by class attribute
        //[Parameter] public string @class { get; set; } = ;
    }
}
