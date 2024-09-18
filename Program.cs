using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestMitraTech.Models;
using TestMitraTech.Services;

namespace TestMitraTech
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Initialize EmployeeManager for CRUD operations.
            var employeeManager = new EmployeeManager();

            // Hardcoded employee data for demo.
            Employee emp1 = new Employee
            {
                EmployeeID = "1001",
                FullName = "Adit",
                BirthDate = new DateTime(1954, 8, 17)
            };

            Employee emp2 = new Employee
            {
                EmployeeID = "1002",
                FullName = "Anton",
                BirthDate = new DateTime(1980, 3, 18)
            };
            Employee emp3 = new Employee
            {
                EmployeeID = "1003",
                FullName = "Amir",
                BirthDate = new DateTime(1980, 3, 19)
            };

            // Add employees.
            employeeManager.AddEmployee(emp1);
            employeeManager.AddEmployee(emp2);
            employeeManager.AddEmployee(emp3);

            // Display employees.
            employeeManager.DisplayEmployees();

            // Delete employee with ID 1001.
            employeeManager.DeleteEmployee("1001");

            // Display employees after deletion.
            employeeManager.DisplayEmployees();

            // Prevent console from closing immediately.
            Console.ReadLine();
        }
    }
}
