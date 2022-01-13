using AdapterDesignPattern.DataContract.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdapterDesignPattern.Business.Services
{
    public class AnalyticsAdapter : AnalyticsService, IAnalyticsAdapter
    {
        public void ProcessEmployees(List<Employee> employees)
        {
            var json = System.Text.Json.JsonSerializer.Serialize(employees);

            GenerateReport(json);
        }
    }
}
