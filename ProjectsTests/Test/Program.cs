using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            A test = new A();
            A test2 = new A();


            test.ShowNumber();
           


            Console.ReadLine();
            
        }
    }

    public class A
    {
        private string employee = 10;

        public void ShowNumber()
        {
            Console.WriteLine(number);
        }
    }
}
