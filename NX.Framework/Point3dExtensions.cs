using NXOpen;

namespace NX.Framework
{
    internal static class Point3dExtensions
    {
        internal static double[] ToArray(this Point3d point) => new[] {point.X, point.Y, point.Z};
    }
}
