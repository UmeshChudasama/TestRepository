using Business.Interface;
using DataAccess.Models;
using Handler.Queries;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Handler.Handlers
{
    public class GetAllEmployeeHandler : IRequestHandler<GetEmployeeListQuery, List<Employee>>
    {
        private readonly IEmployeeRepository _employee;

        public GetAllEmployeeHandler(IEmployeeRepository employee)
        {
            _employee = employee;
        }

        public async Task<List<Employee>> Handle(GetEmployeeListQuery query, CancellationToken cancellationToken)
        {
           return await _employee.GetAllEmployee();
        }
    }
}
