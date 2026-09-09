namespace Codewars
{
    public class RectangleHelpers3
    {
        public static int UseOctTreeNode(IEnumerable<int[]> rectangles)
        {
            var en = rectangles.Select(Rect.Create).GetEnumerator();
            if (!en.MoveNext()) return 0;

            var tree = new OctTreeNode(en.Current);
            while (en.MoveNext()) tree.Insert(en.Current);
            return (int)tree.Area;
        }

        struct Rect 
        {
            public int l, r, t, b;

            public readonly long Area => (long)(r - l) * (t - b);

            public readonly bool Exist => l < r && b < t;

            public static Rect Create(params int[] c) => new() { 
                l = c[0], 
                b = c[1], 
                r = c[2], 
                t = c[3] 
            };

            public bool Intersects(Rect rc, out Rect result)
            {
                result = Create(
                    Math.Max(l, rc.l), Math.Max(b, rc.b),
                    Math.Min(r, rc.r), Math.Min(t, rc.t)
                );

                return result.Exist;
            }

            public Rect[] Octants(int n = int.MinValue, int p = int.MaxValue) =>
            [
                Create(n, n, l, b),
                Create(n, b, l, t),
                Create(n, t, l, p),
                Create(l, t, r, p),
                Create(r, t, p, p),
                Create(r, b, p, t),
                Create(r, n, p, b),
                Create(l, n, r, b)
            ];
        }

        class OctTreeNode(RectangleHelpers3.Rect rc)
        {
            Rect origin = rc;
            readonly Rect[] octBounds = rc.Octants();
            readonly OctTreeNode[] octValues = new OctTreeNode[8];
            
            public long Area => origin.Area + octValues.Sum(v => v?.Area ?? 0);

            public void Insert(Rect rc)
            {
                for (int i = 0; i < 8; i++)
                {
                    if (octBounds[i].Intersects(rc, out var part))
                    {
                        octValues[i]?.Insert(part);
                        octValues[i] ??= new OctTreeNode(part);
                    }
                }
            }
        }
    }
}