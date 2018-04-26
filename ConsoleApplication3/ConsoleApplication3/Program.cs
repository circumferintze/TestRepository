using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
   public class Employee
    {
      
            public string FirstName;
            public string LastName;
            public string email;
        
    public void PrintFullName()
        {
            Console.WriteLine(FirstName + " " + LastName);
        }
    }
    public class FullTimeEmployee : Employee
    {
        
            public float Salary;
    }
    
   public class Program
    {
      public  static void Main(string[] args)
        {
            FullTimeEmployee FTP = new FullTimeEmployee();
            FTP.FirstName = "Lilia";
        FTP.LastName = "Chicu";
            FTP.Salary = 50000;
            FTP.PrintFullName();
            Console.WriteLine(FTP.Salary);
            Console.ReadLine();
        }
    }
}
