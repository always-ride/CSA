namespace ExampleOnionLib
{
    public class Subscriber(string name)
    {
        private readonly string name = name;

        public void OnMessageReceived(string message)
        {
            Console.WriteLine($"{name} hat Nachricht empfangen: {message}");
        }
    }
}
