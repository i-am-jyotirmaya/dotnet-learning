using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeDemo
{
    public class Employee
    {
        public int EmpId { get; set; }
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        public double Salary { get; set; }

        public Employee()
        {
        }

        public Employee(int empId, string name, DateTime dateOfBirth, double salary)
        {
            EmpId = empId;
            Name = name;
            DateOfBirth = dateOfBirth;
            Salary = salary;
        }
    }
}
