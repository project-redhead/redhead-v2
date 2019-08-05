using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProjectRedhead.Domain.UserAggregrate;

namespace ProjectRedhead.Application.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly IUserRepository _repository;

        public ValuesController(IUserRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public async Task<IActionResult> Test()
        {
            await _repository.AddAsync(new User("Gino"));
            return Ok();
        }
    }
}
