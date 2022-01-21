using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using StrategyDesignPattern.Business.Services;
using StrategyDesignPattern.DataContract.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StrategyDesignPattern.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HomeController : ControllerBase
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IShippingContext _shippingContext;

        public HomeController(ILogger<HomeController> logger, IShippingContext shippingContext)
        {
            _logger = logger;
            _shippingContext = shippingContext;
        }

        [HttpGet]
        [Route("GetShippingMethods")]
        public IActionResult Get()
        {
            return Ok(GetShippingMethods());
        }

        [HttpPost]
        [Route("SubmitOrderDetails")]
        public IActionResult SubmitOrderDetails(SubmitCheckoutModel model)
        {

            switch (model.SelectedMethod)
            {
                case SelectedMethodEnum.FreeShipping:
                    _shippingContext.SetStrategy(new FreeShippingStrategy());
                    break;
                case SelectedMethodEnum.LocalShipping:
                    _shippingContext.SetStrategy(new LocalShippingStrategy());
                    break;
                case SelectedMethodEnum.WorldwideShipping:
                    _shippingContext.SetStrategy(new WorldwideShippingStrategy());
                    break;
            }

            return Ok(new CheckoutModel
            {
                FinalTotal = _shippingContext.ExecuteStrategy(model.OrderTotal),
                OrderTotal = model.OrderTotal,
                SelectedMethod = (int)model.SelectedMethod
            });
        }

        private List<ShippingMethod> GetShippingMethods()
        {
            return new List<ShippingMethod>()
            {
                new ShippingMethod()
                {
                    Id = 1,
                    Name="Free Shipping ($0.00)"
                },
                new ShippingMethod() {
                    Id = 2,
                    Name="Local Shipping ($10.00)"
                },
                new ShippingMethod() {
                    Id = 3,
                    Name="Worldwide Shipping ($50.00)"
                }
            };
        }
    }
}
