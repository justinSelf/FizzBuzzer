namespace ClearMeasure.AFA.DivisorStrategies.Interfaces
{
    public interface IDivisorStrategy
    {
        decimal Divisor { get; }
        bool IsFactorOf(decimal number);
        string Message { get; }
    }
}