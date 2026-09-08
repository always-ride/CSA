namespace EventTest
{
    public class Consumer
    {
        public string ConsumerName { get; init; }
        public Producer Producer { get; init; }

        public Consumer(string consumerName, Producer producer)
        {
            ConsumerName = consumerName;
            Producer = producer;

            Producer.SongBereit += OnSongBereit;
        }

        private void OnSongBereit(object sender, SongEventArgs e)
        {
            Console.WriteLine($"{ConsumerName} hat das Lied '{e.SongName}' gehört.");
        }
    }
}
