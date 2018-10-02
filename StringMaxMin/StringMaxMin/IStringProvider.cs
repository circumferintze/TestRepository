using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace StringMaxMin
{
    interface IStringProvider
    {
        string GetValue();
    }

    interface IConsoleReader
    {
        void ReadLine();
    }

    interface IFileValueReader
    {
        void ReadFile(string path);
    }

    internal class ConsoleValueReader : AbstractValueReader, IConsoleReader, IStringProvider
    {
        public void ReadLine()
        {
            value = Console.ReadLine();
        }
    }

    class FileValueReader : AbstractValueReader, IFileValueReader, IStringProvider
    {
        public void ReadFile(string path)
        {
            value = File.ReadAllText(path);
        }
    }

    class AbstractValueReader : IStringProvider
    {
        protected string value;

        public virtual string GetValue()
        {
            return value;

        }
    }
}
