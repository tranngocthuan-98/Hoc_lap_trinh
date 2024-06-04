using HRAdminAPI;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SchoolHRAdmin
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal totalSalaries = 0;
            List<IEmployee> employees = new List<IEmployee>();
            SeedData(employees);
            //foreach (IEmployee employee in employees)
            //{
            //    totalSalaries += employee.Salary;
            //}
            //Console.WriteLine($"Total Annual Salaries (including bonus): {totalSalaries}");

            Console.WriteLine($"Total Annual Salaries (including bonus): {employees.Sum(e => e.Salary)}");

            Console.ReadKey();
        }
        public static void SeedData(List<IEmployee> employees)
        {
            IEmployee teacher1 = new Teacher
            {
                Id = 1,
                FristName = "Bob",
                LastName = "Fisher",
                Salary = 40000,
            };
            employees.Add(teacher1);
            IEmployee teacher2 = new Teacher
            {
                Id = 2,
                FristName = "Jenny",
                LastName = "Thomas",
                Salary = 40000,
            };
            employees.Add(teacher2);
            IEmployee headOfDepartment = new HeadOfDepartment
            {
                Id = 3,
                FristName = "Brenda",
                LastName = "Mullins",
                Salary = 50000,
            };
            employees.Add(headOfDepartment);
            IEmployee deputyHeadMaster = new DeputyHeadMaster
            {
                Id = 4,
                FristName = "Devlin",
                LastName = "Brown",
                Salary = 60000,
            };
            employees.Add(deputyHeadMaster);
            IEmployee headMaster = new HeadMaster
            {
                Id = 5,
                FristName = "Damien",
                LastName = "Jones",
                Salary = 80000,
            };
            employees.Add(headMaster);
        }
    }
    public class Teacher : EmployeeBase
    {
        public override decimal Salary { get => base.Salary + (base.Salary * 0.02m); }
    }
    public class HeadOfDepartment : EmployeeBase
    {
        public override decimal Salary { get => base.Salary + (base.Salary * 0.03m); }
    }
    public class DeputyHeadMaster : EmployeeBase
    {
        public override decimal Salary { get => base.Salary + (base.Salary * 0.04m); }
    }
    public class HeadMaster : EmployeeBase
    {
        public override decimal Salary { get => base.Salary + (base.Salary * 0.05m); }
    }
}
