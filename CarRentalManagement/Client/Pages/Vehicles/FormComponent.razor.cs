using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using CarRentalManagement.Client.Interfaces;
using CarRentalManagement.Client.Static;
using CarRentalManagement.Shared.Domain;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;

namespace CarRentalManagement.Client.Pages.Vehicles
{
    public partial class FormComponent
    {
        [Inject] IHttpRepository<Make> makesRepository { get; set; }
        [Inject] IHttpRepository<Model> modelsRepository { get; set; }
        [Inject] IHttpRepository<Colour> coloursRepository { get; set; }

        [Parameter] public Vehicle Vehicle { get; set; }
        [Parameter] public string ButtonText { get; set; }
        [Parameter] public EventCallback OnValidSubmit { get; set; }
        [Parameter] public bool Disabled { get; set; } = false;
        // TODO : dynamic styling by class attribute
        //[Parameter] public string @class { get; set; } = ;

        private IEnumerable<Make> Makes;
        private IEnumerable<Model> Models;
        private IEnumerable<Colour> Colours;
        private string UploadFileWarning;

        public async Task HandleFileSelection (InputFileChangeEventArgs e)
        {
            var file = e.File;
            if (file is not null)
            {
                var ext = Path.GetExtension (file.Name).ToLower ();
                if (ext is not "jpg" or "jpeg" or "png")
                {
                    var guid = Guid.NewGuid ().ToString ().Replace ("-" , "");
                    Vehicle.ImageName = $"{guid}{ext}";
                    Vehicle.Image = new byte [file.Size];
                    await file.OpenReadStream ().ReadAsync (Vehicle.Image);
                    UploadFileWarning = string.Empty;
                }
                else
                {
                    UploadFileWarning = "No valid image files found ( *.jpg | *.png | *.jpeg )";
                }
            }
        }

        protected override async Task OnInitializedAsync ( )
        {
            Makes = await makesRepository.GetAll (Endpoints.MakesEndpoint);
            Models = await modelsRepository.GetAll (Endpoints.ModelsEndpoint);
            Colours = await coloursRepository.GetAll (Endpoints.ColoursEndpoint);
        }


    }
}
