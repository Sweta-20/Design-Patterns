using Pract_cal_24.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pract_cal_24.Repository
{
   public interface IEmployeeRepository
    {
        Employee GetEmployeeById(int EmpID);
    }
}
