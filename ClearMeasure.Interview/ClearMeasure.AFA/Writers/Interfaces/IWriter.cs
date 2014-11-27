namespace ClearMeasure.AFA.Writers.Interfaces
{
    public interface IWriter
    {
        void WriteLine();
        void WriteLine(string message);
        void Write(string message);
    }
}