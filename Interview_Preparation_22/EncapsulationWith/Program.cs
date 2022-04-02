using System;

namespace EncapsulationWith
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var lineSegment = new LineSegment(new Point(5,8),  new Point(10,8));
            Console.Write(lineSegment.Length());
        }
    }
    public class Point
    {
        public float x { get; }
        public float y { get; }
        public Point(float x, float y)
        {
            this.x = x;
            this.y = y;
        }
    }
    public class LineSegment
    {
        private Point Start { get; } // data hiding 
        private Point End { get; }
        public LineSegment(Point Start, Point End)
        {
            this.Start = Start;
            this.End = End;
        }
        public float Length() // encapsulated releabant method 
        {
            var xCoordDiff = End.x - Start.y;
            var yCoordDiff = End.y - Start.x;
            return (float)Math.Sqrt((xCoordDiff * xCoordDiff) + (yCoordDiff * yCoordDiff));
        }
    }
}

