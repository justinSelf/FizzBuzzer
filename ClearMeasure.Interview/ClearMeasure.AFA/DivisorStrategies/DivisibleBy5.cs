using ClearMeasure.AFA.DivisorStrategies.Interfaces;

namespace ClearMeasure.AFA.DivisorStrategies
{
    public class DivisibleBy5 : BaseDivisorStrategy
    {
        public DivisibleBy5()
        {
            this.Divisor = 5;
            this.Message = "Buzz";
        }
    }
}