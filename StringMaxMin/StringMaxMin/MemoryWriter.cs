using System.Text;

namespace StringMaxMin
{
    public class MemoryWriter : IWriter
    {
        private StringBuilder _builder = new StringBuilder();

        public void Write(string value)
        {
            _builder.Append(value);
        }

        public void WriteLine(string value)
        {
            _builder.AppendLine(value);
        }

        public void WriteLine()
        {
        }

        public string GetValue()
        {
            return _builder.ToString();
        }
    }
}
