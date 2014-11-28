using System;
using ClearMeasure.AFA.Writers.Interfaces;

namespace ClearMeasure.AFA.Writers
{
    public class ConsoleWriter : IWriter
    {
        public void WriteLine(string message)
        {
            Console.WriteLine(message);
        }

    }
}