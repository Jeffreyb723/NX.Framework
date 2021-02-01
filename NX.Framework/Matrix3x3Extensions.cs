using NXOpen;

namespace NX.Framework
{
    internal static class Matrix3x3Extensions
    {
        internal static double[] ToArray(this Matrix3x3 matrix) => new[]
            {matrix.Xx, matrix.Xy, matrix.Xz, matrix.Yx, matrix.Yy, matrix.Yz, matrix.Zx, matrix.Zy, matrix.Zz};
    }
}
