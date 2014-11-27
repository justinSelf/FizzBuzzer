using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClearMeasure.AFA;
using ClearMeasure.AFA.Writers;

namespace ClearMeasure.Interview
{
    class Program
    {
        static void Main(string[] args)
        {
            var fizzBuzzer = new FizzBuzzer(new ConsoleWriter());

            fizzBuzzer.Execute();
        }
    }
}
