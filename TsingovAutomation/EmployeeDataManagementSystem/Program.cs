using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using Newtonsoft.Json;
using RestSharp;
using EmployeeDataManagementSystem;

class Program
{
    static void Main(string[] args)
    {
        var system = new EmployeeManagementSystem();
        system.Run();
    }
}
