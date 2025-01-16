using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using Newtonsoft.Json;
using RestSharp;
using System.Text.Json;

namespace EmployeeDataManagementSystem
{
    public class EmployeeManagementSystem
    {
        private List<Country> validCountries = new List<Country>();
        private List<Employee> employees = new List<Employee>();
        private const string DataFile = "employees.json";

        public void Run()
        {
            LoadCountries();
            //LoadData();
            DisplayMenu();
        }

        private void LoadCountries()
        {

            var client = new RestClient("https://restcountries.com/v3.1/all?fields=name");
            var request = new RestRequest();
            request.Method = Method.Get;

            var response = client.Execute<List<Country>>(request);

            if (response.IsSuccessful && response.Data != null)
            {
                validCountries = response.Data.ToList();
            }
            else
            {
                Console.WriteLine("Failed to fetch countries from API.");
            }
        }

        private void DisplayMenu()
        {
            while (true)
            {
                Console.WriteLine("\nEmployee Data Management System");
                Console.WriteLine("1. Add Employee");
                Console.WriteLine("2. Remove Employee");
                Console.WriteLine("3. Assign Department");
                Console.WriteLine("4. Update Salary");
                Console.WriteLine("5. Save Data");
                Console.WriteLine("6. Display All Employees");
                Console.WriteLine("7. Exit");
                Console.Write("Enter your choice: ");

                switch (Console.ReadLine())
                {
                    case "1": AddEmployee(); break;
                    case "2": RemoveEmployee(); break;
                    case "3": AssignDepartment(); break;
                    case "4": UpdateSalary(); break;
                    case "5": SaveData(); break;
                    case "6": DisplayEmployees(); break;
                    case "7": return;
                    default: Console.WriteLine("Invalid choice. Try again."); break;
                }
            }
        }

        private void AddEmployee()
        {
            Console.Write("Enter Full Name: ");
            string fullName = Console.ReadLine();
            if (employees.Any(e => e.FullName.Equals(fullName, StringComparison.OrdinalIgnoreCase)))
            {
                Console.WriteLine("Employee already exists.");
                return;
            }

            Console.Write("Enter Salary: ");
            if (!decimal.TryParse(Console.ReadLine(), out decimal salary) || salary <= 0)
            {
                Console.WriteLine("Invalid salary.");
                return;
            }

            Console.WriteLine("Select Country:");
            for (int i = 0; i < validCountries.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {validCountries[i].Name.Common}");
            }
            Console.Write("Enter your choice: ");
            if (!int.TryParse(Console.ReadLine(), out int countryIndex) || countryIndex < 1 || countryIndex > validCountries.Count)
            {
                Console.WriteLine("Invalid choice.");
                return;
            }

            Country selectedCountry = validCountries[countryIndex - 1];

            employees.Add(new Employee
            {
                FullName = fullName,
                Salary = salary,
                Country = selectedCountry
            });

            Console.WriteLine("Employee added successfully.");
        }

        private void RemoveEmployee()
        {
            Console.Write("Enter Full Name of the Employee to Remove: ");
            string fullName = Console.ReadLine();

            Employee employee = employees.FirstOrDefault(e => e.FullName.Equals(fullName, StringComparison.OrdinalIgnoreCase));
            if (employee == null)
            {
                Console.WriteLine("Employee not found.");
                return;
            }

            employees.Remove(employee);
            Console.WriteLine("Employee removed successfully.");
        }

        private void AssignDepartment()
        {
            Console.Write("Enter Full Name of the Employee: ");
            string fullName = Console.ReadLine();

            Employee employee = employees.FirstOrDefault(e => e.FullName.Equals(fullName, StringComparison.OrdinalIgnoreCase));
            if (employee == null)
            {
                Console.WriteLine("Employee not found.");
                return;
            }

            Console.Write("Enter Department Name: ");
            string department = Console.ReadLine();

            if (employee.AssignedDepartments.Contains(department, StringComparer.OrdinalIgnoreCase))
            {
                Console.WriteLine("Department already assigned to this employee.");
                return;
            }

            employee.AssignedDepartments.Add(department);
            Console.WriteLine("Department assigned successfully.");
        }

        private void UpdateSalary()
        {
            Console.Write("Enter Full Name of the Employee: ");
            string fullName = Console.ReadLine();

            Employee employee = employees.FirstOrDefault(e => e.FullName.Equals(fullName, StringComparison.OrdinalIgnoreCase));
            if (employee == null)
            {
                Console.WriteLine("Employee not found.");
                return;
            }

            Console.Write("Enter New Salary: ");
            if (!decimal.TryParse(Console.ReadLine(), out decimal salary) || salary <= 0)
            {
                Console.WriteLine("Invalid salary.");
                return;
            }

            employee.Salary = salary;
            Console.WriteLine("Salary updated successfully.");
        }

        private void SaveData()
        {
            File.WriteAllText(DataFile, JsonConvert.SerializeObject(employees, Formatting.Indented));
            Console.WriteLine("Data saved successfully.");
        }

        private void LoadData()
        {
            if (File.Exists(DataFile))
            {
                employees = JsonConvert.DeserializeObject<List<Employee>>(File.ReadAllText(DataFile)) ?? new List<Employee>();
            }
        }

        private void DisplayEmployees()
        {
            if (!employees.Any())
            {
                Console.WriteLine("No employees found.");
                return;
            }

            foreach (var employee in employees)
            {
                Console.WriteLine($"\nFull Name: {employee.FullName}");
                Console.WriteLine($"Country: {employee.Country.Name.Common}");
                Console.WriteLine($"Salary: {employee.Salary}");
                Console.WriteLine("Departments: " + (employee.AssignedDepartments.Any() ? string.Join(", ", employee.AssignedDepartments) : "None"));
            }
        }
    }
}
