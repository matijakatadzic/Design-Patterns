﻿using AdapterDesignPattern.DataContract.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdapterDesignPattern.Business.Services
{
    public class EmployeeService : IEmployeeService
    {
        public List<Employee> GetEmployees()
        {
            return new List<Employee>()
            {
                new Employee(1, "James", 20000),
                new Employee(2, "Peter", 30000),
                new Employee(3, "David", 40000),
                new Employee(4, "George", 50000)
            };
        }
    }
}
