using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ObserverDesignPattern.Business.Services;
using ObserverDesignPattern.DataContract.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ObserverDesignPattern.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DemoController : ControllerBase
    {
        private readonly ILogger<DemoController> _logger;
        private readonly IOrderService _orderService;

        public DemoController(ILogger<DemoController> logger, IOrderService orderService)
        {
            _logger = logger;
            _orderService = orderService;
        }

        [HttpPost]
        public IEnumerable<string> Get(Order order)
        {
            var list = new List<string>();

            list.Add("Attaching Observers...");

            var smsObserver = new SmsObserver();
            var emailObserver = new EmailObserver();

            _orderService.Attach(smsObserver);
            _orderService.Attach(emailObserver);


            list.Add("Updating Order Status...");

            list.AddRange(_orderService.UpdateOrder(order));


            list.Add("Detaching SMS Observer...");

            _orderService.Detach(smsObserver);


            list.Add("Updating Order Status...");

            list.AddRange(_orderService.UpdateOrder(order));

            return list;
        }
    }
}
