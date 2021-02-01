using NXOpen;
using NXOpen.UF;

namespace NX.Framework
{
    public static class Mtx3Extensions
    {
        /// <summary>
        ///     Copies the matrix elements from a source 3x3 matrix to a destination 3x3
        ///     matrix.
        /// </summary>
        /// <remarks>
        ///     Refer to <see href="..ugopen_doc/uf_mtx/global.html#UF_MTX3_copy">UF_MTX3_copy</see> for documentation<br/>
        ///     <see href="..mapping/Uf2NxOpenNet.htm">Mapping Help</see><br/>
        ///     License requirements:None
        /// </remarks>
        /// <param name="ufMtx3"></param>
        /// <param name="mtx_src">Input Source matrix</param>
        /// <param name="mtx_dst">Output Destination matrix</param>
        public static void Copy(this UFMtx3 ufMtx3, double[] mtx_src, out double[] mtx_dst)
        {
            mtx_dst = new double[9];

            ufMtx3.Copy(mtx_src, mtx_dst);
        }

        /// <summary>
        ///     Copies the matrix elements from a source 3x3 matrix to a destination 3x3
        ///     matrix.
        /// </summary>
        /// <remarks>
        ///     Refer to <see href="..ugopen_doc/uf_mtx/global.html#UF_MTX3_copy">UF_MTX3_copy</see> for documentation<br/>
        ///     <see href="..mapping/Uf2NxOpenNet.htm">Mapping Help</see><br/>
        ///     License requirements:None
        /// </remarks>
        /// <param name="ufMtx3"></param>
        /// <param name="mtx_src">Input Source matrix</param>
        /// <param name="mtx_dst">Output Destination matrix</param>
        public static void Copy(this UFMtx3 ufMtx3, double[] mtx_src, out Matrix3x3 mtx_dst)
        {
            ufMtx3.Copy(mtx_src, out double[] matrix);

            mtx_dst = new Matrix3x3
            {
                Xx = matrix[0], Xy = matrix[1], Xz = matrix[2],
                Yx = matrix[3], Yy = matrix[4], Yz = matrix[5],
                Zx = matrix[6], Zy = matrix[7], Zz = matrix[8]
            };
        }

        /// <summary>
        ///     Copies the matrix elements from a source 3x3 matrix to a destination 3x3
        ///     matrix.
        /// </summary>
        /// <remarks>
        ///     Refer to <see href="..ugopen_doc/uf_mtx/global.html#UF_MTX3_copy">UF_MTX3_copy</see> for documentation<br/>
        ///     <see href="..mapping/Uf2NxOpenNet.htm">Mapping Help</see><br/>
        ///     License requirements:None
        /// </remarks>
        /// <param name="ufMtx3"></param>
        /// <param name="mtx_src">Input Source matrix</param>
        /// <param name="mtx_dst">Output Destination matrix</param>
        public static void Copy(this UFMtx3 ufMtx3, Matrix3x3 mtx_src, out Matrix3x3 mtx_dst) =>
            ufMtx3.Copy(mtx_src.ToArray(), out mtx_dst);

        /// <summary>
        ///     Calculates the determinant of a 3 x 3 matrix.
        /// </summary>
        /// <remarks>
        ///     Refer to <see href="..ugopen_doc/uf_mtx/global.html#UF_MTX3_determinant">UF_MTX3_determinant</see> for documentation<br/>
        ///     <see href="..mapping/Uf2NxOpenNet.htm">Mapping Help</see><br/>
        ///     License requirements:None
        /// </remarks>
        /// <param name="ufMtx3"></param>
        /// <param name="mtx">Input Matrix whose determinant in required</param>
        /// <param name="determinant">Output Matrix determinant</param>
        public static void Determinant(this UFMtx3 ufMtx3, Matrix3x3 mtx, out double determinant) =>
            ufMtx3.Determinant(mtx.ToArray(), out determinant);

        /// <summary>
        ///     Returns a 3 x 3 identity matrix.
        /// </summary>
        /// <remarks>
        ///     Refer to <see href="..ugopen_doc/uf_mtx/global.html#UF_MTX3_identity">UF_MTX3_identity</see> for documentation<br/>
        ///     <see href="..mapping/Uf2NxOpenNet.htm">Mapping Help</see><br/>
        ///     License requirements:None
        /// </remarks>
        /// <param name="ufMtx3"></param>
        /// <param name="mtx">Output Identity Matrix</param>
        public static void Identity(this UFMtx3 ufMtx3, out double[] mtx)
        {
            mtx = new double[9];
            ufMtx3.Identity(mtx);
        }

        /// <summary>
        ///     Returns a 3 x 3 identity matrix.
        /// </summary>
        /// <remarks>
        ///     Refer to <see href="..ugopen_doc/uf_mtx/global.html#UF_MTX3_identity">UF_MTX3_identity</see> for documentation<br/>
        ///     <see href="..mapping/Uf2NxOpenNet.htm">Mapping Help</see><br/>
        ///     License requirements:None
        /// </remarks>
        /// <param name="ufMtx3"></param>
        /// <param name="mtx">Output Identity Matrix</param>
        public static void Identity(this UFMtx3 ufMtx3, out Matrix3x3 mtx)
        {
            ufMtx3.Identity(out double[] matrix);

            mtx = new Matrix3x3
            {
                Xx = matrix[0], Xy = matrix[1], Xz = matrix[2],
                Yx = matrix[3], Yy = matrix[4], Yz = matrix[5],
                Zx = matrix[6], Zy = matrix[7], Zz = matrix[8]
            };
        }

        /// <summary>
        ///     Returns a 3x3 matrix formed from two input 3D vectors. The two
        ///     input vectors are normalized and the y-direction vector is made
        ///     orthogonal to the x-direction vector before taking the cross product
        ///     (x_vec X y_vec) to generate the z-direction vector.
        /// </summary>
        /// <remarks>
        ///     Refer to <see href="..ugopen_doc/uf_mtx/global.html#UF_MTX3_initialize">UF_MTX3_initialize</see> for documentation<br/>
        ///     <see href="..mapping/Uf2NxOpenNet.htm">Mapping Help</see><br/>
        ///     License requirements:None
        /// </remarks>
        /// <param name="ufMtx3"></param>
        /// <param name="x_vec">Input Vector for the X-direction of matrix</param>
        /// <param name="y_vec">Input Vector for the Y-direction of matrix</param>
        /// <param name="mtx">Output Matrix</param>
        public static void Initialize(this UFMtx3 ufMtx3, double[] x_vec, double[] y_vec, out double[] mtx)
        {
            mtx = new double[8];

            ufMtx3.Initialize(x_vec, y_vec, mtx);
        }

        /// <summary>
        ///     Returns a 3x3 matrix formed from two input 3D vectors. The two
        ///     input vectors are normalized and the y-direction vector is made
        ///     orthogonal to the x-direction vector before taking the cross product
        ///     (x_vec X y_vec) to generate the z-direction vector.
        /// </summary>
        /// <remarks>
        ///     Refer to <see href="..ugopen_doc/uf_mtx/global.html#UF_MTX3_initialize">UF_MTX3_initialize</see> for documentation<br/>
        ///     <see href="..mapping/Uf2NxOpenNet.htm">Mapping Help</see><br/>
        ///     License requirements:None
        /// </remarks>
        /// <param name="ufMtx3"></param>
        /// <param name="x_vec">Input Vector for the X-direction of matrix</param>
        /// <param name="y_vec">Input Vector for the Y-direction of matrix</param>
        /// <param name="mtx">Output Matrix</param>
        public static void Initialize(this UFMtx3 ufMtx3, double[] x_vec, double[] y_vec, out Matrix3x3 mtx)
        {
            ufMtx3.Initialize(x_vec, y_vec, out double[] matrix);

            mtx = new Matrix3x3
            {
                Xx = matrix[0], Xy = matrix[1], Xz = matrix[2],
                Yx = matrix[3], Yy = matrix[4], Yz = matrix[5],
                Zx = matrix[6], Zy = matrix[7], Zz = matrix[8]
            };
        }

        /// <summary>
        ///     Returns a 3x3 matrix formed from two input 3D vectors. The two
        ///     input vectors are normalized and the y-direction vector is made
        ///     orthogonal to the x-direction vector before taking the cross product
        ///     (x_vec X y_vec) to generate the z-direction vector.
        /// </summary>
        /// <remarks>
        ///     Refer to <see href="..ugopen_doc/uf_mtx/global.html#UF_MTX3_initialize">UF_MTX3_initialize</see> for documentation<br/>
        ///     <see href="..mapping/Uf2NxOpenNet.htm">Mapping Help</see><br/>
        ///     License requirements:None
        /// </remarks>
        /// <param name="ufMtx3"></param>
        /// <param name="x_vec">Input Vector for the X-direction of matrix</param>
        /// <param name="y_vec">Input Vector for the Y-direction of matrix</param>
        /// <param name="mtx">Output Matrix</param>
        public static void Initialize(this UFMtx3 ufMtx3, Vector3d x_vec, double[] y_vec, out Matrix3x3 mtx) =>
            ufMtx3.Initialize(x_vec.ToArray(), y_vec, out mtx);

        /// <summary>
        ///     Returns a 3x3 matrix formed from two input 3D vectors. The two
        ///     input vectors are normalized and the y-direction vector is made
        ///     orthogonal to the x-direction vector before taking the cross product
        ///     (x_vec X y_vec) to generate the z-direction vector.
        /// </summary>
        /// <remarks>
        ///     Refer to <see href="..ugopen_doc/uf_mtx/global.html#UF_MTX3_initialize">UF_MTX3_initialize</see> for documentation<br/>
        ///     <see href="..mapping/Uf2NxOpenNet.htm">Mapping Help</see><br/>
        ///     License requirements:None
        /// </remarks>
        /// <param name="ufMtx3"></param>
        /// <param name="x_vec">Input Vector for the X-direction of matrix</param>
        /// <param name="y_vec">Input Vector for the Y-direction of matrix</param>
        /// <param name="mtx">Output Matrix</param>
        public static void Initialize(this UFMtx3 ufMtx3, double[] x_vec, Vector3d y_vec, out Matrix3x3 mtx) =>
            ufMtx3.Initialize(x_vec, y_vec.ToArray(), out mtx);

        /// <summary>
        ///     Returns a 3x3 matrix formed from two input 3D vectors. The two
        ///     input vectors are normalized and the y-direction vector is made
        ///     orthogonal to the x-direction vector before taking the cross product
        ///     (x_vec X y_vec) to generate the z-direction vector.
        /// </summary>
        /// <remarks>
        ///     Refer to <see href="..ugopen_doc/uf_mtx/global.html#UF_MTX3_initialize">UF_MTX3_initialize</see> for documentation<br/>
        ///     <see href="..mapping/Uf2NxOpenNet.htm">Mapping Help</see><br/>
        ///     License requirements:None
        /// </remarks>
        /// <param name="ufMtx3"></param>
        /// <param name="x_vec">Input Vector for the X-direction of matrix</param>
        /// <param name="y_vec">Input Vector for the Y-direction of matrix</param>
        /// <param name="mtx">Output Matrix</param>
        public static void Initialize(this UFMtx3 ufMtx3, Vector3d x_vec, Vector3d y_vec, out Matrix3x3 mtx) =>
            ufMtx3.Initialize(x_vec.ToArray(), y_vec.ToArray(), out mtx);

        /// <summary>
        ///     Returns a 3x3 matrix formed from three input 3D vectors.
        /// </summary>
        /// <remarks>
        ///     Refer to <see href="..ugopen_doc/uf_mtx/global.html#UF_MTX3_initialize">UF_MTX3_initialize</see> for documentation<br/>
        ///     <see href="..mapping/Uf2NxOpenNet.htm">Mapping Help</see><br/>
        ///     License requirements:None
        /// </remarks>
        /// <param name="ufMtx3"></param>
        /// <param name="x_vec">Input Vector for the X-direction of matrix</param>
        /// <param name="y_vec">Input Vector for the Y-direction of matrix</param>
        /// <param name="z_vec">Input Vector for the Z-direction of matrix</param>
        /// <param name="mtx">Output Matrix</param>
        public static void Initialize(this UFMtx3 ufMtx3, double[] x_vec, double[] y_vec, double[] z_vec,
            out Matrix3x3 mtx)
        {
            double[] matrix = new double[9];

            ufMtx3.Initialize(x_vec, y_vec, matrix);
            ufMtx3.InitializeZ(z_vec, matrix);

            mtx = new Matrix3x3
            {
                Xx = matrix[0], Xy = matrix[1], Xz = matrix[2], 
                Yx = matrix[3], Yy = matrix[4], Yz = matrix[5],
                Zx = matrix[6], Zy = matrix[7], Zz = matrix[8]
            };
        }

        /// <summary>
        ///     Returns a 3x3 matrix formed from three input 3D vectors.
        /// </summary>
        /// <remarks>
        ///     Refer to <see href="..ugopen_doc/uf_mtx/global.html#UF_MTX3_initialize">UF_MTX3_initialize</see> for documentation<br/>
        ///     <see href="..mapping/Uf2NxOpenNet.htm">Mapping Help</see><br/>
        ///     License requirements:None
        /// </remarks>
        /// <param name="ufMtx3"></param>
        /// <param name="x_vec">Input Vector for the X-direction of matrix</param>
        /// <param name="y_vec">Input Vector for the Y-direction of matrix</param>
        /// <param name="z_vec">Input Vector for the Z-direction of matrix</param>
        /// <param name="mtx">Output Matrix</param>
        public static void Initialize(this UFMtx3 ufMtx3, Vector3d x_vec, double[] y_vec, double[] z_vec,
            out Matrix3x3 mtx) => ufMtx3.Initialize(x_vec.ToArray(), y_vec, z_vec, out mtx);

        /// <summary>
        ///     Returns a 3x3 matrix formed from three input 3D vectors.
        /// </summary>
        /// <remarks>
        ///     Refer to <see href="..ugopen_doc/uf_mtx/global.html#UF_MTX3_initialize">UF_MTX3_initialize</see> for documentation<br/>
        ///     <see href="..mapping/Uf2NxOpenNet.htm">Mapping Help</see><br/>
        ///     License requirements:None
        /// </remarks>
        /// <param name="ufMtx3"></param>
        /// <param name="x_vec">Input Vector for the X-direction of matrix</param>
        /// <param name="y_vec">Input Vector for the Y-direction of matrix</param>
        /// <param name="z_vec">Input Vector for the Z-direction of matrix</param>
        /// <param name="mtx">Output Matrix</param>
        public static void Initialize(this UFMtx3 ufMtx3, double[] x_vec, Vector3d y_vec, double[] z_vec,
            out Matrix3x3 mtx) => ufMtx3.Initialize(x_vec, y_vec.ToArray(), z_vec, out mtx);

        /// <summary>
        ///     Returns a 3x3 matrix formed from three input 3D vectors.
        /// </summary>
        /// <remarks>
        ///     Refer to <see href="..ugopen_doc/uf_mtx/global.html#UF_MTX3_initialize">UF_MTX3_initialize</see> for documentation<br/>
        ///     <see href="..mapping/Uf2NxOpenNet.htm">Mapping Help</see><br/>
        ///     License requirements:None
        /// </remarks>
        /// <param name="ufMtx3"></param>
        /// <param name="x_vec">Input Vector for the X-direction of matrix</param>
        /// <param name="y_vec">Input Vector for the Y-direction of matrix</param>
        /// <param name="z_vec">Input Vector for the Z-direction of matrix</param>
        /// <param name="mtx">Output Matrix</param>
        public static void Initialize(this UFMtx3 ufMtx3, double[] x_vec, double[] y_vec, Vector3d z_vec,
            out Matrix3x3 mtx) => ufMtx3.Initialize(x_vec, y_vec, z_vec.ToArray(), out mtx);

        /// <summary>
        ///     Returns a 3x3 matrix formed from three input 3D vectors.
        /// </summary>
        /// <remarks>
        ///     Refer to <see href="..ugopen_doc/uf_mtx/global.html#UF_MTX3_initialize">UF_MTX3_initialize</see> for documentation<br/>
        ///     <see href="..mapping/Uf2NxOpenNet.htm">Mapping Help</see><br/>
        ///     License requirements:None
        /// </remarks>
        /// <param name="ufMtx3"></param>
        /// <param name="x_vec">Input Vector for the X-direction of matrix</param>
        /// <param name="y_vec">Input Vector for the Y-direction of matrix</param>
        /// <param name="z_vec">Input Vector for the Z-direction of matrix</param>
        /// <param name="mtx">Output Matrix</param>
        public static void Initialize(this UFMtx3 ufMtx3, Vector3d x_vec, Vector3d y_vec, double[] z_vec,
            out Matrix3x3 mtx) => ufMtx3.Initialize(x_vec.ToArray(), y_vec.ToArray(), z_vec, out mtx);

        /// <summary>
        ///     Returns a 3x3 matrix formed from three input 3D vectors.
        /// </summary>
        /// <remarks>
        ///     Refer to <see href="..ugopen_doc/uf_mtx/global.html#UF_MTX3_initialize">UF_MTX3_initialize</see> for documentation<br/>
        ///     <see href="..mapping/Uf2NxOpenNet.htm">Mapping Help</see><br/>
        ///     License requirements:None
        /// </remarks>
        /// <param name="ufMtx3"></param>
        /// <param name="x_vec">Input Vector for the X-direction of matrix</param>
        /// <param name="y_vec">Input Vector for the Y-direction of matrix</param>
        /// <param name="z_vec">Input Vector for the Z-direction of matrix</param>
        /// <param name="mtx">Output Matrix</param>
        public static void Initialize(this UFMtx3 ufMtx3, Vector3d x_vec, double[] y_vec, Vector3d z_vec,
            out Matrix3x3 mtx) => ufMtx3.Initialize(x_vec.ToArray(), y_vec, z_vec.ToArray(), out mtx);

        /// <summary>
        ///     Returns a 3x3 matrix formed from three input 3D vectors.
        /// </summary>
        /// <remarks>
        ///     Refer to <see href="..ugopen_doc/uf_mtx/global.html#UF_MTX3_initialize">UF_MTX3_initialize</see> for documentation<br/>
        ///     <see href="..mapping/Uf2NxOpenNet.htm">Mapping Help</see><br/>
        ///     License requirements:None
        /// </remarks>
        /// <param name="ufMtx3"></param>
        /// <param name="x_vec">Input Vector for the X-direction of matrix</param>
        /// <param name="y_vec">Input Vector for the Y-direction of matrix</param>
        /// <param name="z_vec">Input Vector for the Z-direction of matrix</param>
        /// <param name="mtx">Output Matrix</param>
        public static void Initialize(this UFMtx3 ufMtx3, double[] x_vec, Vector3d y_vec, Vector3d z_vec,
            out Matrix3x3 mtx) => ufMtx3.Initialize(x_vec, y_vec.ToArray(), z_vec.ToArray(), out mtx);

        /// <summary>
        ///     Returns a 3x3 matrix formed from three input 3D vectors.
        /// </summary>
        /// <remarks>
        ///     Refer to <see href="..ugopen_doc/uf_mtx/global.html#UF_MTX3_initialize">UF_MTX3_initialize</see> for documentation<br/>
        ///     <see href="..mapping/Uf2NxOpenNet.htm">Mapping Help</see><br/>
        ///     License requirements:None
        /// </remarks>
        /// <param name="ufMtx3"></param>
        /// <param name="x_vec">Input Vector for the X-direction of matrix</param>
        /// <param name="y_vec">Input Vector for the Y-direction of matrix</param>
        /// <param name="z_vec">Input Vector for the Z-direction of matrix</param>
        /// <param name="mtx">Output Matrix</param>
        public static void Initialize(this UFMtx3 ufMtx3, Vector3d x_vec, Vector3d y_vec, Vector3d z_vec,
            out Matrix3x3 mtx) => ufMtx3.Initialize(x_vec.ToArray(), y_vec.ToArray(), z_vec.ToArray(), out mtx);

        /// <summary>
        ///     Returns a 3x3 matrix with the given X-direction vector and having
        ///     arbitrary Y- and Z-direction vectors.
        /// </summary>
        /// <remarks>
        ///     Refer to <see href="..ugopen_doc/uf_mtx/global.html#UF_MTX3_initialize_x">UF_MTX3_initialize_x</see> for documentation<br/>
        ///     <see href="..mapping/Uf2NxOpenNet.htm">Mapping Help</see><br/>
        ///     License requirements:None
        /// </remarks>
        /// <param name="ufMtx3"></param>
        /// <param name="x_vec">Input Vector for the X-direction of matrix</param>
        /// <param name="mtx">Output Matrix (3x3)</param>
        public static void InitializeX(this UFMtx3 ufMtx3, double[] x_vec, out double[] mtx)
        {
            mtx = new double[8];

            ufMtx3.InitializeX(x_vec, mtx);
        }

        /// <summary>
        ///     Returns a 3x3 matrix with the given X-direction vector and having
        ///     arbitrary Y- and Z-direction vectors.
        /// </summary>
        /// <remarks>
        ///     Refer to <see href="..ugopen_doc/uf_mtx/global.html#UF_MTX3_initialize_x">UF_MTX3_initialize_x</see> for documentation<br/>
        ///     <see href="..mapping/Uf2NxOpenNet.htm">Mapping Help</see><br/>
        ///     License requirements:None
        /// </remarks>
        /// <param name="ufMtx3"></param>
        /// <param name="x_vec">Input Vector for the X-direction of matrix</param>
        /// <param name="mtx">Output Matrix (3x3)</param>
        public static void InitializeX(this UFMtx3 ufMtx3, double[] x_vec, out Matrix3x3 mtx)
        {
            ufMtx3.InitializeX(x_vec, out double[] matrix);

            mtx = new Matrix3x3
            {
                Xx = matrix[0], Xy = matrix[1], Xz = matrix[2],
                Yx = matrix[3], Yy = matrix[4], Yz = matrix[5],
                Zx = matrix[6], Zy = matrix[7], Zz = matrix[8]
            };
        }

        /// <summary>
        ///     Returns a 3x3 matrix with the given X-direction vector and having
        ///     arbitrary Y- and Z-direction vectors.
        /// </summary>
        /// <remarks>
        ///     Refer to <see href="..ugopen_doc/uf_mtx/global.html#UF_MTX3_initialize_x">UF_MTX3_initialize_x</see> for documentation<br/>
        ///     <see href="..mapping/Uf2NxOpenNet.htm">Mapping Help</see><br/>
        ///     License requirements:None
        /// </remarks>
        /// <param name="ufMtx3"></param>
        /// <param name="x_vec">Input Vector for the X-direction of matrix</param>
        /// <param name="mtx">Output Matrix (3x3)</param>
        public static void InitializeX(this UFMtx3 ufMtx3, Vector3d x_vec, out Matrix3x3 mtx) =>
            ufMtx3.InitializeX(x_vec.ToArray(), out mtx);

        /// <summary>
        ///     Returns a 3x3 matrix with the given Z-direction vector and having
        ///     arbitrary X- and Y-direction vectors.
        /// </summary>
        /// <remarks>
        ///     Refer to <see href="..ugopen_doc/uf_mtx/global.html#UF_MTX3_initialize_z">UF_MTX3_initialize_z</see> for documentation<br/>
        ///     <see href="..mapping/Uf2NxOpenNet.htm">Mapping Help</see><br/>
        ///     License requirements:None
        /// </remarks>
        /// <param name="ufMtx3"></param>
        /// <param name="z_vec">Input Vector for the Z-direction of matrix</param>
        /// <param name="mtx">Output Matrix (3x3)</param>
        public static void InitializeZ(this UFMtx3 ufMtx3, double[] z_vec, out double[] mtx)
        {
            mtx = new double[8];

            ufMtx3.InitializeZ(z_vec, mtx);
        }

        /// <summary>
        ///     Returns a 3x3 matrix with the given Z-direction vector and having
        ///     arbitrary X- and Y-direction vectors.
        /// </summary>
        /// <remarks>
        ///     Refer to <see href="..ugopen_doc/uf_mtx/global.html#UF_MTX3_initialize_z">UF_MTX3_initialize_z</see> for documentation<br/>
        ///     <see href="..mapping/Uf2NxOpenNet.htm">Mapping Help</see><br/>
        ///     License requirements:None
        /// </remarks>
        /// <param name="ufMtx3"></param>
        /// <param name="z_vec">Input Vector for the Z-direction of matrix</param>
        /// <param name="mtx">Output Matrix (3x3)</param>
        public static void InitializeZ(this UFMtx3 ufMtx3, double[] z_vec, out Matrix3x3 mtx)
        {
            ufMtx3.InitializeZ(z_vec, out double[] matrix);

            mtx = new Matrix3x3
            {
                Xx = matrix[0], Xy = matrix[1], Xz = matrix[2],
                Yx = matrix[3], Yy = matrix[4], Yz = matrix[5],
                Zx = matrix[6], Zy = matrix[7], Zz = matrix[8]
            };
        }

        /// <summary>
        ///     Returns a 3x3 matrix with the given Z-direction vector and having
        ///     arbitrary X- and Y-direction vectors.
        /// </summary>
        /// <remarks>
        ///     Refer to <see href="..ugopen_doc/uf_mtx/global.html#UF_MTX3_initialize_z">UF_MTX3_initialize_z</see> for documentation<br/>
        ///     <see href="..mapping/Uf2NxOpenNet.htm">Mapping Help</see><br/>
        ///     License requirements:None
        /// </remarks>
        /// <param name="ufMtx3"></param>
        /// <param name="z_vec">Input Vector for the Z-direction of matrix</param>
        /// <param name="mtx">Output Matrix (3x3)</param>
        public static void InitializeZ(this UFMtx3 ufMtx3, Vector3d z_vec, out Matrix3x3 mtx) =>
            ufMtx3.InitializeZ(z_vec.ToArray(), out mtx);

        /// <summary>
        ///     Converts a 3D matrix to a 4D matrix with a scale of 1.0 and a zero
        ///     translation vector.
        /// </summary>
        /// <remarks>
        ///     Refer to <see href="..ugopen_doc/uf_mtx/global.html#UF_MTX3_mtx4">UF_MTX3_mtx4</see> for documentation<br/>
        ///     <see href="..mapping/Uf2NxOpenNet.htm">Mapping Help</see><br/>
        ///     License requirements:None
        /// </remarks>
        /// <param name="ufMtx3"></param>
        /// <param name="mtx_3D">Input 3D matrix</param>
        /// <param name="mtx_4D">Output 4D matrix</param>
        public static void Mtx4(this UFMtx3 ufMtx3, double[] mtx_3D, out double[] mtx_4D)
        {
            mtx_4D = new double[16];

            ufMtx3.Mtx4(mtx_3D, mtx_4D);
        }

        /// <summary>
        ///     Converts a 3D matrix to a 4D matrix with a scale of 1.0 and a zero
        ///     translation vector.
        /// </summary>
        /// <remarks>
        ///     Refer to <see href="..ugopen_doc/uf_mtx/global.html#UF_MTX3_mtx4">UF_MTX3_mtx4</see> for documentation<br/>
        ///     <see href="..mapping/Uf2NxOpenNet.htm">Mapping Help</see><br/>
        ///     License requirements:None
        /// </remarks>
        /// <param name="ufMtx3"></param>
        /// <param name="mtx_3D">Input 3D matrix</param>
        /// <param name="mtx_4D">Output 4D matrix</param>
        public static void Mtx4(this UFMtx3 ufMtx3, double[] mtx_3D, out Matrix4x4 mtx_4D)
        {
            ufMtx3.Mtx4(mtx_3D, out double[] matrix);

            mtx_4D = new Matrix4x4(matrix[0], matrix[1], matrix[2], matrix[3], matrix[4], matrix[5],
                matrix[6], matrix[7], matrix[8], matrix[9], matrix[10], matrix[11], matrix[12],
                matrix[13], matrix[14], matrix[15]);
        }

        /// <summary>
        ///     Converts a 3D matrix to a 4D matrix with a scale of 1.0 and a zero
        ///     translation vector.
        /// </summary>
        /// <remarks>
        ///     Refer to <see href="..ugopen_doc/uf_mtx/global.html#UF_MTX3_mtx4">UF_MTX3_mtx4</see> for documentation<br/>
        ///     <see href="..mapping/Uf2NxOpenNet.htm">Mapping Help</see><br/>
        ///     License requirements:None
        /// </remarks>
        /// <param name="ufMtx3"></param>
        /// <param name="mtx_3D">Input 3D matrix</param>
        /// <param name="mtx_4D">Output 4D matrix</param>
        public static void Mtx4(this UFMtx3 ufMtx3, Matrix3x3 mtx_3D, out Matrix4x4 mtx_4D) =>
            ufMtx3.Mtx4(mtx_3D.ToArray(), out mtx_4D);

        /// <summary>
        ///     Returns a 3x3 matrix product from two input matrices.
        /// </summary>
        /// <remarks>
        ///     Refer to <see href="..ugopen_doc/uf_mtx/global.html#UF_MTX3_multiply">UF_MTX3_multiply</see> for documentation<br/>
        ///     <see href="..mapping/Uf2NxOpenNet.htm">Mapping Help</see><br/>
        ///     License requirements:None
        /// </remarks>
        /// <param name="ufMtx3"></param>
        /// <param name="mtx1">Input Matrix #1</param>
        /// <param name="mtx2">Input Matrix #2</param>
        /// <param name="mtx_product">Output Matrix product
        ///     mtx_product = mtx1 X mtx2</param>
        public static void Multiply(this UFMtx3 ufMtx3, double[] mtx1, double[] mtx2, out double[] mtx_product)
        {
            mtx_product = new double[9];

            ufMtx3.Multiply(mtx1, mtx2, mtx_product);
        }

        /// <summary>
        ///     Returns a 3x3 matrix product from two input matrices.
        /// </summary>
        /// <remarks>
        ///     Refer to <see href="..ugopen_doc/uf_mtx/global.html#UF_MTX3_multiply">UF_MTX3_multiply</see> for documentation<br/>
        ///     <see href="..mapping/Uf2NxOpenNet.htm">Mapping Help</see><br/>
        ///     License requirements:None
        /// </remarks>
        /// <param name="ufMtx3"></param>
        /// <param name="mtx1">Input Matrix #1</param>
        /// <param name="mtx2">Input Matrix #2</param>
        /// <param name="mtx_product">Output Matrix product
        ///     mtx_product = mtx1 X mtx2</param>
        public static void Multiply(this UFMtx3 ufMtx3, double[] mtx1, double[] mtx2, out Matrix3x3 mtx_product)
        {
            ufMtx3.Multiply(mtx1, mtx2, out double[] matrix);

            mtx_product = new Matrix3x3
            {
                Xx = matrix[0], Xy = matrix[1], Xz = matrix[2],
                Yx = matrix[3], Yy = matrix[4], Yz = matrix[5],
                Zx = matrix[6], Zy = matrix[7], Zz = matrix[8]
            };
        }

        /// <summary>
        ///     Returns a 3x3 matrix product from two input matrices.
        /// </summary>
        /// <remarks>
        ///     Refer to <see href="..ugopen_doc/uf_mtx/global.html#UF_MTX3_multiply">UF_MTX3_multiply</see> for documentation<br/>
        ///     <see href="..mapping/Uf2NxOpenNet.htm">Mapping Help</see><br/>
        ///     License requirements:None
        /// </remarks>
        /// <param name="ufMtx3"></param>
        /// <param name="mtx1">Input Matrix #1</param>
        /// <param name="mtx2">Input Matrix #2</param>
        /// <param name="mtx_product">Output Matrix product
        ///     mtx_product = mtx1 X mtx2</param>
        public static void Multiply(this UFMtx3 ufMtx3, Matrix3x3 mtx1, double[] mtx2, out Matrix3x3 mtx_product) =>
            ufMtx3.Multiply(mtx1.ToArray(), mtx2, out mtx_product);

        /// <summary>
        ///     Returns a 3x3 matrix product from two input matrices.
        /// </summary>
        /// <remarks>
        ///     Refer to <see href="..ugopen_doc/uf_mtx/global.html#UF_MTX3_multiply">UF_MTX3_multiply</see> for documentation<br/>
        ///     <see href="..mapping/Uf2NxOpenNet.htm">Mapping Help</see><br/>
        ///     License requirements:None
        /// </remarks>
        /// <param name="ufMtx3"></param>
        /// <param name="mtx1">Input Matrix #1</param>
        /// <param name="mtx2">Input Matrix #2</param>
        /// <param name="mtx_product">Output Matrix product
        ///     mtx_product = mtx1 X mtx2</param>
        public static void Multiply(this UFMtx3 ufMtx3, double[] mtx1, Matrix3x3 mtx2, out Matrix3x3 mtx_product) =>
            ufMtx3.Multiply(mtx1, mtx2.ToArray(), out mtx_product);

        /// <summary>
        ///     Returns a 3x3 matrix product from two input matrices.
        /// </summary>
        /// <remarks>
        ///     Refer to <see href="..ugopen_doc/uf_mtx/global.html#UF_MTX3_multiply">UF_MTX3_multiply</see> for documentation<br/>
        ///     <see href="..mapping/Uf2NxOpenNet.htm">Mapping Help</see><br/>
        ///     License requirements:None
        /// </remarks>
        /// <param name="ufMtx3"></param>
        /// <param name="mtx1">Input Matrix #1</param>
        /// <param name="mtx2">Input Matrix #2</param>
        /// <param name="mtx_product">Output Matrix product
        ///     mtx_product = mtx1 X mtx2</param>
        public static void Multiply(this UFMtx3 ufMtx3, Matrix3x3 mtx1, Matrix3x3 mtx2, out Matrix3x3 mtx_product) =>
            ufMtx3.Multiply(mtx1.ToArray(), mtx2.ToArray(), out mtx_product);

        /// <summary>
        ///     Returns a 3x3 matrix product by transposing the first matrix before
        ///     performing the multiplication.
        /// </summary>
        /// <remarks>
        ///     Refer to <see href="..ugopen_doc/uf_mtx/global.html#UF_MTX3_multiply_t">UF_MTX3_multiply_t</see> for documentation<br/>
        ///     <see href="..mapping/Uf2NxOpenNet.htm">Mapping Help</see><br/>
        ///     License requirements:None
        /// </remarks>
        /// <param name="ufMtx3"></param>
        /// <param name="mtx1">Input Matrix #1 gets transposed before the multiplication.</param>
        /// <param name="mtx2">Input Matrix #2</param>
        /// <param name="mtx_product">Output Matrix product
        ///     mtx_product = trns(mtx1) X mtx2</param>
        public static void MultiplyT(this UFMtx3 ufMtx3, double[] mtx1, double[] mtx2, out double[] mtx_product)
        {
            mtx_product = new double[9];

            ufMtx3.MultiplyT(mtx1, mtx2, mtx_product);
        }

        /// <summary>
        ///     Returns a 3x3 matrix product by transposing the first matrix before
        ///     performing the multiplication.
        /// </summary>
        /// <remarks>
        ///     Refer to <see href="..ugopen_doc/uf_mtx/global.html#UF_MTX3_multiply_t">UF_MTX3_multiply_t</see> for documentation<br/>
        ///     <see href="..mapping/Uf2NxOpenNet.htm">Mapping Help</see><br/>
        ///     License requirements:None
        /// </remarks>
        /// <param name="ufMtx3"></param>
        /// <param name="mtx1">Input Matrix #1 gets transposed before the multiplication.</param>
        /// <param name="mtx2">Input Matrix #2</param>
        /// <param name="mtx_product">Output Matrix product
        ///     mtx_product = trns(mtx1) X mtx2</param>
        public static void MultiplyT(this UFMtx3 ufMtx3, double[] mtx1, double[] mtx2, out Matrix3x3 mtx_product)
        {
            ufMtx3.MultiplyT(mtx1, mtx2, out double[] matrix);

            mtx_product = new Matrix3x3
            {
                Xx = matrix[0], Xy = matrix[1], Xz = matrix[2],
                Yx = matrix[3], Yy = matrix[4], Yz = matrix[5],
                Zx = matrix[6], Zy = matrix[7], Zz = matrix[8]
            };
        }

        /// <summary>
        ///     Returns a 3x3 matrix product by transposing the first matrix before
        ///     performing the multiplication.
        /// </summary>
        /// <remarks>
        ///     Refer to <see href="..ugopen_doc/uf_mtx/global.html#UF_MTX3_multiply_t">UF_MTX3_multiply_t</see> for documentation<br/>
        ///     <see href="..mapping/Uf2NxOpenNet.htm">Mapping Help</see><br/>
        ///     License requirements:None
        /// </remarks>
        /// <param name="ufMtx3"></param>
        /// <param name="mtx1">Input Matrix #1 gets transposed before the multiplication.</param>
        /// <param name="mtx2">Input Matrix #2</param>
        /// <param name="mtx_product">Output Matrix product
        ///     mtx_product = trns(mtx1) X mtx2</param>
        public static void MultiplyT(this UFMtx3 ufMtx3, Matrix3x3 mtx1, double[] mtx2, out Matrix3x3 mtx_product) =>
            ufMtx3.MultiplyT(mtx1.ToArray(), mtx2, out mtx_product);

        /// <summary>
        ///     Returns a 3x3 matrix product by transposing the first matrix before
        ///     performing the multiplication.
        /// </summary>
        /// <remarks>
        ///     Refer to <see href="..ugopen_doc/uf_mtx/global.html#UF_MTX3_multiply_t">UF_MTX3_multiply_t</see> for documentation<br/>
        ///     <see href="..mapping/Uf2NxOpenNet.htm">Mapping Help</see><br/>
        ///     License requirements:None
        /// </remarks>
        /// <param name="ufMtx3"></param>
        /// <param name="mtx1">Input Matrix #1 gets transposed before the multiplication.</param>
        /// <param name="mtx2">Input Matrix #2</param>
        /// <param name="mtx_product">Output Matrix product
        ///     mtx_product = trns(mtx1) X mtx2</param>
        public static void MultiplyT(this UFMtx3 ufMtx3, double[] mtx1, Matrix3x3 mtx2, out Matrix3x3 mtx_product) =>
            ufMtx3.MultiplyT(mtx1, mtx2.ToArray(), out mtx_product);

        /// <summary>
        ///     Returns a 3x3 matrix product by transposing the first matrix before
        ///     performing the multiplication.
        /// </summary>
        /// <remarks>
        ///     Refer to <see href="..ugopen_doc/uf_mtx/global.html#UF_MTX3_multiply_t">UF_MTX3_multiply_t</see> for documentation<br/>
        ///     <see href="..mapping/Uf2NxOpenNet.htm">Mapping Help</see><br/>
        ///     License requirements:None
        /// </remarks>
        /// <param name="ufMtx3"></param>
        /// <param name="mtx1">Input Matrix #1 gets transposed before the multiplication.</param>
        /// <param name="mtx2">Input Matrix #2</param>
        /// <param name="mtx_product">Output Matrix product
        ///     mtx_product = trns(mtx1) X mtx2</param>
        public static void MultiplyT(this UFMtx3 ufMtx3, Matrix3x3 mtx1, Matrix3x3 mtx2, out Matrix3x3 mtx_product) =>
            ufMtx3.MultiplyT(mtx1.ToArray(), mtx2.ToArray(), out mtx_product);

        /// <summary>
        ///     Returns a 3x3 matrix whose direction vectors are orthogonal and of
        ///     unit length.
        /// </summary>
        /// <remarks>
        ///     Refer to <see href="..ugopen_doc/uf_mtx/global.html#UF_MTX3_ortho_normalize">UF_MTX3_ortho_normalize</see> for documentation<br/>
        ///     <see href="..mapping/Uf2NxOpenNet.htm">Mapping Help</see><br/>
        ///     License requirements:None
        /// </remarks>
        /// <param name="ufMtx3"></param>
        /// <param name="mtx">Input / Output Matrix to be ortho-normalized. (Input)
        ///     Ortho-normalized matrix. (Output)</param>
        public static void OrthoNormalize(this UFMtx3 ufMtx3, ref Matrix3x3 mtx)
        {
            double[] matrix = mtx.ToArray();

            ufMtx3.OrthoNormalize(matrix);

            mtx = new Matrix3x3
            {
                Xx = matrix[0], Xy = matrix[1], Xz = matrix[2],
                Yx = matrix[3], Yy = matrix[4], Yz = matrix[5],
                Zx = matrix[6], Zy = matrix[7], Zz = matrix[8]
            };
        }

        /// <summary>
        ///     Returns a 3x3 rotation matrix about an axis and through a specified
        ///     angle of rotation.
        /// </summary>
        /// <remarks>
        ///     Refer to <see href="..ugopen_doc/uf_mtx/global.html#UF_MTX3_rotate_about_axis">UF_MTX3_rotate_about_axis</see> for documentation<br/>
        ///     <see href="..mapping/Uf2NxOpenNet.htm">Mapping Help</see><br/>
        ///     License requirements:None
        /// </remarks>
        /// <param name="ufMtx3"></param>
        /// <param name="rotation_axis">Input Vector of the rotation axis</param>
        /// <param name="rotation_angle">Input Angle of the rotation (in radians)</param>
        /// <param name="mtx">Output Rotation Matrix</param>
        public static void RotateAboutAxis(this UFMtx3 ufMtx3, double[] rotation_axis, double rotation_angle,
            out double[] mtx)
        {
            mtx = new double[9];

            ufMtx3.RotateAboutAxis(rotation_axis, rotation_angle, mtx);
        }

        /// <summary>
        ///     Returns a 3x3 rotation matrix about an axis and through a specified
        ///     angle of rotation.
        /// </summary>
        /// <remarks>
        ///     Refer to <see href="..ugopen_doc/uf_mtx/global.html#UF_MTX3_rotate_about_axis">UF_MTX3_rotate_about_axis</see> for documentation<br/>
        ///     <see href="..mapping/Uf2NxOpenNet.htm">Mapping Help</see><br/>
        ///     License requirements:None
        /// </remarks>
        /// <param name="ufMtx3"></param>
        /// <param name="rotation_axis">Input Vector of the rotation axis</param>
        /// <param name="rotation_angle">Input Angle of the rotation (in radians)</param>
        /// <param name="mtx">Output Rotation Matrix</param>
        public static void RotateAboutAxis(this UFMtx3 ufMtx3, double[] rotation_axis, double rotation_angle,
            out Matrix3x3 mtx)
        {
            ufMtx3.RotateAboutAxis(rotation_axis, rotation_angle, out double[] matrix);

            mtx = new Matrix3x3
            {
                Xx = matrix[0], Xy = matrix[1], Xz = matrix[2],
                Yx = matrix[3], Yy = matrix[4], Yz = matrix[5],
                Zx = matrix[6], Zy = matrix[7], Zz = matrix[8]
            };
        }

        /// <summary>
        ///     Returns a 3x3 rotation matrix about an axis and through a specified
        ///     angle of rotation.
        /// </summary>
        /// <remarks>
        ///     Refer to <see href="..ugopen_doc/uf_mtx/global.html#UF_MTX3_rotate_about_axis">UF_MTX3_rotate_about_axis</see> for documentation<br/>
        ///     <see href="..mapping/Uf2NxOpenNet.htm">Mapping Help</see><br/>
        ///     License requirements:None
        /// </remarks>
        /// <param name="ufMtx3"></param>
        /// <param name="rotation_axis">Input Vector of the rotation axis</param>
        /// <param name="rotation_angle">Input Angle of the rotation (in radians)</param>
        /// <param name="mtx">Output Rotation Matrix</param>
        public static void RotateAboutAxis(this UFMtx3 ufMtx3, Vector3d rotation_axis, double rotation_angle,
            out Matrix3x3 mtx) => ufMtx3.RotateAboutAxis(rotation_axis.ToArray(), rotation_angle, out mtx);

        /// <summary>
        ///     Returns the transpose of a 3x3 matrix.
        /// </summary>
        /// <remarks>
        ///     Refer to <see href="..ugopen_doc/uf_mtx/global.html#UF_MTX3_transpose">UF_MTX3_transpose</see> for documentation<br/>
        ///     <see href="..mapping/Uf2NxOpenNet.htm">Mapping Help</see><br/>
        ///     License requirements:None
        /// </remarks>
        /// <param name="ufMtx3"></param>
        /// <param name="mtx">Input Matrix to transpose</param>
        /// <param name="transpose_mtx">Output Transposed matrix
        ///     transpose_mtx = trns(mtx)</param>
        public static void Transpose(this UFMtx3 ufMtx3, double[] mtx, out double[] transpose_mtx)
        {
            transpose_mtx = new double[9];

            ufMtx3.Transpose(mtx, transpose_mtx);
        }

        /// <summary>
        ///     Returns the transpose of a 3x3 matrix.
        /// </summary>
        /// <remarks>
        ///     Refer to <see href="..ugopen_doc/uf_mtx/global.html#UF_MTX3_transpose">UF_MTX3_transpose</see> for documentation<br/>
        ///     <see href="..mapping/Uf2NxOpenNet.htm">Mapping Help</see><br/>
        ///     License requirements:None
        /// </remarks>
        /// <param name="ufMtx3"></param>
        /// <param name="mtx">Input Matrix to transpose</param>
        /// <param name="transpose_mtx">Output Transposed matrix
        ///     transpose_mtx = trns(mtx)</param>
        public static void Transpose(this UFMtx3 ufMtx3, double[] mtx, out Matrix3x3 transpose_mtx)
        {
            ufMtx3.Transpose(mtx, out double[] matrix);

            transpose_mtx = new Matrix3x3
            {
                Xx = matrix[0], Xy = matrix[1], Xz = matrix[2],
                Yx = matrix[3], Yy = matrix[4], Yz = matrix[5],
                Zx = matrix[6], Zy = matrix[7], Zz = matrix[8]
            };
        }

        /// <summary>
        ///     Returns the transpose of a 3x3 matrix.
        /// </summary>
        /// <remarks>
        ///     Refer to <see href="..ugopen_doc/uf_mtx/global.html#UF_MTX3_transpose">UF_MTX3_transpose</see> for documentation<br/>
        ///     <see href="..mapping/Uf2NxOpenNet.htm">Mapping Help</see><br/>
        ///     License requirements:None
        /// </remarks>
        /// <param name="ufMtx3"></param>
        /// <param name="mtx">Input Matrix to transpose</param>
        /// <param name="transpose_mtx">Output Transposed matrix
        ///     transpose_mtx = trns(mtx)</param>
        public static void Transpose(this UFMtx3 ufMtx3, Matrix3x3 mtx, out Matrix3x3 transpose_mtx) =>
            ufMtx3.Transpose(mtx.ToArray(), out transpose_mtx);

        /// <summary>
        ///     Returns a vector which is the product of a 3D vector and a 3x3 matrix.
        /// </summary>
        /// <remarks>
        ///     Refer to <see href="..ugopen_doc/uf_mtx/global.html#UF_MTX3_vec_multiply">UF_MTX3_vec_multiply</see> for documentation<br/>
        ///     <see href="..mapping/Uf2NxOpenNet.htm">Mapping Help</see><br/>
        ///     License requirements:None
        /// </remarks>
        /// <param name="ufMtx3"></param>
        /// <param name="vec">Input Vector to multiply</param>
        /// <param name="mtx">Input Matrix to multiply</param>
        /// <param name="vec_product">Output Product (a vector)
        ///         vec_product = vec X mtx</param>
        public static void VecMultiply(this UFMtx3 ufMtx3, double[] vec, double[] mtx, out double[] vec_product)
        {
            vec_product = new double[3];

            ufMtx3.VecMultiply(vec, mtx, vec_product);
        }

        /// <summary>
        ///     Returns a vector which is the product of a 3D vector and a 3x3 matrix.
        /// </summary>
        /// <remarks>
        ///     Refer to <see href="..ugopen_doc/uf_mtx/global.html#UF_MTX3_vec_multiply">UF_MTX3_vec_multiply</see> for documentation<br/>
        ///     <see href="..mapping/Uf2NxOpenNet.htm">Mapping Help</see><br/>
        ///     License requirements:None
        /// </remarks>
        /// <param name="ufMtx3"></param>
        /// <param name="vec">Input Vector to multiply</param>
        /// <param name="mtx">Input Matrix to multiply</param>
        /// <param name="vec_product">Output Product (a vector)
        ///         vec_product = vec X mtx</param>
        public static void VecMultiply(this UFMtx3 ufMtx3, double[] vec, double[] mtx, out Vector3d vec_product)
        {
            ufMtx3.VecMultiply(vec, mtx, out double[] vector);

            vec_product = new Vector3d (vector[0], vector[1], vector[2]);
        }

        /// <summary>
        ///     Returns a vector which is the product of a 3D vector and a 3x3 matrix.
        /// </summary>
        /// <remarks>
        ///     Refer to <see href="..ugopen_doc/uf_mtx/global.html#UF_MTX3_vec_multiply">UF_MTX3_vec_multiply</see> for documentation<br/>
        ///     <see href="..mapping/Uf2NxOpenNet.htm">Mapping Help</see><br/>
        ///     License requirements:None
        /// </remarks>
        /// <param name="ufMtx3"></param>
        /// <param name="vec">Input Vector to multiply</param>
        /// <param name="mtx">Input Matrix to multiply</param>
        /// <param name="vec_product">Output Product (a vector)
        ///         vec_product = vec X mtx</param>
        public static void VecMultiply(this UFMtx3 ufMtx3, Vector3d vec, double[] mtx, out Vector3d vec_product) =>
            ufMtx3.VecMultiply(vec.ToArray(), mtx, out vec_product);

        /// <summary>
        ///     Returns a vector which is the product of a 3D vector and a 3x3 matrix.
        /// </summary>
        /// <remarks>
        ///     Refer to <see href="..ugopen_doc/uf_mtx/global.html#UF_MTX3_vec_multiply">UF_MTX3_vec_multiply</see> for documentation<br/>
        ///     <see href="..mapping/Uf2NxOpenNet.htm">Mapping Help</see><br/>
        ///     License requirements:None
        /// </remarks>
        /// <param name="ufMtx3"></param>
        /// <param name="vec">Input Vector to multiply</param>
        /// <param name="mtx">Input Matrix to multiply</param>
        /// <param name="vec_product">Output Product (a vector)
        ///         vec_product = vec X mtx</param>
        public static void VecMultiply(this UFMtx3 ufMtx3, double[] vec, Matrix3x3 mtx, out Vector3d vec_product) =>
            ufMtx3.VecMultiply(vec, mtx.ToArray(), out vec_product);

        /// <summary>
        ///     Returns a vector which is the product of a 3D vector and a 3x3 matrix.
        /// </summary>
        /// <remarks>
        ///     Refer to <see href="..ugopen_doc/uf_mtx/global.html#UF_MTX3_vec_multiply">UF_MTX3_vec_multiply</see> for documentation<br/>
        ///     <see href="..mapping/Uf2NxOpenNet.htm">Mapping Help</see><br/>
        ///     License requirements:None
        /// </remarks>
        /// <param name="ufMtx3"></param>
        /// <param name="vec">Input Vector to multiply</param>
        /// <param name="mtx">Input Matrix to multiply</param>
        /// <param name="vec_product">Output Product (a vector)
        ///         vec_product = vec X mtx</param>
        public static void VecMultiply(this UFMtx3 ufMtx3, Vector3d vec, Matrix3x3 mtx, out Vector3d vec_product) =>
            ufMtx3.VecMultiply(vec.ToArray(), mtx.ToArray(), out vec_product);

        /// <summary>
        ///     Returns a vector which is the product of a 3D vector and a transposed
        ///     3x3 matrix.
        /// </summary>
        /// <remarks>
        ///     Refer to <see href="..ugopen_doc/uf_mtx/global.html#UF_MTX3_vec_multiply_t">UF_MTX3_vec_multiply_t</see> for documentation<br/>
        ///     <see href="..mapping/Uf2NxOpenNet.htm">Mapping Help</see><br/>
        ///     License requirements:None
        /// </remarks>
        /// <param name="ufMtx3"></param>
        /// <param name="vec">Input Vector to multiply</param>
        /// <param name="mtx">Input Matrix to transpose and multiply</param>
        /// <param name="vec_product">Output Product (a vector)
        ///         vec_product = vec X trns(mtx)</param>
        public static void VecMultiplyT(this UFMtx3 ufMtx3, double[] vec, double[] mtx, out double[] vec_product)
        {
            vec_product = new double[3];

            ufMtx3.VecMultiplyT(vec, mtx, vec_product);
        }

        /// <summary>
        ///     Returns a vector which is the product of a 3D vector and a transposed
        ///     3x3 matrix.
        /// </summary>
        /// <remarks>
        ///     Refer to <see href="..ugopen_doc/uf_mtx/global.html#UF_MTX3_vec_multiply_t">UF_MTX3_vec_multiply_t</see> for documentation<br/>
        ///     <see href="..mapping/Uf2NxOpenNet.htm">Mapping Help</see><br/>
        ///     License requirements:None
        /// </remarks>
        /// <param name="ufMtx3"></param>
        /// <param name="vec">Input Vector to multiply</param>
        /// <param name="mtx">Input Matrix to transpose and multiply</param>
        /// <param name="vec_product">Output Product (a vector)
        ///         vec_product = vec X trns(mtx)</param>
        public static void VecMultiplyT(this UFMtx3 ufMtx3, double[] vec, double[] mtx, out Vector3d vec_product)
        {
            ufMtx3.VecMultiplyT(vec, mtx, out double[] vector);

            vec_product = new Vector3d(vector[0], vector[1], vector[2]);
        }

        /// <summary>
        ///     Returns a vector which is the product of a 3D vector and a transposed
        ///     3x3 matrix.
        /// </summary>
        /// <remarks>
        ///     Refer to <see href="..ugopen_doc/uf_mtx/global.html#UF_MTX3_vec_multiply_t">UF_MTX3_vec_multiply_t</see> for documentation<br/>
        ///     <see href="..mapping/Uf2NxOpenNet.htm">Mapping Help</see><br/>
        ///     License requirements:None
        /// </remarks>
        /// <param name="ufMtx3"></param>
        /// <param name="vec">Input Vector to multiply</param>
        /// <param name="mtx">Input Matrix to transpose and multiply</param>
        /// <param name="vec_product">Output Product (a vector)
        ///         vec_product = vec X trns(mtx)</param>
        public static void VecMultiplyT(this UFMtx3 ufMtx3, Vector3d vec, double[] mtx, out Vector3d vec_product) =>
            ufMtx3.VecMultiplyT(vec.ToArray(), mtx, out vec_product);

        /// <summary>
        ///     Returns a vector which is the product of a 3D vector and a transposed
        ///     3x3 matrix.
        /// </summary>
        /// <remarks>
        ///     Refer to <see href="..ugopen_doc/uf_mtx/global.html#UF_MTX3_vec_multiply_t">UF_MTX3_vec_multiply_t</see> for documentation<br/>
        ///     <see href="..mapping/Uf2NxOpenNet.htm">Mapping Help</see><br/>
        ///     License requirements:None
        /// </remarks>
        /// <param name="ufMtx3"></param>
        /// <param name="vec">Input Vector to multiply</param>
        /// <param name="mtx">Input Matrix to transpose and multiply</param>
        /// <param name="vec_product">Output Product (a vector)
        ///         vec_product = vec X trns(mtx)</param>
        public static void VecMultiplyT(this UFMtx3 ufMtx3, double[] vec, Matrix3x3 mtx, out Vector3d vec_product) =>
            ufMtx3.VecMultiplyT(vec, mtx.ToArray(), out vec_product);

        /// <summary>
        ///     Returns a vector which is the product of a 3D vector and a transposed
        ///     3x3 matrix.
        /// </summary>
        /// <remarks>
        ///     Refer to <see href="..ugopen_doc/uf_mtx/global.html#UF_MTX3_vec_multiply_t">UF_MTX3_vec_multiply_t</see> for documentation<br/>
        ///     <see href="..mapping/Uf2NxOpenNet.htm">Mapping Help</see><br/>
        ///     License requirements:None
        /// </remarks>
        /// <param name="ufMtx3"></param>
        /// <param name="vec">Input Vector to multiply</param>
        /// <param name="mtx">Input Matrix to transpose and multiply</param>
        /// <param name="vec_product">Output Product (a vector)
        ///         vec_product = vec X trns(mtx)</param>
        public static void VecMultiplyT(this UFMtx3 ufMtx3, Vector3d vec, Matrix3x3 mtx, out Vector3d vec_product) =>
            ufMtx3.VecMultiplyT(vec.ToArray(), mtx.ToArray(), out vec_product);

        /// <summary>
        ///     Returns the X-direction vector of a matrix.
        /// </summary>
        /// <remarks>
        ///     Refer to <see href="..ugopen_doc/uf_mtx/global.html#UF_MTX3_x_vec">UF_MTX3_x_vec</see> for documentation<br/>
        ///     <see href="..mapping/Uf2NxOpenNet.htm">Mapping Help</see><br/>
        ///     License requirements:None
        /// </remarks>
        /// <param name="ufMtx3"></param>
        /// <param name="mtx">Input 3x3 Matrix whose X-direction is required</param>
        /// <param name="x_vec">Output X-direction vector of the matrix</param>
        public static void XVec(this UFMtx3 ufMtx3, double[] mtx, out double[] x_vec)
        {
            x_vec = new double[3];

            ufMtx3.XVec(mtx, x_vec);
        }

        /// <summary>
        ///     Returns the X-direction vector of a matrix.
        /// </summary>
        /// <remarks>
        ///     Refer to <see href="..ugopen_doc/uf_mtx/global.html#UF_MTX3_x_vec">UF_MTX3_x_vec</see> for documentation<br/>
        ///     <see href="..mapping/Uf2NxOpenNet.htm">Mapping Help</see><br/>
        ///     License requirements:None
        /// </remarks>
        /// <param name="ufMtx3"></param>
        /// <param name="mtx">Input 3x3 Matrix whose X-direction is required</param>
        /// <param name="x_vec">Output X-direction vector of the matrix</param>
        public static void XVec(this UFMtx3 ufMtx3, double[] mtx, out Vector3d x_vec)
        {
            ufMtx3.XVec(mtx, out double[] vector);

            x_vec = new Vector3d(vector[0], vector[1], vector[2]);
        }

        /// <summary>
        ///     Returns the X-direction vector of a matrix.
        /// </summary>
        /// <remarks>
        ///     Refer to <see href="..ugopen_doc/uf_mtx/global.html#UF_MTX3_x_vec">UF_MTX3_x_vec</see> for documentation<br/>
        ///     <see href="..mapping/Uf2NxOpenNet.htm">Mapping Help</see><br/>
        ///     License requirements:None
        /// </remarks>
        /// <param name="ufMtx3"></param>
        /// <param name="mtx">Input 3x3 Matrix whose X-direction is required</param>
        /// <param name="x_vec">Output X-direction vector of the matrix</param>
        public static void XVec(this UFMtx3 ufMtx3, Matrix3x3 mtx, out Vector3d x_vec) =>
            ufMtx3.XVec(mtx.ToArray(), out x_vec);

        /// <summary>
        ///     Returns the Y-direction vector of a matrix.
        /// </summary>
        /// <remarks>
        ///     Refer to <see href="..ugopen_doc/uf_mtx/global.html#UF_MTX3_y_vec">UF_MTX3_y_vec</see> for documentation<br/>
        ///     <see href="..mapping/Uf2NxOpenNet.htm">Mapping Help</see><br/>
        ///     License requirements:None
        /// </remarks>
        /// <param name="ufMtx3"></param>
        /// <param name="mtx">Input 3x3 Matrix whose Y-direction is required</param>
        /// <param name="y_vec">Output Y-direction vector of the matrix</param>
        public static void YVec(this UFMtx3 ufMtx3, double[] mtx, out double[] y_vec)
        {
            y_vec = new double[3];

            ufMtx3.YVec(mtx, y_vec);
        }

        /// <summary>
        ///     Returns the Y-direction vector of a matrix.
        /// </summary>
        /// <remarks>
        ///     Refer to <see href="..ugopen_doc/uf_mtx/global.html#UF_MTX3_y_vec">UF_MTX3_y_vec</see> for documentation<br/>
        ///     <see href="..mapping/Uf2NxOpenNet.htm">Mapping Help</see><br/>
        ///     License requirements:None
        /// </remarks>
        /// <param name="ufMtx3"></param>
        /// <param name="mtx">Input 3x3 Matrix whose Y-direction is required</param>
        /// <param name="y_vec">Output Y-direction vector of the matrix</param>
        public static void YVec(this UFMtx3 ufMtx3, double[] mtx, out Vector3d y_vec)
        {
            ufMtx3.YVec(mtx, out double[] vector);

            y_vec = new Vector3d(vector[0], vector[1], vector[2]);
        }

        /// <summary>
        ///     Returns the Y-direction vector of a matrix.
        /// </summary>
        /// <remarks>
        ///     Refer to <see href="..ugopen_doc/uf_mtx/global.html#UF_MTX3_y_vec">UF_MTX3_y_vec</see> for documentation<br/>
        ///     <see href="..mapping/Uf2NxOpenNet.htm">Mapping Help</see><br/>
        ///     License requirements:None
        /// </remarks>
        /// <param name="ufMtx3"></param>
        /// <param name="mtx">Input 3x3 Matrix whose Y-direction is required</param>
        /// <param name="y_vec">Output Y-direction vector of the matrix</param>
        public static void YVec(this UFMtx3 ufMtx3, Matrix3x3 mtx, out Vector3d y_vec) =>
            ufMtx3.YVec(mtx.ToArray(), out y_vec);

        /// <summary>
        ///     Returns the Z-direction vector of a matrix.
        /// </summary>
        /// <remarks>
        ///     Refer to <see href="..ugopen_doc/uf_mtx/global.html#UF_MTX3_z_vec">UF_MTX3_z_vec</see> for documentation<br/>
        ///     <see href="..mapping/Uf2NxOpenNet.htm">Mapping Help</see><br/>
        ///     License requirements:None
        /// </remarks>
        /// <param name="ufMtx3"></param>
        /// <param name="mtx">Input 3x3 Matrix whose Z-direction is required</param>
        /// <param name="z_vec">Output Z-direction vector of the matrix</param>
        public static void ZVec(this UFMtx3 ufMtx3, double[] mtx, out double[] z_vec)
        {
            z_vec = new double[3];

            ufMtx3.ZVec(mtx, z_vec);
        }

        /// <summary>
        ///     Returns the Z-direction vector of a matrix.
        /// </summary>
        /// <remarks>
        ///     Refer to <see href="..ugopen_doc/uf_mtx/global.html#UF_MTX3_z_vec">UF_MTX3_z_vec</see> for documentation<br/>
        ///     <see href="..mapping/Uf2NxOpenNet.htm">Mapping Help</see><br/>
        ///     License requirements:None
        /// </remarks>
        /// <param name="ufMtx3"></param>
        /// <param name="mtx">Input 3x3 Matrix whose Z-direction is required</param>
        /// <param name="z_vec">Output Z-direction vector of the matrix</param>
        public static void ZVec(this UFMtx3 ufMtx3, double[] mtx, out Vector3d z_vec)
        {
            ufMtx3.ZVec(mtx, out double[] vector);

            z_vec = new Vector3d(vector[0], vector[1], vector[2]);
        }

        /// <summary>
        ///     Returns the Z-direction vector of a matrix.
        /// </summary>
        /// <remarks>
        ///     Refer to <see href="..ugopen_doc/uf_mtx/global.html#UF_MTX3_z_vec">UF_MTX3_z_vec</see> for documentation<br/>
        ///     <see href="..mapping/Uf2NxOpenNet.htm">Mapping Help</see><br/>
        ///     License requirements:None
        /// </remarks>
        /// <param name="ufMtx3"></param>
        /// <param name="mtx">Input 3x3 Matrix whose Z-direction is required</param>
        /// <param name="z_vec">Output Z-direction vector of the matrix</param>
        public static void ZVec(this UFMtx3 ufMtx3, Matrix3x3 mtx, out Vector3d z_vec) =>
            ufMtx3.ZVec(mtx.ToArray(), out z_vec);
    }
}
