using BuilderDesignPattern.Business.Services;
using BuilderDesignPattern.DataContract.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BuilderDesignPattern.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DemoController : ControllerBase
    {
        private readonly ILogger<DemoController> _logger;
        private readonly IPlanDirector _director;


        public DemoController(ILogger<DemoController> logger, IPlanDirector director)
        {
            _logger = logger;
            _director = director;
        }

        [HttpGet]
        public IActionResult Get()
        {
            PricingPlansModel model = new PricingPlansModel();

            // Build Basic Plan

            var basicPlanBuilder = new BasicPlanBuilder();
            _director.SetPlanBuilder(basicPlanBuilder);
            _director.BuildBasicPlan();
            model.BasicPlan = basicPlanBuilder.GetPlan();

            // Build Enterprise Plan 

            var enterprisePlanBuilder = new EnterprisePlanBuilder();
            _director.SetPlanBuilder(enterprisePlanBuilder);
            _director.BuildEnterprisePlan();
            model.EnterprisePlan = enterprisePlanBuilder.GetPlan();


            // Build Custom Plan 

            var customPlanBuilder = new BasicPlanBuilder();
            customPlanBuilder.BuildDiskSpaceFeature();
            customPlanBuilder.BuildBandwidthFeature();
            model.CustomPlan = customPlanBuilder.GetPlan();

            return Ok(model);
        }
    }
}
