using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarRentalManagement.Shared.Domain;
using Microsoft.AspNetCore.Mvc;

namespace CarRentalManagement.Server.Controllers
{
    public class DevelopmentController: BaseApiController
    {

        [HttpGet("GetTypesNames")]
        public IEnumerable<string> GetTypesNames ( )
        {
            yield return $"{typeof(Vehicle)} :: {nameof(Vehicle)}";
            foreach(var p in typeof (Vehicle).GetProperties ())
            {
                yield return $"{p.PropertyType} :: {p.Name}";
            }
        }
    }
}
