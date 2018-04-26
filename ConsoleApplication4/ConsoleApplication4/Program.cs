using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Student
    {
        private int _Id;
        private string _Name;
        public void SetId(int Id)
        {
            if (Id<=0)
            {
                throw new Exception("No negative values");
            }
            this._Id = Id;   
        }
        public int GetId()
        {
            return this._Id;      
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student C1 = new Student();
            C1.SetId(-101);
            Console.WriteLine(C1.GetId());
        }

       /* public static void Add(int i, int j)
        {
            Console.WriteLine(i + j);
        }
        public static void Add(double i, int j)
        {
            Console.WriteLine(i + j);
        }*/
    }
}
