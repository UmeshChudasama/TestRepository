using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class Employee
    {
        //public Employee()
        //{
        //    InverseRo = new HashSet<Employee>();
        //}

        public long EmployeeId { get; set; }
        public string EmployeeName { get; set; } = null!;
        public string Role { get; set; } = null!;
        public int Salary { get; set; }
        public long? Roid { get; set; }

        public virtual Employee? Ro { get; set; }
        //public virtual ICollection<Employee> InverseRo { get; set; }
    }
}
