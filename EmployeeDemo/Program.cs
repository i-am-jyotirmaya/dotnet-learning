using System;

namespace EmployeeDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();
            emp.EmpId = Convert.ToInt32(Console.ReadLine());
            emp.Name = Console.ReadLine();
            emp.DateOfBirth = DateTime.ParseExact(Console.ReadLine(), "MM-dd-yyyy", null);
            emp.Salary = Convert.ToDouble(Console.ReadLine());
            //Employee emp1 = new Employee(1, "Chinu", new DateTime(1997, 7, 20), 50000);

            DisplayEmployeeDetails(emp);
            
        }

        static void DisplayEmployeeDetails(Employee e)
        {
            int age = (DateTime.Now - e.DateOfBirth).Days / 365;

            double tax = 0;

            if (age < 18) tax = e.Salary * 0.1;
            else if (age < 40) tax = e.Salary * 0.15;
            else if (age < 80) tax = e.Salary * 0.2;
            else tax = e.Salary * 0.12;

            double netSalary = e.Salary - tax;

            Console.WriteLine($"Employee Id: {e.EmpId}\nEmployee Name: {e.Name}\nDate of Birth: {e.DateOfBirth.ToShortDateString()}\nAge: {age}\nSalary: {e.Salary}\nTax: {tax}\nNet Salary: {netSalary}");
        }
    }
}
