using Business.Interface;
using DataAccess.Models;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Repository
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly NewTaskContext _context;
        public EmployeeRepository(NewTaskContext context)
        {
            _context = context;
        }
        public async Task<List<Employee>> GetAllEmployee()
        {
            try
            {
                //return  _context.Employees.FromSqlInterpolated($"usp__GetAllEmployee").ToList();
                return await _context.Employees.ToListAsync();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                throw;
            }
        }

        public async Task<Employee> GetEmployeeById(long employeeId)
        {
            try
            {
                //var EmployeeId = new SqlParameter("@EmployeeId",employeeId);
                //return _context.Employees.FromSqlInterpolated($"usp__GetEmployeeById @EmployeeId", EmployeeId).FirstOrDefault();
                var Employee = await _context.Employees.FirstOrDefaultAsync(x => x.EmployeeId == employeeId);
                return Employee;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
        }

        public async Task<long> DeleteEmployee(long employeeId)
        {
            try
            {
                var deletedata = await _context.Employees.Where(x => x.EmployeeId == employeeId).FirstOrDefaultAsync();
                 _context.Employees.Remove(deletedata);
                return await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                throw;
            }
        }

        public async Task<Employee> SaveEmployee(Employee employee)
        {
            try
            {
                var result = _context.Employees.Add(employee);
                await _context.SaveChangesAsync();
                return result.Entity;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                throw;
            }
        }

        public async Task<long> UpdateEmployee(Employee employee)
        {
            try
            {
                _context.Employees.Update(employee);
                return await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                throw;
            }
        }
    }
}
