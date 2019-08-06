using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ProjectRedhead.Client.Application.Controllers
{
    [Route("config")]
    public class AppConfigController : Controller
    {
        [HttpGet]
        public IActionResult WeatherForecasts()
        {
            return Ok();
        }
    }
}
