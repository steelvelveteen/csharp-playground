using System;
using System.Collections.Generic;

namespace csharp_playground
{
    class Program
    {

        static void Main(string[] args)
        {
            List<Employee> empList = new List<Employee>()
            {
                new Employee { Id = 101, Name = "Maria", Salary = 5000, Experience = 5 },
                new Employee { Id = 101, Name = "Sonoya", Salary = 4000, Experience = 4 },
                new Employee { Id = 101, Name = "Antonia", Salary = 3000, Experience = 3 },
                new Employee { Id = 101, Name = "Sarah", Salary = 3500, Experience = 2 },
            };

            // Version 1.0
            // You declare the delegate and make it point to the Promote method
            // IsPromotableDel isPromotableDel = new IsPromotableDel(Promote);
            // Employee.PromoteEmployee(empList, isPromotableDel);

            // Version 2.0
            // No need to create the delegate pointer, just pass the method as a delegate
            // parameter as below
            // Employee.PromoteEmployee(empList, Promote);

            // Version 3.0
            // No need to define the method that the delegate is pointing to.
            // Directly pass an anonymous method that matches the delegate's signature
            Employee.PromoteEmployee(empList, delegate (Employee employee)
           {
               return employee.Experience >= 5;
           });

            // Version 4.0 lambda expression
            // No need to define the method that the delegate is pointing to.
            // Directly pass a lambda expression that matches the delegate's signature
            Employee.PromoteEmployee(empList, emp => emp.Experience >= 3);

        }

        // Only needed for Versions 1.0 and 2.0
        // static bool Promote(Employee employee) => employee.Experience >= 3;

    }
    public delegate bool IsPromotableDel(Employee employee);

    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
        public int Experience { get; set; }

        public static void PromoteEmployee(List<Employee> employeeList, IsPromotableDel isEligible)
        {
            foreach (Employee emp in employeeList)
            {
                if (isEligible(emp))
                {
                    Console.WriteLine($"{emp.Name} has been promoted.");
                }
                else
                {
                    Console.WriteLine($"{emp.Name} will have to wait.");
                }
            }
        }
    }
}