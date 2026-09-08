using EventTest;

internal class Program
{
    private static void Main(string[] args)
    {
        var srf3 = new Producer();

        var listener1 = new Consumer("Alice", srf3);
        var listener2 = new Consumer("Bela", srf3);
        var listener3 = new Consumer("Cedric", srf3);

        srf3.Broadcast("Song 1");
        srf3.Broadcast("Song 2");
    }
}