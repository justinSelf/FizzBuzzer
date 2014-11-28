using System.Text;
using ClearMeasure.AFA.Writers.Interfaces;

namespace ClearMeasure.AFA.Writers
{
    public class StringBuilderWriter : IWriter
    {
        private readonly StringBuilder stringBuilder;

        public StringBuilderWriter(StringBuilder stringBuilder)
        {
            this.stringBuilder = stringBuilder;
        }

        public void WriteLine()
        {
            stringBuilder.AppendLine();
        }

        public void WriteLine(string message)
        {
            stringBuilder.AppendLine(message);
        }

        public void Write(string message)
        {
            stringBuilder.Append(message);
        }
    }
}