namespace ExampleOnionLib.Core.Models
{
    public class SongEventArgs(string songName) : EventArgs
    {
        public string SongName { get; } = songName;
    }
}
