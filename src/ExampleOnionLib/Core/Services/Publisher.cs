namespace ExampleOnionLib
{
    public class Publisher
    {
        public event MessageHandler MessageReceived;

        public void SendMessage(string message)
        {
            Console.WriteLine($"Publisher sendet: {message}");
            MessageReceived?.Invoke(message);
        }
    }
}
