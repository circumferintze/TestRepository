using System;
using System.Collections.Generic;
using System.Text;

namespace StringMaxMin
{
    class ConsoleReader : IReader
    {
           /* public virtual void ReadLine(string value)
            {
                Console.ReadLine(value);
            }

            public virtual void Read(string value)
            {
                Console.Read(value);
            }*/

            public virtual void ReadLine()
            {
                Console.ReadLine();
            }
            public virtual void Read()
            {
            Console.Read(); 
            }

    }
}
