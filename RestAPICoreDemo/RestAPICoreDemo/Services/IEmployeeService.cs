using RestAPICoreDemo.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestAPICoreDemo.Services
{
    public interface IEmployeeService
    {
        Employee Add(Employee employee);

        List<Employee> Get();

        void Update(Employee employee);

        string Delete(int id);

        Employee GetId(int id);
    }
}
