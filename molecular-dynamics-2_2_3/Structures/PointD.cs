using System;

namespace molecular_dynamics_2_2_3
{
    public struct PointD
    {
        public double X;
        public double Y;
        public PointD(double x, double y)
        {
            X = x;
            Y = y;
        }
        public PointD ToPoint()
        {
            return new PointD(X, Y);
        }
        public PointD Rotate(double angle)
        {
            return new PointD(X * Math.Cos(angle) - Y * Math.Sin(angle), X * Math.Sin(angle) + Y * Math.Cos(angle));
        }
        public override bool Equals(object obj)
        {
            return obj is PointD d && this == d;
        }
        public override int GetHashCode()
        {
            return X.GetHashCode() ^ Y.GetHashCode();
        }
        public static bool operator ==(PointD a, PointD b)
        {
            return a.X == b.X && a.Y == b.Y;
        }
        public static bool operator !=(PointD a, PointD b)
        {
            return !(a == b);
        }
    }
}
