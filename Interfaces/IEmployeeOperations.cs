using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestMitraTech.Models;

namespace TestMitraTech.Interfaces
{
    public interface IEmployeeOperations
    {
        void AddEmployee(Employee employee);
        void DisplayEmployees();
        void DeleteEmployee(string employeeID);
    }
}
