namespace MyLib
{
    public interface IConsoleTestClient : IConsoleClient
    {
        string LastlyPrintedText { get; }
    }

}
