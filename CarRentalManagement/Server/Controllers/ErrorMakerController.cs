using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace CarRentalManagement.Server.Controllers
{
    public class ErrorMakerController : BaseApiController
    {

        [HttpGet("bad-request")]
        public IActionResult GetBadRequest ( )
        {
            return BadRequest("Bad Request");
        }

        [HttpGet ("not-found")]
        public IActionResult GetNotFound ( )
        {
            return NotFound ("Not Found");
        }

        [HttpGet ("UnAuthorized")]
        public IActionResult GetUnAuthorized ( )
        {
            return Unauthorized("UnAuthorized");
        }

        [HttpGet ("internal-server-error")]
        public IActionResult GetInternalServerError ( )
        {
            throw new Exception ("internal-server-error");
        }
    }
}
