using Design_pattern.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Design_pattern.Service
{
    public class EmployeeService
    {
        private AppDbContext _context;
        public EmployeeService(AppDbContext context)
        {
            _context = context;
        }
        public void AddEmployee( Employee employee)
        {
            var _employee = new Employee()
            {
                Name = employee.Name,
                Salary = employee.Salary,
                DepartmentID = employee.DepartmentID,
                Email = employee.Email,
                JoiningDate=DateTime.Now,
                Status=employee.Status
            };
            _context.employees.Add(_employee);
            _context.SaveChanges();
        }
        public List<Employee> GetAllEmployee()
        {
            return _context.employees.ToList();
        }
        public Employee GellAllEmployeeById(int id)
        {
            return _context.employees.FirstOrDefault(n => n.Id == id);
        }
        public Employee UpdateEmployeeById(int id, Employee employee)
        {
            var _employee = _context.employees.FirstOrDefault(n => n.Id == id);
            if (_employee != null)
            {
                _employee.Name = employee.Name;
                _employee.Salary = employee.Salary;
                _employee.DepartmentID = employee.DepartmentID;
                _employee.Email = employee.Email;
                _employee.Status = employee.Status;
                _context.SaveChanges();

            }
            return _employee;
        }
        public void DeleteEmployeeById(int id)
        {
            var _employee = _context.employees.FirstOrDefault(n => n.Id == id);
            if (_employee != null)
            {
                _context.employees.Remove(_employee);
                _context.SaveChanges();
            }
        }
    }
}
