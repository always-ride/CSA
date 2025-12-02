namespace ExampleOnionLib
{
    public class SongEventArgs : EventArgs
    {
        public string SongName { get; }

        public SongEventArgs(string songName)
        {
            SongName = songName;
        }
    }
}
