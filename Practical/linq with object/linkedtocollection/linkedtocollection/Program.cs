using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace linkedtocollection
{
    class Program
    {
        static void Main(string[] args)
        {
            //create object objEmp of class Employee and create a list of the Employee information  
            List<Employee> objEmp = new List<Employee>
     ()
    {
    new Employee { EmpId=1,Name = "Akshay", Location="Chennai" },
    new Employee { EmpId=2,Name = "Vaishali", Location="Chennai" },
    new Employee { EmpId=3,Name = "Priyanka", Location="Guntur" },
    new Employee { EmpId=4,Name = "Preeti", Location ="Vizag"},
    };
            //here use the LINQ query to sort or select the element from the collection of data  
            var result = from e in objEmp
                         where e.Location.Equals("Chennai")
                         select new
                         {
                             Name = e.Name,
                             Location = e.Location
                         };
            //foreach loop is used to print the value of the 'result' having the output of the LINQ query  
            foreach (var item in result)
            {
                Console.WriteLine(item.Name + "\t | " + item.Location);
            }
            Console.ReadLine();
        }

    }
    //create class employee  
    class Employee
    {
        public int EmpId { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
    }
}
        