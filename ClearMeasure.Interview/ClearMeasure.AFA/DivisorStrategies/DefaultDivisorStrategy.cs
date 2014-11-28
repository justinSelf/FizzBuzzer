namespace ClearMeasure.AFA.DivisorStrategies
{
    public class DefaultDivisorStrategy : BaseDivisorStrategy
    {

        public override string GetMessageForFactorOf(long number)
        {
            return number.ToString();
        }
    }
}