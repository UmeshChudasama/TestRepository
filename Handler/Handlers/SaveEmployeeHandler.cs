using Business.Interface;
using DataAccess.Models;
using Handler.Commands;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Handler.Handlers
{
    public class SaveEmployeeHandler : IRequestHandler<SaveEmployeeCommand, Employee>
    {
        private readonly IEmployeeRepository _employee;

        public SaveEmployeeHandler(IEmployeeRepository employee)
        {
            _employee = employee;
        }

        public async Task<Employee> Handle(SaveEmployeeCommand command, CancellationToken cancellationToken)
        {
            var employee = new Employee()
            {
                EmployeeName = command.EmployeeName,
                Role = command.Role,
                Salary = command.Salary,
                Roid =command.ROId                
            };
            return await _employee.SaveEmployee(employee);

        }
    }
}
