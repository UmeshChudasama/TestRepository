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
    public class GetEmployeeByIdHandler : IRequestHandler<GetEmployeeByIdQuery, Employee>
    {
        private readonly IEmployeeRepository _employee;

        public GetEmployeeByIdHandler(IEmployeeRepository employee)
        {
            _employee = employee;
        }

        public async Task<Employee> Handle(GetEmployeeByIdQuery query,CancellationToken cancellationToken)
        {
            return await _employee.GetEmployeeById(query.EmployeeId);
        }
    }
}
