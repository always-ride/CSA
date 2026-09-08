namespace EventTest
{
    public delegate void SongEventHandler(object sender, SongEventArgs e);
    
    public class Producer
    {
        //public event SongEventHandler? SongBereit;
        public event EventHandler<SongEventArgs>? SongBereit;

        public void Broadcast(string songName)
        {
            SongBereit?.Invoke(this, new SongEventArgs(songName));
        }
    }
}
