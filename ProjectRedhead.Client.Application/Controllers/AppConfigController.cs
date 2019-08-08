using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using ProjectRedhead.Client.Application.Data;

namespace ProjectRedhead.Client.Application.Controllers
{
    [Route("config")]
    public class AppConfigController : Controller
    {
        private ClientConfig _config;

        public AppConfigController(IOptions<ClientConfig> config)
        {
            _config = config.Value;
        }

        [HttpGet]
        public IActionResult Get() => Ok(_config);
    }
}
