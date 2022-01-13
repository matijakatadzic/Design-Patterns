using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdapterDesignPattern.Business.Services
{
    public interface IAnalyticsService
    {
        void GenerateReport(string json);
    }
}
