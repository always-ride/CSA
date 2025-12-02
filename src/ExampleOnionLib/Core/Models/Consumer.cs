namespace ExampleOnionLib
{
    public class Consumer
    {
        private readonly string consumerName;

        public Consumer(string consumerName, Producer producer)
        {
            this.consumerName = consumerName;

            // Event abonnieren
            producer.SongBereit += HandleSongBereit;
        }

        private void HandleSongBereit(object sender, SongEventArgs e)
        {
            Console.WriteLine("{0} Song: {1}", consumerName, e.SongName);
        }
    }
}
