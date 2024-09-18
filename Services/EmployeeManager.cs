using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestMitraTech.Interfaces;
using TestMitraTech.Models;

namespace TestMitraTech.Services
{
    // EmployeeManager handles in-memory employee CRUD operations.
    public class EmployeeManager : IEmployeeOperations
    {
        // Dictionary to store employees in memory.
        private Dictionary<string, Employee> employees = new Dictionary<string, Employee>();

        // Adds an employee after validating.
        public void AddEmployee(Employee employee)
        {
            try
            {
                // Validate the employee data.
                if (employee == null)
                    throw new ArgumentNullException("Employee object cannot be null.");

                if (string.IsNullOrEmpty(employee.EmployeeID))
                    throw new ArgumentException("EmployeeID cannot be null or empty.");

                if (string.IsNullOrEmpty(employee.FullName))
                    throw new ArgumentException("FullName cannot be null or empty.");

                if (employee.BirthDate == default)
                    throw new ArgumentException("Invalid BirthDate.");

                // Check for duplicate EmployeeID.
                if (employees.ContainsKey(employee.EmployeeID))
                    throw new InvalidOperationException("Employee with the same EmployeeID already exists.");

                // Add the employee to the dictionary.
                employees.Add(employee.EmployeeID, employee);
                Console.WriteLine($"Employee with ID {employee.EmployeeID} added successfully.");
            }
            catch (Exception ex)
            {
                // Handle any exception by printing the error message.
                Console.WriteLine($"Error: {ex.Message}");
            }
        }

        // Displays all employees in a neatly formatted table.
        public void DisplayEmployees()
        {
            if (employees.Count == 0)
            {
                Console.WriteLine("No employees to display.");
                return;
            }

            // Print the header.
            Console.WriteLine("\n---------------------------------------------");
            Console.WriteLine("| EmployeeID | FullName          | BirthDate   |");
            Console.WriteLine("---------------------------------------------");

            // Print each employee's data in a formatted manner.
            foreach (var employee in employees)
            {
                Console.WriteLine(
                    String.Format("| {0,-10} | {1,-16} | {2,-11} |",
                    employee.Value.EmployeeID,
                    employee.Value.FullName,
                    employee.Value.BirthDate.ToString("dd-MMM-yyyy"))
                );
            }

            Console.WriteLine("---------------------------------------------");
        }

        // Deletes an employee by EmployeeID.
        public void DeleteEmployee(string employeeID)
        {
            try
            {
                if (string.IsNullOrEmpty(employeeID))
                    throw new ArgumentException("EmployeeID cannot be null or empty.");

                if (!employees.ContainsKey(employeeID))
                    throw new KeyNotFoundException("Employee with the given EmployeeID does not exist.");

                // Remove the employee.
                employees.Remove(employeeID);
                Console.WriteLine($"Employee with ID {employeeID} deleted successfully.");
            }
            catch (Exception ex)
            {
                // Handle any exception by printing the error message.
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}
