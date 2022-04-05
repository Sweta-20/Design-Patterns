using practical_25.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practical_25.Repository
{
   public interface IEmployeeQueriesRepository
    {
        Employee GetByID(int employeeID);
    }
}
