using System;

namespace StringMaxMin
{
    public class ConsoleWriter : IWriter
    {
        public virtual void WriteLine(string value)
        {
            Console.WriteLine(value);
        }

        public virtual void Write(string value)
        {
            Console.Write(value);
        }

        public virtual void WriteLine()
        {
            Console.WriteLine();
        }
    }
}
