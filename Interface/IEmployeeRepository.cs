using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Interface
{
    public interface IEmployeeRepository
    {
        public Task<List<Employee>> GetAllEmployee();
        public Task<Employee> GetEmployeeById(long employeeId);
        public Task<long> DeleteEmployee(long employeeId);
        public Task<Employee> SaveEmployee(Employee employee);
        public Task<long> UpdateEmployee(Employee employee);
    }
}
