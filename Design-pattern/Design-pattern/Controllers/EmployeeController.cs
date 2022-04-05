using Design_pattern.Model;
using Design_pattern.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Design_pattern.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        public EmployeeService _employeeServices;
        public EmployeeController(EmployeeService employeeServices)
        {
            _employeeServices = employeeServices;
        }
        [HttpGet("get-all-employees")]
        public IActionResult GetAllEmployees()
        {
            var allEmployee = _employeeServices.GetAllEmployee();
            return Ok(allEmployee);
        }
        [HttpGet("get-all-employee-by-id/{id}")]
        public IActionResult GetEmployeesById(int id)
        {
            var Employee = _employeeServices.GellAllEmployeeById(id);
            return Ok(Employee);
        }
        [HttpPost("add-employee")]
        public IActionResult AddBook([FromBody] Employee employee)
        {
            _employeeServices.AddEmployee(employee);
            return Ok();
        }
        [HttpPut("update-employee-by-id/{id}")]
        public IActionResult UpdateResultId(int id, [FromBody] Employee employee)
        {
            var updateemployee = _employeeServices.UpdateEmployeeById(id, employee);
            return Ok(updateemployee);
        }
        [HttpDelete]
        public IActionResult DeleteBookById(int id)
        {
            _employeeServices.DeleteEmployeeById(id);
            return Ok();
        }
    }
}
