using DecoratorDesignPattern.Business.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DecoratorDesignPattern.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HomeController : ControllerBase
    {
        private readonly IPlayersService _playersService;

        public HomeController(IPlayersService playersService)
        {
            _playersService = playersService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_playersService.GetPlayersList());
        }
    }
}
