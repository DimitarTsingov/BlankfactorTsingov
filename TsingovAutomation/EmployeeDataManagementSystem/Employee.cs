using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using Newtonsoft.Json;
using RestSharp;

namespace EmployeeDataManagementSystem
{
    public class Employee
    {
        public string FullName { get; set; }
        public Country Country { get; set; }
        public List<string> AssignedDepartments { get; set; } = new List<string>();
        public decimal Salary { get; set; }
    }
}
