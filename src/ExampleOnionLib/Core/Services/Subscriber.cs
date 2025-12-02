namespace ExampleOnionLib
{
    public class Subscriber
    {
        private readonly string name;

        public Subscriber(string name)
        {
            this.name = name;
        }

        public void OnMessageReceived(string message)
        {
            Console.WriteLine($"{name} hat Nachricht empfangen: {message}");
        }
    }
}
