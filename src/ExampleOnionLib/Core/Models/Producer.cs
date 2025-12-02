namespace ExampleOnionLib
{
    public class Producer
    {
        // Event mit generischem EventHandler<T>
        public event EventHandler<SongEventArgs> SongBereit;

        public void Compose(string songName)
        {
            // Prüfen, ob Abonnenten vorhanden sind,
            // und Event auslösen
            SongBereit?.Invoke(this, new SongEventArgs(songName));
        }
    }
}
