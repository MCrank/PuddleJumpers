using PuddleJumpers.Employees;
using System;
using System.Collections.Generic;

namespace PuddleJumpers
{
    public class Company
    {
        /*
            Some readonly properties
        */
        public string CompanyName { get; }
        public DateTime CreatedOn { get; }

        // Create a property for holding a list of current employees
        public List<Employee> Employees { get; set; }

        /*
            Create a constructor method that accepts two arguments:
                1. The name of the company
                2. The date it was created

            The constructor will set the value of the public properties
        */
        public Company(string companyName, DateTime createdOn) // *** Should we be setting this to an empty List in the CTOR
        {
            CompanyName = companyName;
            CreatedOn = createdOn;
            Employees = new List<Employee>();
        }

        // Create a method that allows external code to add an employee
        public void AddEmployee(Employee newEmployee)
        {
            Employees.Add(newEmployee);
        }

        // Create a method that allows external code to remove an employee
        public void RemoveEmployee(Employee exEmployee)
        {
            Employees.Remove(exEmployee);
        }

        public void ListEmployee(List<Employee> employees)
        {
            foreach (Employee employee in employees)
            {
                Console.WriteLine($"Employee Name: {employee.EmployeeName}");
            }
        }

        static void Main(string[] args)
        {
            Company myCompany = new Company("XYZ", DateTime.Now);
            Employee marco = new Employee("Marco", "HellYeah", DateTime.Now);
            Employee nadia = new Employee("Nadia", "Queen", DateTime.Now);
            Employee jenna = new Employee("Jenna", "Princess", DateTime.Now);
            Console.WriteLine($"Name: {marco.EmployeeName}, Title: {marco.Title}, Start Date: {marco.StartDate}");

            // Add the employees to the Comany
            myCompany.AddEmployee(marco);
            myCompany.AddEmployee(nadia);
            myCompany.AddEmployee(jenna);

            // List the employees in the company
            myCompany.ListEmployee(myCompany.Employees);



            Console.ReadLine();

        }

    }
}

