namespace ClearMeasure.AFA.DivisorStrategies
{
    public class DivisibleBy3 : BaseDivisorStrategy
    {
        public DivisibleBy3()
        {
            this.Divisor = 3;
            this.Message = "Fizz";
        }
    }
}