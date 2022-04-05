using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using Pract_cal_24.Models;

namespace Pract_cal_24.Queries
{
    public class GetEmployeeInfoQuery: IRequest<Employee>
    {
        public int ID { get; set; }
    }
}
