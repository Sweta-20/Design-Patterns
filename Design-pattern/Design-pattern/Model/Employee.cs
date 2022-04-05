using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Design_pattern.Model
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
        public int DepartmentID { get; set; }
        public string Email { get; set; }
        public DateTime JoiningDate{get;set; }
        public char Status { get; set; } = 'A';
    }
}
