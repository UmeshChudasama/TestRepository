using Business.Interface;
using Handler.Commands;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Handler.Handlers
{
    public class EmployeeDeleteHandler : IRequestHandler<DeleteEmployeeCommand, long>
    {
        private readonly IEmployeeRepository _employee;
        public EmployeeDeleteHandler( IEmployeeRepository employee)
        {
            _employee = employee;
        }

        public async Task<long> Handle(DeleteEmployeeCommand command, CancellationToken cancellationToken)
        {
            return await _employee.DeleteEmployee(command.EmployeeId);
        }
    }
}
