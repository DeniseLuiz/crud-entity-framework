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
        public IEnumerable<Employee> Get()
        {
            return _employeeService.Get();
        }

        [HttpGet]
        [Route("{id}")]
        public Employee GetId(int id)
        {
            return _employeeService.GetId(id);
        }

        [HttpPost]
        [Route("Add")]
        public IActionResult Add(Employee employee)
        {
            _employeeService.Add(employee);
            return Created("Employee criado com sucesso.", employee); 
        }

        [HttpPatch]
        [Route("Update/{id}")] 
        public IActionResult Update(Employee employee)
        {
            _employeeService.Update(employee);
            return Ok($"Funcionário {employee.FirstName} alterado com sucesso."); //Tem como verfificar o que foi alterado para colocar como parametro na string? somente percorrendo todo o objeto
        }

        [HttpDelete]
        [Route("Delete/{id}")]
        public IActionResult Delete(int id)
        {
            var employeeExists = _employeeService.GetId(id);
            
            if(employeeExists == null)
            {

                return NotFound($"Employee Not Found with ID: {id}.");
            }
            _employeeService.Delete(id);
            return Ok();
        }
    }
}

