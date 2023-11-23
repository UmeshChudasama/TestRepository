using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Handler.Commands
{
    public class UpdateEmployeeCommand : IRequest<long>
    {
        public long EmployeeId { get; set; }
        public string EmployeeName { get; set; } = "";
        public string Role { get; set; } = "";
        public int Salary { get; set; }
        public long? ROId { get; set; }

        public UpdateEmployeeCommand(long employeeId, string employeName, string role, int salary, long? roId)
        {
            EmployeeId = employeeId;
            EmployeeName = employeName;
            Role = role;
            Salary = salary;
            ROId = roId;
        }
    }
}
