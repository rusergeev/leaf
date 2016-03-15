namespace SegmentIntersection
{
    public struct Point
    {
        public double x;
        public double y;

        public static Point operator +(Point p1, Point p2)
        {
            Point p;
            p.x = p1.x + p2.x;
            p.y = p1.y + p2.y;

            return p;
        }

        public static Point operator -(Point p1, Point p2)
        {
            Point p;
            p.x = p1.x - p2.x;
            p.y = p1.y - p2.y;

            return p;
        }
        public static Point operator *(double k, Point p1)
        {
            Point p;
            p.x = p1.x*k;
            p.y = p1.y*k;

            return p;
        }
    }
}