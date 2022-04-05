using Pract_cal_24.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pract_cal_24.Repository
{
    public class EmployeeRepository : IEmployeeRepository
    {
        public readonly List<Employee> _employees = new List<Employee>();
        public EmployeeRepository()
        {
            _employees.Add(new Employee()
            {
                ID=1,
                EmpName="Sweta"
            });
               
        }
        public Employee GetEmployeeById(int EmpID)
        {
            return _employees.Find(x => x.ID == EmpID);
        }
    }
}
