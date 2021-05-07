using RestAPICoreDemo.Context;
using RestAPICoreDemo.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestAPICoreDemo.Services
{
    public class EmployeeService : IEmployeeService
    {
        public EmployeeContext _employeeDbContext;

        public EmployeeService(EmployeeContext employeeDbContext)
        {
            _employeeDbContext = employeeDbContext;
        }
        public Employee AddEmployee(Employee employee)
        {
            _employeeDbContext.Employees.Add(employee);
            _employeeDbContext.SaveChanges();
            return employee;
        }

        public string DeleEmploye(int id)
        {
            var employee = _employeeDbContext.Employees.FirstOrDefault(x => x.Id == id);
            
            if(employee == null) 
            {
                return "Employee não encontrado.";
            }
            _employeeDbContext.Remove(employee);
            _employeeDbContext.SaveChanges();
            return "Employee Deletado com sucesso.";
        }

        public Employee GetEmployeeId(int id)
        {
            return _employeeDbContext.Employees.Find(id);
        }

        public List<Employee> GetEmployees()
        {
            return _employeeDbContext.Employees.ToList();
        }

        public void UpdateEmployee(Employee employee)
        {
            _employeeDbContext.Employees.Update(employee);
            _employeeDbContext.SaveChanges();
        }
    }
}
