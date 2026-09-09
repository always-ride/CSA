namespace Codewars
{
    public class RectangleHelpers1
    {
        public static int UseIntuitiveApproach(IEnumerable<int[]> rectangles)
        {
            var area = 0;
            Rect? lastRect = null;
            foreach (var rect in rectangles.Select(r => new Rect(r[0], r[1], r[2], r[3])))
            {
                area += GetArea(rect);

                if (lastRect != null && HasIntersection(lastRect, rect))
                    area -= GetIntersectionArea(lastRect, rect);

                lastRect = rect;
            }
            return area;
        }

        public static int GetArea(Rect r)
        {
            return (r.x1 - r.x0) * (r.y1 - r.y0);
        }

        public static bool HasIntersection(Rect r1, Rect r2)
        {
            return r1.x1 > r2.x0 && r1.x0 < r2.x1
                && r1.y1 > r2.y0 && r1.y0 < r2.y1;
        }

        public static int GetIntersectionArea(Rect r1, Rect r2)
        {
            int dx = Math.Min(r1.x1, r2.x1) - Math.Max(r1.x0, r2.x0);
            int dy = Math.Min(r1.y1, r2.y1) - Math.Max(r1.y0, r2.y0);
            return dx * dy;
        }
    }

    public record Rect(int x0, int y0, int x1, int y1);
}
