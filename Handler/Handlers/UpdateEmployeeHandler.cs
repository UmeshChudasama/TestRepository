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
    public class UpdateEmployeeHandler : IRequestHandler<UpdateEmployeeCommand, long>
    {
        private readonly IEmployeeRepository _employee;
        public UpdateEmployeeHandler(IEmployeeRepository employee)
        {
            _employee = employee;
        }

        public async Task<long> Handle(UpdateEmployeeCommand command, CancellationToken cancellationToken)
        {
            var employee = await _employee.GetEmployeeById(command.EmployeeId);
            if (employee == null)
                return default;
            employee.Salary = command.Salary;
            employee.EmployeeName = command.EmployeeName;
            employee.Roid = command.ROId;
            employee.Role = command.Role;

            return await _employee.UpdateEmployee(employee);
        }
    }
}
