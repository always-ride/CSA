using System.Text;

StringBuilder sb = new("The quick brown fox jumped over the lazy dog! ");
for (int i = 0; i <= sb.Length; i++)
{
    Console.WriteLine(sb);
    // Letztes Zeichen an Anfang verschieben
    char last = sb[sb.Length - 1];
    sb.Remove(sb.Length - 1, 1);
    sb.Insert(0, last);
}
