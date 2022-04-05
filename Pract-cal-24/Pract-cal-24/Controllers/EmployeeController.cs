using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using Pract_cal_24.Models;
using Pract_cal_24.Queries;

namespace Pract_cal_24.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IMediator _mediatR;
        public EmployeeController(IMediator mediator)
        {
            _mediatR = mediator;
        }
        public Task<Employee> GetEmployeeByID(int EmpID)
        {
            return _mediatR.Send(new GetEmployeeInfoQuery() {ID=EmpID});
        }

    }
}
