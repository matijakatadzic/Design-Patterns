using AdapterDesignPattern.Business.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdapterDesignPattern.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HomeController : ControllerBase
    {
        private readonly IEmployeeService _employeesService;
        private readonly IAnalyticsAdapter _analyticsAdapter;
        // private readonly IAnalyticsService _analyticsService;

        public HomeController(IEmployeeService employeesService
            , IAnalyticsAdapter analyticsAdapter
            //, IAnalyticsService analyticsService
            )
        {
            _employeesService = employeesService;
            _analyticsAdapter = analyticsAdapter;

            //_analyticsService = analyticsService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_employeesService.GetEmployees());
        }

        [HttpGet]
        public IActionResult GenerateReport()
        {
            var employees = _employeesService.GetEmployees();

            //_analyticsService.GenerateReport(employees);

            _analyticsAdapter.ProcessEmployees(employees);
            return Ok(_employeesService.GetEmployees());
        }
    }
}
