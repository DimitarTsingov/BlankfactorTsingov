using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using Newtonsoft.Json;
using RestSharp;

namespace EmployeeDataManagementSystem
{
    public class Country
    {
        public Name Name { get; set; }
    }

    public class Name
    {
        public string Common { get; set; }
        public string Official { get; set; }
    }
}
