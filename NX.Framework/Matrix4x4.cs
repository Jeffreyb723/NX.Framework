namespace NX.Framework
{
    public readonly struct Matrix4x4
    {
        public double Xx { get; }
        public double Xy { get; }
        public double Xz { get; }
        public double Xa { get; }
        public double Yx { get; }
        public double Yy { get; }
        public double Yz { get; }
        public double Ya { get; }
        public double Zx { get; }
        public double Zy { get; }
        public double Zz { get; }
        public double Za { get; }
        public double Ax { get; }
        public double Ay { get; }
        public double Az { get; }
        public double Aa { get; }

        public Matrix4x4(double xx, double xy, double xz, double xa, double yx, double yy, double yz, double ya,
            double zx, double zy, double zz, double za, double ax, double ay, double az, double aa) =>
            (Xx, Xy, Xz, Xa, Yx, Yy, Yz, Ya, Zx, Zy, Zz, Za, Ax, Ay, Az, Aa) =
            (xx, xy, xz, xa, yx, yy, yz, ya, zx, zy, zz, za, ax, ay, az, aa);

        public override bool Equals(object other) => other != null && this == (Matrix4x4)other;

        public override int GetHashCode() =>
            (Xx, Xy, Xz, Xa, Yx, Yy, Yz, Ya, Zx, Zy, Zz, Za, Ax, Ay, Az, Aa).GetHashCode();

        public double[] ToArray() => new[] {Xx, Xy, Xz, Xa, Yx, Yy, Yz, Ya, Zx, Zy, Zz, Za, Ax, Ay, Az, Aa};

        public static bool operator ==(Matrix4x4 left, Matrix4x4 right) =>
            (left.Xx, left.Xy, left.Xz, left.Xa, left.Yx, left.Yy, left.Yz, left.Ya, left.Zx, left.Zy, left.Zz, left.Za,
                left.Ax, left.Ay, left.Az, left.Aa) == (right.Xx, right.Xy, right.Xz, right.Xa, right.Yx, right.Yy,
                right.Yz, right.Ya, right.Zx, right.Zy, right.Zz, right.Za, right.Ax, right.Ay, right.Az, right.Aa);

        public static bool operator !=(Matrix4x4 left, Matrix4x4 right) =>
            (left.Xx, left.Xy, left.Xz, left.Xa, left.Yx, left.Yy, left.Yz, left.Ya, left.Zx, left.Zy, left.Zz, left.Za,
                left.Ax, left.Ay, left.Az, left.Aa) != (right.Xx, right.Xy, right.Xz, right.Xa, right.Yx, right.Yy,
                right.Yz, right.Ya, right.Zx, right.Zy, right.Zz, right.Za, right.Ax, right.Ay, right.Az, right.Aa);
    }
}
