using System;
using System.Collections.Generic;
using System.Text;

namespace PuddleJumpers.Employees
{
    public class Employee
    {
        public string EmployeeName { get; set; }
        public string Title { get; set; }
        public DateTime StartDate { get; set; }

        public Employee(string employeeName, string title, DateTime startDate)
        {
            EmployeeName = employeeName;
            Title = title;
            StartDate = startDate;
        }

        public void AddName(string employeeName)
        {
            EmployeeName = employeeName;
        }

        public void AddTitle(string title)
        {
            Title = title;
        }

        public void AddStartDate(DateTime startDate)
        {
            StartDate = startDate;
        }
    }
}
