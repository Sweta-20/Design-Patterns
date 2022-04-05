using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Pract_cal_24.Models;
using Pract_cal_24.Queries;
using Pract_cal_24.Repository;

namespace Pract_cal_24.Handlers
{
    public class GetEmployeeInfoHandler : IRequestHandler<GetEmployeeInfoQuery, Employee>
    {
        private readonly IEmployeeRepository _employeeRepository;
        public GetEmployeeInfoHandler(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }
        public Task<Employee> Handle(GetEmployeeInfoQuery request, CancellationToken cancellationToken)
        {
            return Task.FromResult( _employeeRepository.GetEmployeeById(request.ID));
        }
    }
}
