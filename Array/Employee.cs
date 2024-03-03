using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double salary { get; set; }


    }

    public class Emp
    {
        static void Main(string[] args)
        {
            Employee[] list = new Employee[4]
            {
            new Employee{Id = 24, Name = "Rishi",salary=45000.00 },
            new Employee{Id = 25, Name = "Vishal",salary=55000.00 },
            new Employee{Id = 26, Name = "Rajesh",salary=65000.00 },
            new Employee{Id = 27, Name = "Shubham",salary=75000.00 }
            };
            foreach(Employee E in list)
            {
                Console.WriteLine($"Id = {E.Id} Name = {E.Name} Salary = {E.salary}");
            }

        }
        
    }
}
