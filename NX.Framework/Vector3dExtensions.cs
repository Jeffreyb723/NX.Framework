using NXOpen;

namespace NX.Framework
{
    internal static class Vector3dExtensions
    {
        internal static double[] ToArray(this Vector3d vector) => new[] {vector.X, vector.Y, vector.Z};
    }
}
