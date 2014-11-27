using System;
using ClearMeasure.AFA.Writers.Interfaces;

namespace ClearMeasure.AFA.Writers
{
    public class ConsoleWriter : IWriter
    {
        public void WriteLine()
        {
            throw new System.NotImplementedException();
        }

        public void WriteLine(string message)
        {
            Console.WriteLine(message);
        }

        public void Write(string message)
        {
            throw new System.NotImplementedException();
        }
    }
}