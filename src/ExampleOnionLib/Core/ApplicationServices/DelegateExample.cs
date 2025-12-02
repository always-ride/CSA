namespace ExampleOnionLib
{
    public class DelegateExample
    {
        public static void Execute()
        {
            Producer producer = new Producer();

            var c1 = new Consumer("Alice", producer);
            var c2 = new Consumer("Bob", producer);
            var c3 = new Consumer("Charlie", producer);

            producer.Compose("Symphony No. 1");
            producer.Compose("Funky Beats");
        }
    }
}