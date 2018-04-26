using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingProject
{
    class Program
    {
        static void Main(string[] args)
        {
            myEnum test1 = myEnum.varianta1;
            myEnum test2 = myEnum.varianta2;
            myEnum test3 = myEnum.varianta4;


            bool secondCondition = false;



            if (firstCondition & secondCondition)
            {
                Console.WriteLine("True");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("False");
                Console.ReadLine();
            }

        }
    }

    [Flags]
    enum myEnum
    {
        varianta1 = 1 << 0,
        varianta2 = 1 << 1,
        varianta4 = 1 << 2
    }
}
