using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegmentIntersections
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
    public struct  Segment
    {
        public Point start;
        public Point end;
    }

    public class SegmentIntersections
    {
        public static IEnumerable<Point> tip_propagation(IReadOnlyList<Point> tipPath, IReadOnlyList<Segment> NF)
        {
            Point prev = tipPath.First();
            foreach (var t in tipPath)
            {
                Segment tip;
                tip.start = prev;
                tip.end = t;
                foreach (var nf in NF)
                {
                    Point intersection;
                    if (Crossing(tip, nf, out intersection))
                    {
                        yield return intersection;
                    }
                }
                prev = t;
            }
        }
        public static IEnumerable<Point> tip_propagation2X(IReadOnlyList<Point> tipPath, IReadOnlyList<Segment> NF)
        {
            var L = NF.Select(f => Math.Min(f.start.x, f.end.x)).ToList().SortIndex();
            var R = NF.Select(f => Math.Max(f.start.x, f.end.x)).ToList().SortIndex();

            var N = NF.Count;

            var BST = new HashSet<int>();

            Point prev = tipPath.First();

            var l = 0;
            var r = 0;

            foreach (var p in tipPath)
            {

                Segment tip;
                tip.start = prev;
                tip.end = p;

                var startx = Math.Min(tip.start.x, tip.end.x);
                var endx = Math.Max(tip.start.x, tip.end.x);

                while (l < N && Math.Min(NF[L[l]].start.x, NF[L[l]].end.x) < endx)
                {
                    BST.Add(L[l]);
                    l++;
                }
                while (r > 0 && Math.Max(NF[R[r - 1]].start.x, NF[R[r - 1]].end.x) > startx)
                {
                    BST.Add(R[r - 1]);
                    r--;
                }
                while (l > 0 && Math.Min(NF[L[l-1]].start.x, NF[L[l-1]].end.x) > endx)
                {
                    BST.Remove(L[l-1]);
                    l--;
                }
                while (r < N && Math.Max(NF[R[r]].start.x, NF[R[r]].end.x) < startx)
                {
                    BST.Remove(R[r]);
                    r++;
                }


                foreach (var f in BST)
                {
                    Point intersection;
                    if (Crossing(tip, NF[f], out intersection))
                    {
                        yield return intersection;
                    }
               
                }
                prev = p;
            }
        }

        public static IEnumerable<Point> tip_propagation2XY(IReadOnlyList<Point> tipPath, IReadOnlyList<Segment> NF)
        {
            var L = NF.Select(f => Math.Min(f.start.x, f.end.x)).ToList().SortIndex();
            var R = NF.Select(f => Math.Max(f.start.x, f.end.x)).ToList().SortIndex();
            var B = NF.Select(f => Math.Min(f.start.y, f.end.y)).ToList().SortIndex();
            var T = NF.Select(f => Math.Max(f.start.y, f.end.y)).ToList().SortIndex();

            var N = NF.Count;

            var BST = new HashSet<int>();

            Point prev = tipPath.First();

            var l = 0;
            var r = 0;
            var b = 0;
            var t = 0;


            foreach (var p in tipPath)
            {

                Segment tip;
                tip.start = prev;
                tip.end = p;

                var startx = Math.Min(tip.start.x, tip.end.x);
                var endx = Math.Max(tip.start.x, tip.end.x);
                var starty = Math.Min(tip.start.y, tip.end.y);
                var endy = Math.Max(tip.start.y, tip.end.y);

                while (l < N && Math.Min(NF[L[l]].start.x, NF[L[l]].end.x) < endx)
                {
                    BST.Add(L[l]);
                    l++;
                }
                while (l > 0 && Math.Min(NF[L[l - 1]].start.x, NF[L[l - 1]].end.x) > endx)
                {
                    BST.Remove(L[l - 1]);
                    l--;
                }

                while (r < N && Math.Max(NF[R[r]].start.x, NF[R[r]].end.x) < startx)
                {
                    BST.Remove(R[r]);
                    r++;
                }
                while (r > 0 && Math.Max(NF[R[r - 1]].start.x, NF[R[r - 1]].end.x) > startx)
                {
                    BST.Add(R[r - 1]);
                    r--;
                }
                while (b < N && Math.Min(NF[B[b]].start.y, NF[B[b]].end.y) < endy)
                {
                    BST.Add(B[b]);
                    b++;
                }
                while (b > 0 && Math.Min(NF[B[b - 1]].start.y, NF[B[b - 1]].end.y) > endy)
                {
                    BST.Remove(B[b - 1]);
                    b--;
                }

                while (t < N && Math.Max(NF[T[t]].start.y, NF[T[t]].end.y) < starty)
                {
                    BST.Remove(T[t]);
                    t++;
                }
                while (t > 0 && Math.Max(NF[T[t - 1]].start.y, NF[T[t - 1]].end.y) > starty)
                {
                    BST.Add(T[t - 1]);
                    t--;
                }
                foreach (var f in BST)
                {
                    Point intersection;
                    if (Crossing(tip, NF[f], out intersection))
                    {
                        yield return intersection;
                    }

                }
                prev = p;
            }
        }
        public static IEnumerable<Point> tip_propagation2Y(IReadOnlyList<Point> tipPath, IReadOnlyList<Segment> NF)
        {
            var B = NF.Select(f => Math.Min(f.start.y, f.end.y)).ToList().SortIndex();
            var T = NF.Select(f => Math.Max(f.start.y, f.end.y)).ToList().SortIndex();

            var N = NF.Count;

            var BST = new HashSet<int>();

            Point prev = tipPath.First();

            var b = 0;
            var t = 0;

            foreach (var p in tipPath)
            {

                Segment tip;
                tip.start = prev;
                tip.end = p;

                var starty = Math.Min(tip.start.y, tip.end.y);
                var endy = Math.Max(tip.start.y, tip.end.y);

                while (b < N && Math.Min(NF[B[b]].start.y, NF[B[b]].end.y) < endy)
                {
                    BST.Add(B[b]);
                    b++;
                }
                while (b > 0 && Math.Min(NF[B[b - 1]].start.y, NF[B[b - 1]].end.y) > endy)
                {
                    BST.Remove(B[b - 1]);
                    b--;
                }

                while (t < N && Math.Max(NF[T[t]].start.y, NF[T[t]].end.y) < starty)
                {
                    BST.Remove(T[t]);
                    t++;
                }
                while (t > 0 && Math.Max(NF[T[t - 1]].start.y, NF[T[t - 1]].end.y) > starty)
                {
                    BST.Add(T[t - 1]);
                    t--;
                }
                foreach (var f in BST)
                {
                    Point intersection;
                    if (Crossing(tip, NF[f], out intersection))
                    {
                        yield return intersection;
                    }

                }
                prev = p;
            }
        }

        private static bool Crossing(Segment s1, Segment s2, out Point intersection)
        {
            Point dir1 = s1.end - s1.start;
            Point dir2 = s2.end - s1.start;

            //считаем уравнения прямых проходящих через отрезки
            double a1 = -dir1.y;
            double b1 = +dir1.x;
            double d1 = -(a1 * s1.start.x + b1 * s1.start.y);

            double a2 = -dir2.y;
            double b2 = +dir2.x;
            double d2 = -(a2 * s2.start.x + b2 * s2.start.y);

            //подставляем концы отрезков, для выяснения в каких полуплоскотях они
            double seg1_line2_start = a2 * s1.start.x + b2 * s1.start.y + d2;
            double seg1_line2_end = a2 * s1.end.x + b2 * s1.end.y + d2;

            double seg2_line1_start = a1 * s2.start.x + b1 * s2.start.y + d1;
            double seg2_line1_end = a1 * s2.end.x + b1 * s2.end.y + d1;

            //если концы одного отрезка имеют один знак, значит он в одной полуплоскости и пересечения нет.
            if (seg1_line2_start*seg1_line2_end >= 0 || seg2_line1_start*seg2_line1_end >= 0)
            {
                intersection.x = Double.NaN;
                intersection.y = Double.NaN;
                return false;
            }

            double u = seg1_line2_start / (seg1_line2_start - seg1_line2_end);
            intersection = s1.start + u * dir1;

            return true;
        }
    }

    class IntSet
    {
        const int empty = -2;
        private int[] a;
        private int head =-1;
        public IntSet(int capacity)
        {
            a = new int[capacity];
            for(var i = 0 ; i < capacity; i++) a[i] = empty;
        }

        public void Add(int x)
        {
            if (a[x] == empty)
            {
                a[x] = head;
                head = x;
            }
        }
        public void Remove(int x)
        {
            if (a[x] != empty)
            {
                head = x;
                a[x] = empty;
            }
        }
    }
}
