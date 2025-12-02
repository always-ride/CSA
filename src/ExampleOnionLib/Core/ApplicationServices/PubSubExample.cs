namespace ExampleOnionLib
{
    public delegate void MessageHandler(string message);

    public class PubSubExample
    {
        public static void Execute()
        {
            var publisher = new Publisher();

            var alice = new Subscriber("Alice");
            var bob = new Subscriber("Bob");

            publisher.MessageReceived += alice.OnMessageReceived;
            publisher.MessageReceived += bob.OnMessageReceived;

            publisher.SendMessage("Hallo Welt!");
            publisher.SendMessage("C# Events sind cool!");
        }
    }
}
