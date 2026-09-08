namespace ExampleOnionLib
{
    public class SongEventArgs(string songName) : EventArgs
    {
        public string SongName { get; } = songName;
    }
}
