namespace Codewars
{
    public class RectangleHelpers2
    {
        public static int UsePixels(IEnumerable<int[]> rectangles)
        {
            var area = 0;
            var pixels = new HashSet<Pixel>();
            foreach (var r in rectangles)
            {
                pixels.UnionWith(GetPixels(r[0], r[1], r[2], r[3]));
            }
            area = pixels.Count;
            return area;
        }

        public static Pixel[] GetPixels(int x0, int y0, int x1, int y1)
        {
            var pixels = new List<Pixel>();
            for (int y = y0; y < y1; y++)
            {
                for (int x = x0; x < x1; x++)
                {
                    pixels.Add(new Pixel(x, y));
                }
            }
            return [.. pixels];
        }

        public record Pixel(int x, int y);
    }
}
