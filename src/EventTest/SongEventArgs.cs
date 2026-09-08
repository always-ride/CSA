namespace EventTest
{
    public class SongEventArgs(string songName) : EventArgs
    {
        public string SongName { get; init; } = songName;
    }
}
