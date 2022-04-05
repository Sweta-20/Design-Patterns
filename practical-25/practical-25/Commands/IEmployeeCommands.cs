using practical_25.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practical_25.Commands
{
   public interface IEmployeeCommands
    {
        void SaveEmployeeData(Employee employee);
    }
}
