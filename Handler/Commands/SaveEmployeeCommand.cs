using DataAccess.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Handler.Commands
{
    public class SaveEmployeeCommand : IRequest<Employee>
    {
        public string EmployeeName { get; set; }
        public string Role { get; set; }
        public int Salary { get; set; }
        public long? ROId { get; set; }

        public SaveEmployeeCommand(string employeename, string role, int salary, long? roId)
        {
            EmployeeName = employeename;
            Role = role;
            Salary = salary;
            ROId = roId;
        }
    }
}
