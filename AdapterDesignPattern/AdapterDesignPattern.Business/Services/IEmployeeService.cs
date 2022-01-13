using AdapterDesignPattern.DataContract.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdapterDesignPattern.Business.Services
{
    public interface IEmployeeService
    {
        List<Employee> GetEmployees();
    }
}
