using RestAPICoreDemo.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestAPICoreDemo.Services
{
    public interface IEmployeeService
    {
        Employee AddEmployee(Employee employee);

        List<Employee> GetEmployees();

        void UpdateEmployee(Employee employee);

        string DeleEmploye(int id);

        Employee GetEmployeeId(int id);
    }
}
