using Microsoft.AspNetCore.Mvc;
using RestAPICoreDemo.Model;
using RestAPICoreDemo.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestAPICoreDemo.Controllers
{
    [Route("v1/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private readonly IEmployeeService _employeeService;

        public EmployeesController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }

        [HttpGet]
        public IEnumerable<Employee> GetEmployees()
        {
            return _employeeService.GetEmployees();
        }

        [HttpGet]
        [Route("{id}")]
        public Employee GetEmployeeId(int id)
        {
            return _employeeService.GetEmployeeId(id);
        }

        [HttpPost]
        [Route("Add")]
        public IActionResult AddEmployee(Employee employee)
        {
            _employeeService.AddEmployee(employee);
            return Created("Employee criado com sucesso.", employee); 
        }

        [HttpPatch]
        [Route("Update/{id}")] 
        public IActionResult UpdateEmployee(Employee employee)
        {
            _employeeService.UpdateEmployee(employee);
            return Ok($"Funcionário {employee.FirstName} alterado com sucesso."); //Tem como verfificar o que foi alterado para colocar como parametro na string? somente percorrendo todo o objeto
        }

        [HttpDelete]
        [Route("Delete/{id}")]
        public IActionResult DeleteEmployee(int id)
        {
            var employeeExists = _employeeService.GetEmployeeId(id);
            
            if(employeeExists == null)
            {

                return NotFound($"Employee Not Found with ID: {id}.");
            }
            _employeeService.DeleEmploye(id);
            return Ok();
        }
    }
}

