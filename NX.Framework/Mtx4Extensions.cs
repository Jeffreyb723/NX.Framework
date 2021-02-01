using NXOpen;
using NXOpen.UF;

namespace NX.Framework
{
    public static class Mtx4Extensions
    {
        /// <summary>
        ///     Returns the 3x3 rotation matrix of a 4x4 matrix.
        /// </summary>
        /// <remarks>
        ///     Refer to <see href="..ugopen_doc/uf_mtx/global.html#UF_MTX4_ask_rotation">UF_MTX4_ask_rotation for documentation</see><br/>
        ///     <see href="..mapping/Uf2NxOpenNet.htm">Mapping Help</see><br/>
        ///     License requirements:None
        /// </remarks>
        /// <param name="ufMtx4"></param>
        /// <param name="mtx">Input 4x4 matrix whose rotation is required</param>
        /// <param name="mtx_3D">Output 3x3 rotation matrix of the 4x4 matrix</param>
        public static void AskRotation(this UFMtx4 ufMtx4, double[] mtx, out double[] mtx_3D)
        {
            mtx_3D = new double[9];
            ufMtx4.AskRotation(mtx, mtx_3D);
        }

        /// <summary>
        ///     Returns the 3x3 rotation matrix of a 4x4 matrix.
        /// </summary>
        /// <remarks>
        ///     Refer to <see href="..ugopen_doc/uf_mtx/global.html#UF_MTX4_ask_rotation">UF_MTX4_ask_rotation for documentation</see><br/>
        ///     <see href="..mapping/Uf2NxOpenNet.htm">Mapping Help</see><br/>
        ///     License requirements:None
        /// </remarks>
        /// <param name="ufMtx4"></param>
        /// <param name="mtx">Input 4x4 matrix whose rotation is required</param>
        /// <param name="mtx_3D">Output 3x3 rotation matrix of the 4x4 matrix</param>
        public static void AskRotation(this UFMtx4 ufMtx4, double[] mtx, out Matrix3x3 mtx_3D)
        {
            ufMtx4.AskRotation(mtx, out double[] matrix);

            mtx_3D = new Matrix3x3
            {
                Xx = matrix[0], Xy = matrix[1], Xz = matrix[2],
                Yx = matrix[3], Yy = matrix[4], Yz = matrix[5],
                Zx = matrix[6], Zy = matrix[7], Zz = matrix[8]
            };
        }

        /// <summary>
        ///     Returns the 3x3 rotation matrix of a 4x4 matrix.
        /// </summary>
        /// <remarks>
        ///     Refer to <see href="..ugopen_doc/uf_mtx/global.html#UF_MTX4_ask_rotation">UF_MTX4_ask_rotation for documentation</see><br/>
        ///     <see href="..mapping/Uf2NxOpenNet.htm">Mapping Help</see><br/>
        ///     License requirements:None
        /// </remarks>
        /// <param name="ufMtx4"></param>
        /// <param name="mtx">Input 4x4 matrix whose rotation is required</param>
        /// <param name="mtx_3D">Output 3x3 rotation matrix of the 4x4 matrix</param>
        public static void AskRotation(this UFMtx4 ufMtx4, Matrix4x4 mtx, out Matrix3x3 mtx_3D) =>
            ufMtx4.AskRotation(mtx.ToArray(), out mtx_3D);

        /// <summary>
        ///     Returns the scale factor of a 4x4 matrix.
        /// Mapping
        /// </summary>
        /// <remarks>
        ///     Refer to <see href="..ugopen_doc/uf_mtx/global.html#UF_MTX4_ask_scale">UF_MTX4_ask_scale</see> for documentation<br/>
        ///     <see href="..mapping/Uf2NxOpenNet.htm">Mapping Help</see><br/>
        ///     License requirements:None
        /// </remarks>
        /// <param name="ufMtx4"></param>
        /// <param name="mtx">Input Matrix whose scale is required.</param>
        /// <param name="scale">Output Scale factor of the matrix</param>
        public static void AskScale(this UFMtx4 ufMtx4, Matrix4x4 mtx, out double scale) =>
            ufMtx4.AskScale(mtx.ToArray(), out scale);

        /// <summary>
        ///     Returns the translation vector of a 4x4 matrix.
        /// Mapping
        /// </summary>
        /// <remarks>
        ///     Refer to <see href="..ugopen_doc/uf_mtx/global.html#UF_MTX4_ask_translation">UF_MTX4_ask_translation</see> for documentation<br/>
        ///     <see href="..mapping/Uf2NxOpenNet.htm">Mapping Help</see><br/>
        ///     License requirements:None
        /// </remarks>
        /// <param name="ufMtx4"></param>
        /// <param name="mtx">Input Matrix whose translation is required.</param>
        /// <param name="translate_vec">Output Translation vector of the matrix</param>
        public static void AskTranslation(this UFMtx4 ufMtx4, double[] mtx, out double[] translate_vec)
        {
            translate_vec = new double[3];
            ufMtx4.AskRotation(mtx, translate_vec);
        }

        /// <summary>
        ///     Returns the translation vector of a 4x4 matrix.
        /// Mapping
        /// </summary>
        /// <remarks>
        ///     Refer to <see href="..ugopen_doc/uf_mtx/global.html#UF_MTX4_ask_translation">UF_MTX4_ask_translation</see> for documentation<br/>
        ///     <see href="..mapping/Uf2NxOpenNet.htm">Mapping Help</see><br/>
        ///     License requirements:None
        /// </remarks>
        /// <param name="ufMtx4"></param>
        /// <param name="mtx">Input Matrix whose translation is required.</param>
        /// <param name="translate_vec">Output Translation vector of the matrix</param>
        public static void AskTranslation(this UFMtx4 ufMtx4, double[] mtx, out Vector3d translate_vec)
        {
            ufMtx4.AskTranslation(mtx, out double[] vector);
            translate_vec = new Vector3d(vector[0], vector[1], vector[2]);
        }

        /// <summary>
        ///     Returns the translation vector of a 4x4 matrix.
        /// Mapping
        /// </summary>
        /// <remarks>
        ///     Refer to <see href="..ugopen_doc/uf_mtx/global.html#UF_MTX4_ask_translation">UF_MTX4_ask_translation</see> for documentation<br/>
        ///     <see href="..mapping/Uf2NxOpenNet.htm">Mapping Help</see><br/>
        ///     License requirements:None
        /// </remarks>
        /// <param name="ufMtx4"></param>
        /// <param name="mtx">Input Matrix whose translation is required.</param>
        /// <param name="translate_vec">Output Translation vector of the matrix</param>
        public static void AskTranslation(this UFMtx4 ufMtx4, Matrix4x4 mtx, out Vector3d translate_vec) =>
            ufMtx4.AskTranslation(mtx.ToArray(), out translate_vec);

        /// <summary>
        ///     Copies 4x4 matrix elements from the source matrix to the destination
        ///     matrix.
        /// </summary>
        /// <remarks>
        ///     Refer to <see href="..ugopen_doc/uf_mtx/global.html#UF_MTX4_copy">UF_MTX4_copy</see> for documentation<br/>
        ///     <see href="..mapping/Uf2NxOpenNet.htm">Mapping Help</see><br/>
        ///     License requirements:None
        /// </remarks>
        /// <param name="ufMtx4"></param>
        /// <param name="mtx_src">Input Source matrix</param>
        /// <param name="mtx_dst">Output Destination matrix
        ///     mtx_dst = mtx_src </param>
        public static void Copy(this UFMtx4 ufMtx4, double[] mtx_src, out double[] mtx_dst)
        {
            mtx_dst = new double[16];
            ufMtx4.Copy(mtx_src, mtx_dst);
        }

        /// <summary>
        ///     Copies 4x4 matrix elements from the source matrix to the destination
        ///     matrix.
        /// </summary>
        /// <remarks>
        ///     Refer to <see href="..ugopen_doc/uf_mtx/global.html#UF_MTX4_copy">UF_MTX4_copy</see> for documentation<br/>
        ///     <see href="..mapping/Uf2NxOpenNet.htm">Mapping Help</see><br/>
        ///     License requirements:None
        /// </remarks>
        /// <param name="ufMtx4"></param>
        /// <param name="mtx_src">Input Source matrix</param>
        /// <param name="mtx_dst">Output Destination matrix
        ///     mtx_dst = mtx_src </param>
        public static void Copy(this UFMtx4 ufMtx4, double[] mtx_src, out Matrix4x4 mtx_dst)
        {
            ufMtx4.Copy(mtx_src, out double[] matrix);

            mtx_dst = new Matrix4x4
            (
                matrix[0], matrix[1], matrix[2], matrix[3], matrix[4], matrix[5], matrix[6], matrix[7],
                matrix[8], matrix[9], matrix[10], matrix[11], matrix[12], matrix[13], matrix[14], matrix[15]
            );
        }

        /// <summary>
        ///     Copies 4x4 matrix elements from the source matrix to the destination
        ///     matrix.
        /// </summary>
        /// <remarks>
        ///     Refer to <see href="..ugopen_doc/uf_mtx/global.html#UF_MTX4_copy">UF_MTX4_copy</see> for documentation<br/>
        ///     <see href="..mapping/Uf2NxOpenNet.htm">Mapping Help</see><br/>
        ///     License requirements:None
        /// </remarks>
        /// <param name="ufMtx4"></param>
        /// <param name="mtx_src">Input Source matrix</param>
        /// <param name="mtx_dst">Output Destination matrix
        ///     mtx_dst = mtx_src </param>
        public static void Copy(this UFMtx4 ufMtx4, Matrix4x4 mtx_src, out Matrix4x4 mtx_dst) =>
            ufMtx4.Copy(mtx_src.ToArray(), out mtx_dst);

        /// <summary>
        ///     Returns the matrix which can be used to map from one csys to another.
        /// </summary>
        /// <remarks>
        ///     Refer to <see href="..ugopen_doc/uf_mtx/global.html#UF_MTX4_csys_to_csys">UF_MTX4_csys_to_csys</see> for documentation<br/>
        ///     <see href="..mapping/Uf2NxOpenNet.htm">Mapping Help</see><br/>
        ///     License requirements:None
        /// </remarks>
        /// <param name="ufMtx4"></param>
        /// <param name="from_origin">Input origin of csys to map from</param>
        /// <param name="from_x_axis">Input x axis of csys to map from</param>
        /// <param name="from_y_axis">Input y axis of csys to map from</param>
        /// <param name="to_origin">Input origin of csys to map to</param>
        /// <param name="to_x_axis">Input x axis of csys to map to</param>
        /// <param name="to_y_axis">Input y axis of csys to map to</param>
        /// <param name="mtx">Output Returned matrix that can be used to
        ///     transform objects</param>
        public static void CsysToCsys(this UFMtx4 ufMtx4, double[] from_origin, double[] from_x_axis,
            double[] from_y_axis, double[] to_origin, double[] to_x_axis, double[] to_y_axis, out double[] mtx)
        {
            mtx = new double[16];
            ufMtx4.CsysToCsys(from_origin, from_x_axis, from_y_axis, to_origin, to_x_axis, to_y_axis, mtx);
        }

        /// <summary>
            ///     Returns the matrix which can be used to map from one csys to another.
            /// </summary>
            /// <remarks>
            ///     Refer to <see href="..ugopen_doc/uf_mtx/global.html#UF_MTX4_csys_to_csys">UF_MTX4_csys_to_csys</see> for documentation<br/>
            ///     <see href="..mapping/Uf2NxOpenNet.htm">Mapping Help</see><br/>
            ///     License requirements:None
            /// </remarks>
            /// <param name="ufMtx4"></param>
            /// <param name="from_origin">Input origin of csys to map from</param>
            /// <param name="from_x_axis">Input x axis of csys to map from</param>
            /// <param name="from_y_axis">Input y axis of csys to map from</param>
            /// <param name="to_origin">Input origin of csys to map to</param>
            /// <param name="to_x_axis">Input x axis of csys to map to</param>
            /// <param name="to_y_axis">Input y axis of csys to map to</param>
            /// <param name="mtx">Output Returned matrix that can be used to
            ///     transform objects</param>
        public static void CsysToCsys(this UFMtx4 ufMtx4, double[] from_origin, double[] from_x_axis,
            double[] from_y_axis, double[] to_origin, double[] to_x_axis, double[] to_y_axis, out Matrix4x4 mtx)
        {
            ufMtx4.CsysToCsys(from_origin, from_x_axis, from_y_axis, to_origin, to_x_axis, to_y_axis, out double[] matrix);

            mtx = new Matrix4x4(matrix[0], matrix[1], matrix[2], matrix[3], matrix[4], matrix[5], matrix[6], matrix[7],
                matrix[8], matrix[9], matrix[10], matrix[11], matrix[12], matrix[13], matrix[14], matrix[15]);
        }

        /// <summary>
        ///     Returns the matrix which can be used to map from one csys to another.
        /// </summary>
        /// <remarks>
        ///     Refer to <see href="..ugopen_doc/uf_mtx/global.html#UF_MTX4_csys_to_csys">UF_MTX4_csys_to_csys</see> for documentation<br/>
        ///     <see href="..mapping/Uf2NxOpenNet.htm">Mapping Help</see><br/>
        ///     License requirements:None
        /// </remarks>
        /// <param name="ufMtx4"></param>
        /// <param name="from_origin">Input origin of csys to map from</param>
        /// <param name="from_x_axis">Input x axis of csys to map from</param>
        /// <param name="from_y_axis">Input y axis of csys to map from</param>
        /// <param name="to_origin">Input origin of csys to map to</param>
        /// <param name="to_x_axis">Input x axis of csys to map to</param>
        /// <param name="to_y_axis">Input y axis of csys to map to</param>
        /// <param name="mtx">Output Returned matrix that can be used to
        ///     transform objects</param>
        public static void CsysToCsys(this UFMtx4 ufMtx4, Point3d from_origin, double[] from_x_axis,
            double[] from_y_axis, double[] to_origin, double[] to_x_axis, double[] to_y_axis, out Matrix4x4 mtx) =>
            ufMtx4.CsysToCsys(from_origin.ToArray(), from_x_axis, from_y_axis, to_origin, to_x_axis, to_y_axis,
                out mtx);

        /// <summary>
        ///     Returns the matrix which can be used to map from one csys to another.
        /// </summary>
        /// <remarks>
        ///     Refer to <see href="..ugopen_doc/uf_mtx/global.html#UF_MTX4_csys_to_csys">UF_MTX4_csys_to_csys</see> for documentation<br/>
        ///     <see href="..mapping/Uf2NxOpenNet.htm">Mapping Help</see><br/>
        ///     License requirements:None
        /// </remarks>
        /// <param name="ufMtx4"></param>
        /// <param name="from_origin">Input origin of csys to map from</param>
        /// <param name="from_x_axis">Input x axis of csys to map from</param>
        /// <param name="from_y_axis">Input y axis of csys to map from</param>
        /// <param name="to_origin">Input origin of csys to map to</param>
        /// <param name="to_x_axis">Input x axis of csys to map to</param>
        /// <param name="to_y_axis">Input y axis of csys to map to</param>
        /// <param name="mtx">Output Returned matrix that can be used to
        ///     transform objects</param>
        public static void CsysToCsys(this UFMtx4 ufMtx4, double[] from_origin, Vector3d from_x_axis,
            double[] from_y_axis, double[] to_origin, double[] to_x_axis, double[] to_y_axis, out Matrix4x4 mtx) =>
            ufMtx4.CsysToCsys(from_origin, from_x_axis.ToArray(), from_y_axis, to_origin, to_x_axis, to_y_axis,
                out mtx);

        /// <summary>
        ///     Returns the matrix which can be used to map from one csys to another.
        /// </summary>
        /// <remarks>
        ///     Refer to <see href="..ugopen_doc/uf_mtx/global.html#UF_MTX4_csys_to_csys">UF_MTX4_csys_to_csys</see> for documentation<br/>
        ///     <see href="..mapping/Uf2NxOpenNet.htm">Mapping Help</see><br/>
        ///     License requirements:None
        /// </remarks>
        /// <param name="ufMtx4"></param>
        /// <param name="from_origin">Input origin of csys to map from</param>
        /// <param name="from_x_axis">Input x axis of csys to map from</param>
        /// <param name="from_y_axis">Input y axis of csys to map from</param>
        /// <param name="to_origin">Input origin of csys to map to</param>
        /// <param name="to_x_axis">Input x axis of csys to map to</param>
        /// <param name="to_y_axis">Input y axis of csys to map to</param>
        /// <param name="mtx">Output Returned matrix that can be used to
        ///     transform objects</param>
        public static void CsysToCsys(this UFMtx4 ufMtx4, Point3d from_origin, Vector3d from_x_axis,
            double[] from_y_axis, double[] to_origin, double[] to_x_axis, double[] to_y_axis, out Matrix4x4 mtx) =>
            ufMtx4.CsysToCsys(from_origin.ToArray(), from_x_axis.ToArray(), from_y_axis, to_origin, to_x_axis,
                to_y_axis, out mtx);

        /// <summary>
        ///     Returns the matrix which can be used to map from one csys to another.
        /// </summary>
        /// <remarks>
        ///     Refer to <see href="..ugopen_doc/uf_mtx/global.html#UF_MTX4_csys_to_csys">UF_MTX4_csys_to_csys</see> for documentation<br/>
        ///     <see href="..mapping/Uf2NxOpenNet.htm">Mapping Help</see><br/>
        ///     License requirements:None
        /// </remarks>
        /// <param name="ufMtx4"></param>
        /// <param name="from_origin">Input origin of csys to map from</param>
        /// <param name="from_x_axis">Input x axis of csys to map from</param>
        /// <param name="from_y_axis">Input y axis of csys to map from</param>
        /// <param name="to_origin">Input origin of csys to map to</param>
        /// <param name="to_x_axis">Input x axis of csys to map to</param>
        /// <param name="to_y_axis">Input y axis of csys to map to</param>
        /// <param name="mtx">Output Returned matrix that can be used to
        ///     transform objects</param>
        public static void CsysToCsys(this UFMtx4 ufMtx4, double[] from_origin, double[] from_x_axis,
            Vector3d from_y_axis, double[] to_origin, double[] to_x_axis, double[] to_y_axis, out Matrix4x4 mtx) =>
            ufMtx4.CsysToCsys(from_origin, from_x_axis, from_y_axis.ToArray(), to_origin, to_x_axis, to_y_axis,
                out mtx);

        /// <summary>
        ///     Returns the matrix which can be used to map from one csys to another.
        /// </summary>
        /// <remarks>
        ///     Refer to <see href="..ugopen_doc/uf_mtx/global.html#UF_MTX4_csys_to_csys">UF_MTX4_csys_to_csys</see> for documentation<br/>
        ///     <see href="..mapping/Uf2NxOpenNet.htm">Mapping Help</see><br/>
        ///     License requirements:None
        /// </remarks>
        /// <param name="ufMtx4"></param>
        /// <param name="from_origin">Input origin of csys to map from</param>
        /// <param name="from_x_axis">Input x axis of csys to map from</param>
        /// <param name="from_y_axis">Input y axis of csys to map from</param>
        /// <param name="to_origin">Input origin of csys to map to</param>
        /// <param name="to_x_axis">Input x axis of csys to map to</param>
        /// <param name="to_y_axis">Input y axis of csys to map to</param>
        /// <param name="mtx">Output Returned matrix that can be used to
        ///     transform objects</param>
        public static void CsysToCsys(this UFMtx4 ufMtx4, Point3d from_origin, double[] from_x_axis,
            Vector3d from_y_axis, double[] to_origin, double[] to_x_axis, double[] to_y_axis, out Matrix4x4 mtx) =>
            ufMtx4.CsysToCsys(from_origin.ToArray(), from_x_axis, from_y_axis.ToArray(), to_origin, to_x_axis,
                to_y_axis, out mtx);

        /// <summary>
        ///     Returns the matrix which can be used to map from one csys to another.
        /// </summary>
        /// <remarks>
        ///     Refer to <see href="..ugopen_doc/uf_mtx/global.html#UF_MTX4_csys_to_csys">UF_MTX4_csys_to_csys</see> for documentation<br/>
        ///     <see href="..mapping/Uf2NxOpenNet.htm">Mapping Help</see><br/>
        ///     License requirements:None
        /// </remarks>
        /// <param name="ufMtx4"></param>
        /// <param name="from_origin">Input origin of csys to map from</param>
        /// <param name="from_x_axis">Input x axis of csys to map from</param>
        /// <param name="from_y_axis">Input y axis of csys to map from</param>
        /// <param name="to_origin">Input origin of csys to map to</param>
        /// <param name="to_x_axis">Input x axis of csys to map to</param>
        /// <param name="to_y_axis">Input y axis of csys to map to</param>
        /// <param name="mtx">Output Returned matrix that can be used to
        ///     transform objects</param>
        public static void CsysToCsys(this UFMtx4 ufMtx4, double[] from_origin, Vector3d from_x_axis,
            Vector3d from_y_axis, double[] to_origin, double[] to_x_axis, double[] to_y_axis, out Matrix4x4 mtx) =>
            ufMtx4.CsysToCsys(from_origin, from_x_axis.ToArray(), from_y_axis.ToArray(), to_origin, to_x_axis,
                to_y_axis, out mtx);

        /// <summary>
        ///     Returns the matrix which can be used to map from one csys to another.
        /// </summary>
        /// <remarks>
        ///     Refer to <see href="..ugopen_doc/uf_mtx/global.html#UF_MTX4_csys_to_csys">UF_MTX4_csys_to_csys</see> for documentation<br/>
        ///     <see href="..mapping/Uf2NxOpenNet.htm">Mapping Help</see><br/>
        ///     License requirements:None
        /// </remarks>
        /// <param name="ufMtx4"></param>
        /// <param name="from_origin">Input origin of csys to map from</param>
        /// <param name="from_x_axis">Input x axis of csys to map from</param>
        /// <param name="from_y_axis">Input y axis of csys to map from</param>
        /// <param name="to_origin">Input origin of csys to map to</param>
        /// <param name="to_x_axis">Input x axis of csys to map to</param>
        /// <param name="to_y_axis">Input y axis of csys to map to</param>
        /// <param name="mtx">Output Returned matrix that can be used to
        ///     transform objects</param>
        public static void CsysToCsys(this UFMtx4 ufMtx4, Point3d from_origin, Vector3d from_x_axis,
            Vector3d from_y_axis, double[] to_origin, double[] to_x_axis, double[] to_y_axis, out Matrix4x4 mtx) =>
            ufMtx4.CsysToCsys(from_origin.ToArray(), from_x_axis.ToArray(), from_y_axis.ToArray(), to_origin, to_x_axis,
                to_y_axis, out mtx);

        /// <summary>
        ///     Returns the matrix which can be used to map from one csys to another.
        /// </summary>
        /// <remarks>
        ///     Refer to <see href="..ugopen_doc/uf_mtx/global.html#UF_MTX4_csys_to_csys">UF_MTX4_csys_to_csys</see> for documentation<br/>
        ///     <see href="..mapping/Uf2NxOpenNet.htm">Mapping Help</see><br/>
        ///     License requirements:None
        /// </remarks>
        /// <param name="ufMtx4"></param>
        /// <param name="from_origin">Input origin of csys to map from</param>
        /// <param name="from_x_axis">Input x axis of csys to map from</param>
        /// <param name="from_y_axis">Input y axis of csys to map from</param>
        /// <param name="to_origin">Input origin of csys to map to</param>
        /// <param name="to_x_axis">Input x axis of csys to map to</param>
        /// <param name="to_y_axis">Input y axis of csys to map to</param>
        /// <param name="mtx">Output Returned matrix that can be used to
        ///     transform objects</param>
        public static void CsysToCsys(this UFMtx4 ufMtx4, double[] from_origin, double[] from_x_axis,
            double[] from_y_axis, Point3d to_origin, double[] to_x_axis, double[] to_y_axis, out Matrix4x4 mtx) =>
            ufMtx4.CsysToCsys(from_origin, from_x_axis, from_y_axis, to_origin.ToArray(), to_x_axis, to_y_axis,
                out mtx);

        /// <summary>
        ///     Returns the matrix which can be used to map from one csys to another.
        /// </summary>
        /// <remarks>
        ///     Refer to <see href="..ugopen_doc/uf_mtx/global.html#UF_MTX4_csys_to_csys">UF_MTX4_csys_to_csys</see> for documentation<br/>
        ///     <see href="..mapping/Uf2NxOpenNet.htm">Mapping Help</see><br/>
        ///     License requirements:None
        /// </remarks>
        /// <param name="ufMtx4"></param>
        /// <param name="from_origin">Input origin of csys to map from</param>
        /// <param name="from_x_axis">Input x axis of csys to map from</param>
        /// <param name="from_y_axis">Input y axis of csys to map from</param>
        /// <param name="to_origin">Input origin of csys to map to</param>
        /// <param name="to_x_axis">Input x axis of csys to map to</param>
        /// <param name="to_y_axis">Input y axis of csys to map to</param>
        /// <param name="mtx">Output Returned matrix that can be used to
        ///     transform objects</param>
        public static void CsysToCsys(this UFMtx4 ufMtx4, Point3d from_origin, double[] from_x_axis,
            double[] from_y_axis, Point3d to_origin, double[] to_x_axis, double[] to_y_axis, out Matrix4x4 mtx) =>
            ufMtx4.CsysToCsys(from_origin.ToArray(), from_x_axis, from_y_axis, to_origin.ToArray(), to_x_axis,
                to_y_axis, out mtx);

        /// <summary>
        ///     Returns the matrix which can be used to map from one csys to another.
        /// </summary>
        /// <remarks>
        ///     Refer to <see href="..ugopen_doc/uf_mtx/global.html#UF_MTX4_csys_to_csys">UF_MTX4_csys_to_csys</see> for documentation<br/>
        ///     <see href="..mapping/Uf2NxOpenNet.htm">Mapping Help</see><br/>
        ///     License requirements:None
        /// </remarks>
        /// <param name="ufMtx4"></param>
        /// <param name="from_origin">Input origin of csys to map from</param>
        /// <param name="from_x_axis">Input x axis of csys to map from</param>
        /// <param name="from_y_axis">Input y axis of csys to map from</param>
        /// <param name="to_origin">Input origin of csys to map to</param>
        /// <param name="to_x_axis">Input x axis of csys to map to</param>
        /// <param name="to_y_axis">Input y axis of csys to map to</param>
        /// <param name="mtx">Output Returned matrix that can be used to
        ///     transform objects</param>
        public static void CsysToCsys(this UFMtx4 ufMtx4, double[] from_origin, Vector3d from_x_axis,
            double[] from_y_axis, Point3d to_origin, double[] to_x_axis, double[] to_y_axis, out Matrix4x4 mtx) =>
            ufMtx4.CsysToCsys(from_origin, from_x_axis.ToArray(), from_y_axis, to_origin.ToArray(), to_x_axis,
                to_y_axis, out mtx);

        /// <summary>
        ///     Returns the matrix which can be used to map from one csys to another.
        /// </summary>
        /// <remarks>
        ///     Refer to <see href="..ugopen_doc/uf_mtx/global.html#UF_MTX4_csys_to_csys">UF_MTX4_csys_to_csys</see> for documentation<br/>
        ///     <see href="..mapping/Uf2NxOpenNet.htm">Mapping Help</see><br/>
        ///     License requirements:None
        /// </remarks>
        /// <param name="ufMtx4"></param>
        /// <param name="from_origin">Input origin of csys to map from</param>
        /// <param name="from_x_axis">Input x axis of csys to map from</param>
        /// <param name="from_y_axis">Input y axis of csys to map from</param>
        /// <param name="to_origin">Input origin of csys to map to</param>
        /// <param name="to_x_axis">Input x axis of csys to map to</param>
        /// <param name="to_y_axis">Input y axis of csys to map to</param>
        /// <param name="mtx">Output Returned matrix that can be used to
        ///     transform objects</param>
        public static void CsysToCsys(this UFMtx4 ufMtx4, Point3d from_origin, Vector3d from_x_axis,
            double[] from_y_axis, Point3d to_origin, double[] to_x_axis, double[] to_y_axis, out Matrix4x4 mtx) =>
            ufMtx4.CsysToCsys(from_origin.ToArray(), from_x_axis.ToArray(), from_y_axis, to_origin.ToArray(), to_x_axis,
                to_y_axis, out mtx);

        /// <summary>
        ///     Returns the matrix which can be used to map from one csys to another.
        /// </summary>
        /// <remarks>
        ///     Refer to <see href="..ugopen_doc/uf_mtx/global.html#UF_MTX4_csys_to_csys">UF_MTX4_csys_to_csys</see> for documentation<br/>
        ///     <see href="..mapping/Uf2NxOpenNet.htm">Mapping Help</see><br/>
        ///     License requirements:None
        /// </remarks>
        /// <param name="ufMtx4"></param>
        /// <param name="from_origin">Input origin of csys to map from</param>
        /// <param name="from_x_axis">Input x axis of csys to map from</param>
        /// <param name="from_y_axis">Input y axis of csys to map from</param>
        /// <param name="to_origin">Input origin of csys to map to</param>
        /// <param name="to_x_axis">Input x axis of csys to map to</param>
        /// <param name="to_y_axis">Input y axis of csys to map to</param>
        /// <param name="mtx">Output Returned matrix that can be used to
        ///     transform objects</param>
        public static void CsysToCsys(this UFMtx4 ufMtx4, double[] from_origin, double[] from_x_axis,
            Vector3d from_y_axis, Point3d to_origin, double[] to_x_axis, double[] to_y_axis, out Matrix4x4 mtx) =>
            ufMtx4.CsysToCsys(from_origin, from_x_axis, from_y_axis.ToArray(), to_origin.ToArray(), to_x_axis,
                to_y_axis, out mtx);

        /// <summary>
        ///     Returns the matrix which can be used to map from one csys to another.
        /// </summary>
        /// <remarks>
        ///     Refer to <see href="..ugopen_doc/uf_mtx/global.html#UF_MTX4_csys_to_csys">UF_MTX4_csys_to_csys</see> for documentation<br/>
        ///     <see href="..mapping/Uf2NxOpenNet.htm">Mapping Help</see><br/>
        ///     License requirements:None
        /// </remarks>
        /// <param name="ufMtx4"></param>
        /// <param name="from_origin">Input origin of csys to map from</param>
        /// <param name="from_x_axis">Input x axis of csys to map from</param>
        /// <param name="from_y_axis">Input y axis of csys to map from</param>
        /// <param name="to_origin">Input origin of csys to map to</param>
        /// <param name="to_x_axis">Input x axis of csys to map to</param>
        /// <param name="to_y_axis">Input y axis of csys to map to</param>
        /// <param name="mtx">Output Returned matrix that can be used to
        ///     transform objects</param>
        public static void CsysToCsys(this UFMtx4 ufMtx4, Point3d from_origin, double[] from_x_axis,
            Vector3d from_y_axis, Point3d to_origin, double[] to_x_axis, double[] to_y_axis, out Matrix4x4 mtx) =>
            ufMtx4.CsysToCsys(from_origin.ToArray(), from_x_axis, from_y_axis.ToArray(), to_origin.ToArray(), to_x_axis,
                to_y_axis, out mtx);

        /// <summary>
        ///     Returns the matrix which can be used to map from one csys to another.
        /// </summary>
        /// <remarks>
        ///     Refer to <see href="..ugopen_doc/uf_mtx/global.html#UF_MTX4_csys_to_csys">UF_MTX4_csys_to_csys</see> for documentation<br/>
        ///     <see href="..mapping/Uf2NxOpenNet.htm">Mapping Help</see><br/>
        ///     License requirements:None
        /// </remarks>
        /// <param name="ufMtx4"></param>
        /// <param name="from_origin">Input origin of csys to map from</param>
        /// <param name="from_x_axis">Input x axis of csys to map from</param>
        /// <param name="from_y_axis">Input y axis of csys to map from</param>
        /// <param name="to_origin">Input origin of csys to map to</param>
        /// <param name="to_x_axis">Input x axis of csys to map to</param>
        /// <param name="to_y_axis">Input y axis of csys to map to</param>
        /// <param name="mtx">Output Returned matrix that can be used to
        ///     transform objects</param>
        public static void CsysToCsys(this UFMtx4 ufMtx4, double[] from_origin, Vector3d from_x_axis,
            Vector3d from_y_axis, Point3d to_origin, double[] to_x_axis, double[] to_y_axis, out Matrix4x4 mtx) =>
            ufMtx4.CsysToCsys(from_origin, from_x_axis.ToArray(), from_y_axis.ToArray(), to_origin.ToArray(), to_x_axis,
                to_y_axis, out mtx);

        /// <summary>
        ///     Returns the matrix which can be used to map from one csys to another.
        /// </summary>
        /// <remarks>
        ///     Refer to <see href="..ugopen_doc/uf_mtx/global.html#UF_MTX4_csys_to_csys">UF_MTX4_csys_to_csys</see> for documentation<br/>
        ///     <see href="..mapping/Uf2NxOpenNet.htm">Mapping Help</see><br/>
        ///     License requirements:None
        /// </remarks>
        /// <param name="ufMtx4"></param>
        /// <param name="from_origin">Input origin of csys to map from</param>
        /// <param name="from_x_axis">Input x axis of csys to map from</param>
        /// <param name="from_y_axis">Input y axis of csys to map from</param>
        /// <param name="to_origin">Input origin of csys to map to</param>
        /// <param name="to_x_axis">Input x axis of csys to map to</param>
        /// <param name="to_y_axis">Input y axis of csys to map to</param>
        /// <param name="mtx">Output Returned matrix that can be used to
        ///     transform objects</param>
        public static void CsysToCsys(this UFMtx4 ufMtx4, Point3d from_origin, Vector3d from_x_axis,
            Vector3d from_y_axis, Point3d to_origin, double[] to_x_axis, double[] to_y_axis, out Matrix4x4 mtx) =>
            ufMtx4.CsysToCsys(from_origin.ToArray(), from_x_axis.ToArray(), from_y_axis.ToArray(), to_origin.ToArray(),
                to_x_axis, to_y_axis, out mtx);

        /// <summary>
        ///     Returns the matrix which can be used to map from one csys to another.
        /// </summary>
        /// <remarks>
        ///     Refer to <see href="..ugopen_doc/uf_mtx/global.html#UF_MTX4_csys_to_csys">UF_MTX4_csys_to_csys</see> for documentation<br/>
        ///     <see href="..mapping/Uf2NxOpenNet.htm">Mapping Help</see><br/>
        ///     License requirements:None
        /// </remarks>
        /// <param name="ufMtx4"></param>
        /// <param name="from_origin">Input origin of csys to map from</param>
        /// <param name="from_x_axis">Input x axis of csys to map from</param>
        /// <param name="from_y_axis">Input y axis of csys to map from</param>
        /// <param name="to_origin">Input origin of csys to map to</param>
        /// <param name="to_x_axis">Input x axis of csys to map to</param>
        /// <param name="to_y_axis">Input y axis of csys to map to</param>
        /// <param name="mtx">Output Returned matrix that can be used to
        ///     transform objects</param>
        public static void CsysToCsys(this UFMtx4 ufMtx4, double[] from_origin, double[] from_x_axis,
            double[] from_y_axis, double[] to_origin, Vector3d to_x_axis, double[] to_y_axis, out Matrix4x4 mtx) =>
            ufMtx4.CsysToCsys(from_origin, from_x_axis, from_y_axis, to_origin, to_x_axis.ToArray(), to_y_axis,
                out mtx);

        /// <summary>
        ///     Returns the matrix which can be used to map from one csys to another.
        /// </summary>
        /// <remarks>
        ///     Refer to <see href="..ugopen_doc/uf_mtx/global.html#UF_MTX4_csys_to_csys">UF_MTX4_csys_to_csys</see> for documentation<br/>
        ///     <see href="..mapping/Uf2NxOpenNet.htm">Mapping Help</see><br/>
        ///     License requirements:None
        /// </remarks>
        /// <param name="ufMtx4"></param>
        /// <param name="from_origin">Input origin of csys to map from</param>
        /// <param name="from_x_axis">Input x axis of csys to map from</param>
        /// <param name="from_y_axis">Input y axis of csys to map from</param>
        /// <param name="to_origin">Input origin of csys to map to</param>
        /// <param name="to_x_axis">Input x axis of csys to map to</param>
        /// <param name="to_y_axis">Input y axis of csys to map to</param>
        /// <param name="mtx">Output Returned matrix that can be used to
        ///     transform objects</param>
        public static void CsysToCsys(this UFMtx4 ufMtx4, Point3d from_origin, double[] from_x_axis,
            double[] from_y_axis, double[] to_origin, Vector3d to_x_axis, double[] to_y_axis, out Matrix4x4 mtx) =>
            ufMtx4.CsysToCsys(from_origin.ToArray(), from_x_axis, from_y_axis, to_origin, to_x_axis.ToArray(),
                to_y_axis, out mtx);

        /// <summary>
        ///     Returns the matrix which can be used to map from one csys to another.
        /// </summary>
        /// <remarks>
        ///     Refer to <see href="..ugopen_doc/uf_mtx/global.html#UF_MTX4_csys_to_csys">UF_MTX4_csys_to_csys</see> for documentation<br/>
        ///     <see href="..mapping/Uf2NxOpenNet.htm">Mapping Help</see><br/>
        ///     License requirements:None
        /// </remarks>
        /// <param name="ufMtx4"></param>
        /// <param name="from_origin">Input origin of csys to map from</param>
        /// <param name="from_x_axis">Input x axis of csys to map from</param>
        /// <param name="from_y_axis">Input y axis of csys to map from</param>
        /// <param name="to_origin">Input origin of csys to map to</param>
        /// <param name="to_x_axis">Input x axis of csys to map to</param>
        /// <param name="to_y_axis">Input y axis of csys to map to</param>
        /// <param name="mtx">Output Returned matrix that can be used to
        ///     transform objects</param>
        public static void CsysToCsys(this UFMtx4 ufMtx4, double[] from_origin, Vector3d from_x_axis,
            double[] from_y_axis, double[] to_origin, Vector3d to_x_axis, double[] to_y_axis, out Matrix4x4 mtx) =>
            ufMtx4.CsysToCsys(from_origin, from_x_axis.ToArray(), from_y_axis, to_origin, to_x_axis.ToArray(),
                to_y_axis, out mtx);

        /// <summary>
        ///     Returns the matrix which can be used to map from one csys to another.
        /// </summary>
        /// <remarks>
        ///     Refer to <see href="..ugopen_doc/uf_mtx/global.html#UF_MTX4_csys_to_csys">UF_MTX4_csys_to_csys</see> for documentation<br/>
        ///     <see href="..mapping/Uf2NxOpenNet.htm">Mapping Help</see><br/>
        ///     License requirements:None
        /// </remarks>
        /// <param name="ufMtx4"></param>
        /// <param name="from_origin">Input origin of csys to map from</param>
        /// <param name="from_x_axis">Input x axis of csys to map from</param>
        /// <param name="from_y_axis">Input y axis of csys to map from</param>
        /// <param name="to_origin">Input origin of csys to map to</param>
        /// <param name="to_x_axis">Input x axis of csys to map to</param>
        /// <param name="to_y_axis">Input y axis of csys to map to</param>
        /// <param name="mtx">Output Returned matrix that can be used to
        ///     transform objects</param>
        public static void CsysToCsys(this UFMtx4 ufMtx4, Point3d from_origin, Vector3d from_x_axis,
            double[] from_y_axis, double[] to_origin, Vector3d to_x_axis, double[] to_y_axis, out Matrix4x4 mtx) =>
            ufMtx4.CsysToCsys(from_origin.ToArray(), from_x_axis.ToArray(), from_y_axis, to_origin, to_x_axis.ToArray(),
                to_y_axis, out mtx);

        /// <summary>
        ///     Returns the matrix which can be used to map from one csys to another.
        /// </summary>
        /// <remarks>
        ///     Refer to <see href="..ugopen_doc/uf_mtx/global.html#UF_MTX4_csys_to_csys">UF_MTX4_csys_to_csys</see> for documentation<br/>
        ///     <see href="..mapping/Uf2NxOpenNet.htm">Mapping Help</see><br/>
        ///     License requirements:None
        /// </remarks>
        /// <param name="ufMtx4"></param>
        /// <param name="from_origin">Input origin of csys to map from</param>
        /// <param name="from_x_axis">Input x axis of csys to map from</param>
        /// <param name="from_y_axis">Input y axis of csys to map from</param>
        /// <param name="to_origin">Input origin of csys to map to</param>
        /// <param name="to_x_axis">Input x axis of csys to map to</param>
        /// <param name="to_y_axis">Input y axis of csys to map to</param>
        /// <param name="mtx">Output Returned matrix that can be used to
        ///     transform objects</param>
        public static void CsysToCsys(this UFMtx4 ufMtx4, double[] from_origin, double[] from_x_axis,
            Vector3d from_y_axis, double[] to_origin, Vector3d to_x_axis, double[] to_y_axis, out Matrix4x4 mtx) =>
            ufMtx4.CsysToCsys(from_origin, from_x_axis, from_y_axis.ToArray(), to_origin, to_x_axis.ToArray(),
                to_y_axis, out mtx);

        /// <summary>
        ///     Returns the matrix which can be used to map from one csys to another.
        /// </summary>
        /// <remarks>
        ///     Refer to <see href="..ugopen_doc/uf_mtx/global.html#UF_MTX4_csys_to_csys">UF_MTX4_csys_to_csys</see> for documentation<br/>
        ///     <see href="..mapping/Uf2NxOpenNet.htm">Mapping Help</see><br/>
        ///     License requirements:None
        /// </remarks>
        /// <param name="ufMtx4"></param>
        /// <param name="from_origin">Input origin of csys to map from</param>
        /// <param name="from_x_axis">Input x axis of csys to map from</param>
        /// <param name="from_y_axis">Input y axis of csys to map from</param>
        /// <param name="to_origin">Input origin of csys to map to</param>
        /// <param name="to_x_axis">Input x axis of csys to map to</param>
        /// <param name="to_y_axis">Input y axis of csys to map to</param>
        /// <param name="mtx">Output Returned matrix that can be used to
        ///     transform objects</param>
        public static void CsysToCsys(this UFMtx4 ufMtx4, Point3d from_origin, double[] from_x_axis,
            Vector3d from_y_axis, double[] to_origin, Vector3d to_x_axis, double[] to_y_axis, out Matrix4x4 mtx) =>
            ufMtx4.CsysToCsys(from_origin.ToArray(), from_x_axis, from_y_axis.ToArray(), to_origin, to_x_axis.ToArray(),
                to_y_axis, out mtx);

        /// <summary>
        ///     Returns the matrix which can be used to map from one csys to another.
        /// </summary>
        /// <remarks>
        ///     Refer to <see href="..ugopen_doc/uf_mtx/global.html#UF_MTX4_csys_to_csys">UF_MTX4_csys_to_csys</see> for documentation<br/>
        ///     <see href="..mapping/Uf2NxOpenNet.htm">Mapping Help</see><br/>
        ///     License requirements:None
        /// </remarks>
        /// <param name="ufMtx4"></param>
        /// <param name="from_origin">Input origin of csys to map from</param>
        /// <param name="from_x_axis">Input x axis of csys to map from</param>
        /// <param name="from_y_axis">Input y axis of csys to map from</param>
        /// <param name="to_origin">Input origin of csys to map to</param>
        /// <param name="to_x_axis">Input x axis of csys to map to</param>
        /// <param name="to_y_axis">Input y axis of csys to map to</param>
        /// <param name="mtx">Output Returned matrix that can be used to
        ///     transform objects</param>
        public static void CsysToCsys(this UFMtx4 ufMtx4, double[] from_origin, Vector3d from_x_axis,
            Vector3d from_y_axis, double[] to_origin, Vector3d to_x_axis, double[] to_y_axis, out Matrix4x4 mtx) =>
            ufMtx4.CsysToCsys(from_origin, from_x_axis.ToArray(), from_y_axis.ToArray(), to_origin, to_x_axis.ToArray(),
                to_y_axis, out mtx);

        /// <summary>
        ///     Returns the matrix which can be used to map from one csys to another.
        /// </summary>
        /// <remarks>
        ///     Refer to <see href="..ugopen_doc/uf_mtx/global.html#UF_MTX4_csys_to_csys">UF_MTX4_csys_to_csys</see> for documentation<br/>
        ///     <see href="..mapping/Uf2NxOpenNet.htm">Mapping Help</see><br/>
        ///     License requirements:None
        /// </remarks>
        /// <param name="ufMtx4"></param>
        /// <param name="from_origin">Input origin of csys to map from</param>
        /// <param name="from_x_axis">Input x axis of csys to map from</param>
        /// <param name="from_y_axis">Input y axis of csys to map from</param>
        /// <param name="to_origin">Input origin of csys to map to</param>
        /// <param name="to_x_axis">Input x axis of csys to map to</param>
        /// <param name="to_y_axis">Input y axis of csys to map to</param>
        /// <param name="mtx">Output Returned matrix that can be used to
        ///     transform objects</param>
        public static void CsysToCsys(this UFMtx4 ufMtx4, Point3d from_origin, Vector3d from_x_axis,
            Vector3d from_y_axis, double[] to_origin, Vector3d to_x_axis, double[] to_y_axis, out Matrix4x4 mtx) =>
            ufMtx4.CsysToCsys(from_origin.ToArray(), from_x_axis.ToArray(), from_y_axis.ToArray(), to_origin,
                to_x_axis.ToArray(), to_y_axis, out mtx);

        /// <summary>
        ///     Returns the matrix which can be used to map from one csys to another.
        /// </summary>
        /// <remarks>
        ///     Refer to <see href="..ugopen_doc/uf_mtx/global.html#UF_MTX4_csys_to_csys">UF_MTX4_csys_to_csys</see> for documentation<br/>
        ///     <see href="..mapping/Uf2NxOpenNet.htm">Mapping Help</see><br/>
        ///     License requirements:None
        /// </remarks>
        /// <param name="ufMtx4"></param>
        /// <param name="from_origin">Input origin of csys to map from</param>
        /// <param name="from_x_axis">Input x axis of csys to map from</param>
        /// <param name="from_y_axis">Input y axis of csys to map from</param>
        /// <param name="to_origin">Input origin of csys to map to</param>
        /// <param name="to_x_axis">Input x axis of csys to map to</param>
        /// <param name="to_y_axis">Input y axis of csys to map to</param>
        /// <param name="mtx">Output Returned matrix that can be used to
        ///     transform objects</param>
        public static void CsysToCsys(this UFMtx4 ufMtx4, double[] from_origin, double[] from_x_axis,
            double[] from_y_axis, Point3d to_origin, Vector3d to_x_axis, double[] to_y_axis, out Matrix4x4 mtx) =>
            ufMtx4.CsysToCsys(from_origin, from_x_axis, from_y_axis, to_origin.ToArray(), to_x_axis.ToArray(),
                to_y_axis, out mtx);

        /// <summary>
        ///     Returns the matrix which can be used to map from one csys to another.
        /// </summary>
        /// <remarks>
        ///     Refer to <see href="..ugopen_doc/uf_mtx/global.html#UF_MTX4_csys_to_csys">UF_MTX4_csys_to_csys</see> for documentation<br/>
        ///     <see href="..mapping/Uf2NxOpenNet.htm">Mapping Help</see><br/>
        ///     License requirements:None
        /// </remarks>
        /// <param name="ufMtx4"></param>
        /// <param name="from_origin">Input origin of csys to map from</param>
        /// <param name="from_x_axis">Input x axis of csys to map from</param>
        /// <param name="from_y_axis">Input y axis of csys to map from</param>
        /// <param name="to_origin">Input origin of csys to map to</param>
        /// <param name="to_x_axis">Input x axis of csys to map to</param>
        /// <param name="to_y_axis">Input y axis of csys to map to</param>
        /// <param name="mtx">Output Returned matrix that can be used to
        ///     transform objects</param>
        public static void CsysToCsys(this UFMtx4 ufMtx4, Point3d from_origin, double[] from_x_axis,
            double[] from_y_axis, Point3d to_origin, Vector3d to_x_axis, double[] to_y_axis, out Matrix4x4 mtx) =>
            ufMtx4.CsysToCsys(from_origin.ToArray(), from_x_axis, from_y_axis, to_origin.ToArray(), to_x_axis.ToArray(),
                to_y_axis, out mtx);

        /// <summary>
        ///     Returns the matrix which can be used to map from one csys to another.
        /// </summary>
        /// <remarks>
        ///     Refer to <see href="..ugopen_doc/uf_mtx/global.html#UF_MTX4_csys_to_csys">UF_MTX4_csys_to_csys</see> for documentation<br/>
        ///     <see href="..mapping/Uf2NxOpenNet.htm">Mapping Help</see><br/>
        ///     License requirements:None
        /// </remarks>
        /// <param name="ufMtx4"></param>
        /// <param name="from_origin">Input origin of csys to map from</param>
        /// <param name="from_x_axis">Input x axis of csys to map from</param>
        /// <param name="from_y_axis">Input y axis of csys to map from</param>
        /// <param name="to_origin">Input origin of csys to map to</param>
        /// <param name="to_x_axis">Input x axis of csys to map to</param>
        /// <param name="to_y_axis">Input y axis of csys to map to</param>
        /// <param name="mtx">Output Returned matrix that can be used to
        ///     transform objects</param>
        public static void CsysToCsys(this UFMtx4 ufMtx4, double[] from_origin, Vector3d from_x_axis,
            double[] from_y_axis, Point3d to_origin, Vector3d to_x_axis, double[] to_y_axis, out Matrix4x4 mtx) =>
            ufMtx4.CsysToCsys(from_origin, from_x_axis.ToArray(), from_y_axis, to_origin.ToArray(), to_x_axis.ToArray(),
                to_y_axis, out mtx);

        /// <summary>
        ///     Returns the matrix which can be used to map from one csys to another.
        /// </summary>
        /// <remarks>
        ///     Refer to <see href="..ugopen_doc/uf_mtx/global.html#UF_MTX4_csys_to_csys">UF_MTX4_csys_to_csys</see> for documentation<br/>
        ///     <see href="..mapping/Uf2NxOpenNet.htm">Mapping Help</see><br/>
        ///     License requirements:None
        /// </remarks>
        /// <param name="ufMtx4"></param>
        /// <param name="from_origin">Input origin of csys to map from</param>
        /// <param name="from_x_axis">Input x axis of csys to map from</param>
        /// <param name="from_y_axis">Input y axis of csys to map from</param>
        /// <param name="to_origin">Input origin of csys to map to</param>
        /// <param name="to_x_axis">Input x axis of csys to map to</param>
        /// <param name="to_y_axis">Input y axis of csys to map to</param>
        /// <param name="mtx">Output Returned matrix that can be used to
        ///     transform objects</param>
        public static void CsysToCsys(this UFMtx4 ufMtx4, Point3d from_origin, Vector3d from_x_axis,
            double[] from_y_axis, Point3d to_origin, Vector3d to_x_axis, double[] to_y_axis, out Matrix4x4 mtx) =>
            ufMtx4.CsysToCsys(from_origin.ToArray(), from_x_axis.ToArray(), from_y_axis, to_origin.ToArray(),
                to_x_axis.ToArray(), to_y_axis, out mtx);

        /// <summary>
        ///     Returns the matrix which can be used to map from one csys to another.
        /// </summary>
        /// <remarks>
        ///     Refer to <see href="..ugopen_doc/uf_mtx/global.html#UF_MTX4_csys_to_csys">UF_MTX4_csys_to_csys</see> for documentation<br/>
        ///     <see href="..mapping/Uf2NxOpenNet.htm">Mapping Help</see><br/>
        ///     License requirements:None
        /// </remarks>
        /// <param name="ufMtx4"></param>
        /// <param name="from_origin">Input origin of csys to map from</param>
        /// <param name="from_x_axis">Input x axis of csys to map from</param>
        /// <param name="from_y_axis">Input y axis of csys to map from</param>
        /// <param name="to_origin">Input origin of csys to map to</param>
        /// <param name="to_x_axis">Input x axis of csys to map to</param>
        /// <param name="to_y_axis">Input y axis of csys to map to</param>
        /// <param name="mtx">Output Returned matrix that can be used to
        ///     transform objects</param>
        public static void CsysToCsys(this UFMtx4 ufMtx4, double[] from_origin, double[] from_x_axis,
            Vector3d from_y_axis, Point3d to_origin, Vector3d to_x_axis, double[] to_y_axis, out Matrix4x4 mtx) =>
            ufMtx4.CsysToCsys(from_origin, from_x_axis, from_y_axis.ToArray(), to_origin.ToArray(), to_x_axis.ToArray(),
                to_y_axis, out mtx);

        /// <summary>
        ///     Returns the matrix which can be used to map from one csys to another.
        /// </summary>
        /// <remarks>
        ///     Refer to <see href="..ugopen_doc/uf_mtx/global.html#UF_MTX4_csys_to_csys">UF_MTX4_csys_to_csys</see> for documentation<br/>
        ///     <see href="..mapping/Uf2NxOpenNet.htm">Mapping Help</see><br/>
        ///     License requirements:None
        /// </remarks>
        /// <param name="ufMtx4"></param>
        /// <param name="from_origin">Input origin of csys to map from</param>
        /// <param name="from_x_axis">Input x axis of csys to map from</param>
        /// <param name="from_y_axis">Input y axis of csys to map from</param>
        /// <param name="to_origin">Input origin of csys to map to</param>
        /// <param name="to_x_axis">Input x axis of csys to map to</param>
        /// <param name="to_y_axis">Input y axis of csys to map to</param>
        /// <param name="mtx">Output Returned matrix that can be used to
        ///     transform objects</param>
        public static void CsysToCsys(this UFMtx4 ufMtx4, Point3d from_origin, double[] from_x_axis,
            Vector3d from_y_axis, Point3d to_origin, Vector3d to_x_axis, double[] to_y_axis, out Matrix4x4 mtx) =>
            ufMtx4.CsysToCsys(from_origin.ToArray(), from_x_axis, from_y_axis.ToArray(), to_origin.ToArray(),
                to_x_axis.ToArray(), to_y_axis, out mtx);

        /// <summary>
        ///     Returns the matrix which can be used to map from one csys to another.
        /// </summary>
        /// <remarks>
        ///     Refer to <see href="..ugopen_doc/uf_mtx/global.html#UF_MTX4_csys_to_csys">UF_MTX4_csys_to_csys</see> for documentation<br/>
        ///     <see href="..mapping/Uf2NxOpenNet.htm">Mapping Help</see><br/>
        ///     License requirements:None
        /// </remarks>
        /// <param name="ufMtx4"></param>
        /// <param name="from_origin">Input origin of csys to map from</param>
        /// <param name="from_x_axis">Input x axis of csys to map from</param>
        /// <param name="from_y_axis">Input y axis of csys to map from</param>
        /// <param name="to_origin">Input origin of csys to map to</param>
        /// <param name="to_x_axis">Input x axis of csys to map to</param>
        /// <param name="to_y_axis">Input y axis of csys to map to</param>
        /// <param name="mtx">Output Returned matrix that can be used to
        ///     transform objects</param>
        public static void CsysToCsys(this UFMtx4 ufMtx4, double[] from_origin, Vector3d from_x_axis,
            Vector3d from_y_axis, Point3d to_origin, Vector3d to_x_axis, double[] to_y_axis, out Matrix4x4 mtx) =>
            ufMtx4.CsysToCsys(from_origin, from_x_axis.ToArray(), from_y_axis.ToArray(), to_origin.ToArray(),
                to_x_axis.ToArray(), to_y_axis, out mtx);

        /// <summary>
        ///     Returns the matrix which can be used to map from one csys to another.
        /// </summary>
        /// <remarks>
        ///     Refer to <see href="..ugopen_doc/uf_mtx/global.html#UF_MTX4_csys_to_csys">UF_MTX4_csys_to_csys</see> for documentation<br/>
        ///     <see href="..mapping/Uf2NxOpenNet.htm">Mapping Help</see><br/>
        ///     License requirements:None
        /// </remarks>
        /// <param name="ufMtx4"></param>
        /// <param name="from_origin">Input origin of csys to map from</param>
        /// <param name="from_x_axis">Input x axis of csys to map from</param>
        /// <param name="from_y_axis">Input y axis of csys to map from</param>
        /// <param name="to_origin">Input origin of csys to map to</param>
        /// <param name="to_x_axis">Input x axis of csys to map to</param>
        /// <param name="to_y_axis">Input y axis of csys to map to</param>
        /// <param name="mtx">Output Returned matrix that can be used to
        ///     transform objects</param>
        public static void CsysToCsys(this UFMtx4 ufMtx4, Point3d from_origin, Vector3d from_x_axis,
            Vector3d from_y_axis, Point3d to_origin, Vector3d to_x_axis, double[] to_y_axis, out Matrix4x4 mtx) =>
            ufMtx4.CsysToCsys(from_origin.ToArray(), from_x_axis.ToArray(), from_y_axis.ToArray(), to_origin.ToArray(),
                to_x_axis.ToArray(), to_y_axis, out mtx);

        /// <summary>
        ///     Returns the matrix which can be used to map from one csys to another.
        /// </summary>
        /// <remarks>
        ///     Refer to <see href="..ugopen_doc/uf_mtx/global.html#UF_MTX4_csys_to_csys">UF_MTX4_csys_to_csys</see> for documentation<br/>
        ///     <see href="..mapping/Uf2NxOpenNet.htm">Mapping Help</see><br/>
        ///     License requirements:None
        /// </remarks>
        /// <param name="ufMtx4"></param>
        /// <param name="from_origin">Input origin of csys to map from</param>
        /// <param name="from_x_axis">Input x axis of csys to map from</param>
        /// <param name="from_y_axis">Input y axis of csys to map from</param>
        /// <param name="to_origin">Input origin of csys to map to</param>
        /// <param name="to_x_axis">Input x axis of csys to map to</param>
        /// <param name="to_y_axis">Input y axis of csys to map to</param>
        /// <param name="mtx">Output Returned matrix that can be used to
        ///     transform objects</param>
        public static void CsysToCsys(this UFMtx4 ufMtx4, double[] from_origin, double[] from_x_axis,
            double[] from_y_axis, double[] to_origin, double[] to_x_axis, Vector3d to_y_axis, out Matrix4x4 mtx) =>
            ufMtx4.CsysToCsys(from_origin, from_x_axis, from_y_axis, to_origin, to_x_axis, to_y_axis.ToArray(),
                out mtx);

        /// <summary>
        ///     Returns the matrix which can be used to map from one csys to another.
        /// </summary>
        /// <remarks>
        ///     Refer to <see href="..ugopen_doc/uf_mtx/global.html#UF_MTX4_csys_to_csys">UF_MTX4_csys_to_csys</see> for documentation<br/>
        ///     <see href="..mapping/Uf2NxOpenNet.htm">Mapping Help</see><br/>
        ///     License requirements:None
        /// </remarks>
        /// <param name="ufMtx4"></param>
        /// <param name="from_origin">Input origin of csys to map from</param>
        /// <param name="from_x_axis">Input x axis of csys to map from</param>
        /// <param name="from_y_axis">Input y axis of csys to map from</param>
        /// <param name="to_origin">Input origin of csys to map to</param>
        /// <param name="to_x_axis">Input x axis of csys to map to</param>
        /// <param name="to_y_axis">Input y axis of csys to map to</param>
        /// <param name="mtx">Output Returned matrix that can be used to
        ///     transform objects</param>
        public static void CsysToCsys(this UFMtx4 ufMtx4, Point3d from_origin, double[] from_x_axis,
            double[] from_y_axis, double[] to_origin, double[] to_x_axis, Vector3d to_y_axis, out Matrix4x4 mtx) =>
            ufMtx4.CsysToCsys(from_origin.ToArray(), from_x_axis, from_y_axis, to_origin, to_x_axis,
                to_y_axis.ToArray(), out mtx);

        /// <summary>
        ///     Returns the matrix which can be used to map from one csys to another.
        /// </summary>
        /// <remarks>
        ///     Refer to <see href="..ugopen_doc/uf_mtx/global.html#UF_MTX4_csys_to_csys">UF_MTX4_csys_to_csys</see> for documentation<br/>
        ///     <see href="..mapping/Uf2NxOpenNet.htm">Mapping Help</see><br/>
        ///     License requirements:None
        /// </remarks>
        /// <param name="ufMtx4"></param>
        /// <param name="from_origin">Input origin of csys to map from</param>
        /// <param name="from_x_axis">Input x axis of csys to map from</param>
        /// <param name="from_y_axis">Input y axis of csys to map from</param>
        /// <param name="to_origin">Input origin of csys to map to</param>
        /// <param name="to_x_axis">Input x axis of csys to map to</param>
        /// <param name="to_y_axis">Input y axis of csys to map to</param>
        /// <param name="mtx">Output Returned matrix that can be used to
        ///     transform objects</param>
        public static void CsysToCsys(this UFMtx4 ufMtx4, double[] from_origin, Vector3d from_x_axis,
            double[] from_y_axis, double[] to_origin, double[] to_x_axis, Vector3d to_y_axis, out Matrix4x4 mtx) =>
            ufMtx4.CsysToCsys(from_origin, from_x_axis.ToArray(), from_y_axis, to_origin, to_x_axis,
                to_y_axis.ToArray(), out mtx);

        /// <summary>
        ///     Returns the matrix which can be used to map from one csys to another.
        /// </summary>
        /// <remarks>
        ///     Refer to <see href="..ugopen_doc/uf_mtx/global.html#UF_MTX4_csys_to_csys">UF_MTX4_csys_to_csys</see> for documentation<br/>
        ///     <see href="..mapping/Uf2NxOpenNet.htm">Mapping Help</see><br/>
        ///     License requirements:None
        /// </remarks>
        /// <param name="ufMtx4"></param>
        /// <param name="from_origin">Input origin of csys to map from</param>
        /// <param name="from_x_axis">Input x axis of csys to map from</param>
        /// <param name="from_y_axis">Input y axis of csys to map from</param>
        /// <param name="to_origin">Input origin of csys to map to</param>
        /// <param name="to_x_axis">Input x axis of csys to map to</param>
        /// <param name="to_y_axis">Input y axis of csys to map to</param>
        /// <param name="mtx">Output Returned matrix that can be used to
        ///     transform objects</param>
        public static void CsysToCsys(this UFMtx4 ufMtx4, Point3d from_origin, Vector3d from_x_axis,
            double[] from_y_axis, double[] to_origin, double[] to_x_axis, Vector3d to_y_axis, out Matrix4x4 mtx) =>
            ufMtx4.CsysToCsys(from_origin.ToArray(), from_x_axis.ToArray(), from_y_axis, to_origin, to_x_axis,
                to_y_axis.ToArray(), out mtx);

        /// <summary>
        ///     Returns the matrix which can be used to map from one csys to another.
        /// </summary>
        /// <remarks>
        ///     Refer to <see href="..ugopen_doc/uf_mtx/global.html#UF_MTX4_csys_to_csys">UF_MTX4_csys_to_csys</see> for documentation<br/>
        ///     <see href="..mapping/Uf2NxOpenNet.htm">Mapping Help</see><br/>
        ///     License requirements:None
        /// </remarks>
        /// <param name="ufMtx4"></param>
        /// <param name="from_origin">Input origin of csys to map from</param>
        /// <param name="from_x_axis">Input x axis of csys to map from</param>
        /// <param name="from_y_axis">Input y axis of csys to map from</param>
        /// <param name="to_origin">Input origin of csys to map to</param>
        /// <param name="to_x_axis">Input x axis of csys to map to</param>
        /// <param name="to_y_axis">Input y axis of csys to map to</param>
        /// <param name="mtx">Output Returned matrix that can be used to
        ///     transform objects</param>
        public static void CsysToCsys(this UFMtx4 ufMtx4, double[] from_origin, double[] from_x_axis,
            Vector3d from_y_axis, double[] to_origin, double[] to_x_axis, Vector3d to_y_axis, out Matrix4x4 mtx) =>
            ufMtx4.CsysToCsys(from_origin, from_x_axis, from_y_axis.ToArray(), to_origin, to_x_axis,
                to_y_axis.ToArray(), out mtx);

        /// <summary>
        ///     Returns the matrix which can be used to map from one csys to another.
        /// </summary>
        /// <remarks>
        ///     Refer to <see href="..ugopen_doc/uf_mtx/global.html#UF_MTX4_csys_to_csys">UF_MTX4_csys_to_csys</see> for documentation<br/>
        ///     <see href="..mapping/Uf2NxOpenNet.htm">Mapping Help</see><br/>
        ///     License requirements:None
        /// </remarks>
        /// <param name="ufMtx4"></param>
        /// <param name="from_origin">Input origin of csys to map from</param>
        /// <param name="from_x_axis">Input x axis of csys to map from</param>
        /// <param name="from_y_axis">Input y axis of csys to map from</param>
        /// <param name="to_origin">Input origin of csys to map to</param>
        /// <param name="to_x_axis">Input x axis of csys to map to</param>
        /// <param name="to_y_axis">Input y axis of csys to map to</param>
        /// <param name="mtx">Output Returned matrix that can be used to
        ///     transform objects</param>
        public static void CsysToCsys(this UFMtx4 ufMtx4, Point3d from_origin, double[] from_x_axis,
            Vector3d from_y_axis, double[] to_origin, double[] to_x_axis, Vector3d to_y_axis, out Matrix4x4 mtx) =>
            ufMtx4.CsysToCsys(from_origin.ToArray(), from_x_axis, from_y_axis.ToArray(), to_origin, to_x_axis,
                to_y_axis.ToArray(), out mtx);

        /// <summary>
        ///     Returns the matrix which can be used to map from one csys to another.
        /// </summary>
        /// <remarks>
        ///     Refer to <see href="..ugopen_doc/uf_mtx/global.html#UF_MTX4_csys_to_csys">UF_MTX4_csys_to_csys</see> for documentation<br/>
        ///     <see href="..mapping/Uf2NxOpenNet.htm">Mapping Help</see><br/>
        ///     License requirements:None
        /// </remarks>
        /// <param name="ufMtx4"></param>
        /// <param name="from_origin">Input origin of csys to map from</param>
        /// <param name="from_x_axis">Input x axis of csys to map from</param>
        /// <param name="from_y_axis">Input y axis of csys to map from</param>
        /// <param name="to_origin">Input origin of csys to map to</param>
        /// <param name="to_x_axis">Input x axis of csys to map to</param>
        /// <param name="to_y_axis">Input y axis of csys to map to</param>
        /// <param name="mtx">Output Returned matrix that can be used to
        ///     transform objects</param>
        public static void CsysToCsys(this UFMtx4 ufMtx4, double[] from_origin, Vector3d from_x_axis,
            Vector3d from_y_axis, double[] to_origin, double[] to_x_axis, Vector3d to_y_axis, out Matrix4x4 mtx) =>
            ufMtx4.CsysToCsys(from_origin, from_x_axis.ToArray(), from_y_axis.ToArray(), to_origin, to_x_axis,
                to_y_axis.ToArray(), out mtx);

        /// <summary>
        ///     Returns the matrix which can be used to map from one csys to another.
        /// </summary>
        /// <remarks>
        ///     Refer to <see href="..ugopen_doc/uf_mtx/global.html#UF_MTX4_csys_to_csys">UF_MTX4_csys_to_csys</see> for documentation<br/>
        ///     <see href="..mapping/Uf2NxOpenNet.htm">Mapping Help</see><br/>
        ///     License requirements:None
        /// </remarks>
        /// <param name="ufMtx4"></param>
        /// <param name="from_origin">Input origin of csys to map from</param>
        /// <param name="from_x_axis">Input x axis of csys to map from</param>
        /// <param name="from_y_axis">Input y axis of csys to map from</param>
        /// <param name="to_origin">Input origin of csys to map to</param>
        /// <param name="to_x_axis">Input x axis of csys to map to</param>
        /// <param name="to_y_axis">Input y axis of csys to map to</param>
        /// <param name="mtx">Output Returned matrix that can be used to
        ///     transform objects</param>
        public static void CsysToCsys(this UFMtx4 ufMtx4, Point3d from_origin, Vector3d from_x_axis,
            Vector3d from_y_axis, double[] to_origin, double[] to_x_axis, Vector3d to_y_axis, out Matrix4x4 mtx) =>
            ufMtx4.CsysToCsys(from_origin.ToArray(), from_x_axis.ToArray(), from_y_axis.ToArray(), to_origin, to_x_axis,
                to_y_axis.ToArray(), out mtx);

        /// <summary>
        ///     Returns the matrix which can be used to map from one csys to another.
        /// </summary>
        /// <remarks>
        ///     Refer to <see href="..ugopen_doc/uf_mtx/global.html#UF_MTX4_csys_to_csys">UF_MTX4_csys_to_csys</see> for documentation<br/>
        ///     <see href="..mapping/Uf2NxOpenNet.htm">Mapping Help</see><br/>
        ///     License requirements:None
        /// </remarks>
        /// <param name="ufMtx4"></param>
        /// <param name="from_origin">Input origin of csys to map from</param>
        /// <param name="from_x_axis">Input x axis of csys to map from</param>
        /// <param name="from_y_axis">Input y axis of csys to map from</param>
        /// <param name="to_origin">Input origin of csys to map to</param>
        /// <param name="to_x_axis">Input x axis of csys to map to</param>
        /// <param name="to_y_axis">Input y axis of csys to map to</param>
        /// <param name="mtx">Output Returned matrix that can be used to
        ///     transform objects</param>
        public static void CsysToCsys(this UFMtx4 ufMtx4, double[] from_origin, double[] from_x_axis,
            double[] from_y_axis, Point3d to_origin, double[] to_x_axis, Vector3d to_y_axis, out Matrix4x4 mtx) =>
            ufMtx4.CsysToCsys(from_origin, from_x_axis, from_y_axis, to_origin.ToArray(), to_x_axis,
                to_y_axis.ToArray(), out mtx);

        /// <summary>
        ///     Returns the matrix which can be used to map from one csys to another.
        /// </summary>
        /// <remarks>
        ///     Refer to <see href="..ugopen_doc/uf_mtx/global.html#UF_MTX4_csys_to_csys">UF_MTX4_csys_to_csys</see> for documentation<br/>
        ///     <see href="..mapping/Uf2NxOpenNet.htm">Mapping Help</see><br/>
        ///     License requirements:None
        /// </remarks>
        /// <param name="ufMtx4"></param>
        /// <param name="from_origin">Input origin of csys to map from</param>
        /// <param name="from_x_axis">Input x axis of csys to map from</param>
        /// <param name="from_y_axis">Input y axis of csys to map from</param>
        /// <param name="to_origin">Input origin of csys to map to</param>
        /// <param name="to_x_axis">Input x axis of csys to map to</param>
        /// <param name="to_y_axis">Input y axis of csys to map to</param>
        /// <param name="mtx">Output Returned matrix that can be used to
        ///     transform objects</param>
        public static void CsysToCsys(this UFMtx4 ufMtx4, Point3d from_origin, double[] from_x_axis,
            double[] from_y_axis, Point3d to_origin, double[] to_x_axis, Vector3d to_y_axis, out Matrix4x4 mtx) =>
            ufMtx4.CsysToCsys(from_origin.ToArray(), from_x_axis, from_y_axis, to_origin.ToArray(), to_x_axis,
                to_y_axis.ToArray(), out mtx);

        /// <summary>
        ///     Returns the matrix which can be used to map from one csys to another.
        /// </summary>
        /// <remarks>
        ///     Refer to <see href="..ugopen_doc/uf_mtx/global.html#UF_MTX4_csys_to_csys">UF_MTX4_csys_to_csys</see> for documentation<br/>
        ///     <see href="..mapping/Uf2NxOpenNet.htm">Mapping Help</see><br/>
        ///     License requirements:None
        /// </remarks>
        /// <param name="ufMtx4"></param>
        /// <param name="from_origin">Input origin of csys to map from</param>
        /// <param name="from_x_axis">Input x axis of csys to map from</param>
        /// <param name="from_y_axis">Input y axis of csys to map from</param>
        /// <param name="to_origin">Input origin of csys to map to</param>
        /// <param name="to_x_axis">Input x axis of csys to map to</param>
        /// <param name="to_y_axis">Input y axis of csys to map to</param>
        /// <param name="mtx">Output Returned matrix that can be used to
        ///     transform objects</param>
        public static void CsysToCsys(this UFMtx4 ufMtx4, double[] from_origin, Vector3d from_x_axis,
            double[] from_y_axis, Point3d to_origin, double[] to_x_axis, Vector3d to_y_axis, out Matrix4x4 mtx) =>
            ufMtx4.CsysToCsys(from_origin, from_x_axis.ToArray(), from_y_axis, to_origin.ToArray(), to_x_axis,
                to_y_axis.ToArray(), out mtx);

        /// <summary>
        ///     Returns the matrix which can be used to map from one csys to another.
        /// </summary>
        /// <remarks>
        ///     Refer to <see href="..ugopen_doc/uf_mtx/global.html#UF_MTX4_csys_to_csys">UF_MTX4_csys_to_csys</see> for documentation<br/>
        ///     <see href="..mapping/Uf2NxOpenNet.htm">Mapping Help</see><br/>
        ///     License requirements:None
        /// </remarks>
        /// <param name="ufMtx4"></param>
        /// <param name="from_origin">Input origin of csys to map from</param>
        /// <param name="from_x_axis">Input x axis of csys to map from</param>
        /// <param name="from_y_axis">Input y axis of csys to map from</param>
        /// <param name="to_origin">Input origin of csys to map to</param>
        /// <param name="to_x_axis">Input x axis of csys to map to</param>
        /// <param name="to_y_axis">Input y axis of csys to map to</param>
        /// <param name="mtx">Output Returned matrix that can be used to
        ///     transform objects</param>
        public static void CsysToCsys(this UFMtx4 ufMtx4, Point3d from_origin, Vector3d from_x_axis,
            double[] from_y_axis, Point3d to_origin, double[] to_x_axis, Vector3d to_y_axis, out Matrix4x4 mtx) =>
            ufMtx4.CsysToCsys(from_origin.ToArray(), from_x_axis.ToArray(), from_y_axis, to_origin.ToArray(), to_x_axis,
                to_y_axis.ToArray(), out mtx);

        /// <summary>
        ///     Returns the matrix which can be used to map from one csys to another.
        /// </summary>
        /// <remarks>
        ///     Refer to <see href="..ugopen_doc/uf_mtx/global.html#UF_MTX4_csys_to_csys">UF_MTX4_csys_to_csys</see> for documentation<br/>
        ///     <see href="..mapping/Uf2NxOpenNet.htm">Mapping Help</see><br/>
        ///     License requirements:None
        /// </remarks>
        /// <param name="ufMtx4"></param>
        /// <param name="from_origin">Input origin of csys to map from</param>
        /// <param name="from_x_axis">Input x axis of csys to map from</param>
        /// <param name="from_y_axis">Input y axis of csys to map from</param>
        /// <param name="to_origin">Input origin of csys to map to</param>
        /// <param name="to_x_axis">Input x axis of csys to map to</param>
        /// <param name="to_y_axis">Input y axis of csys to map to</param>
        /// <param name="mtx">Output Returned matrix that can be used to
        ///     transform objects</param>
        public static void CsysToCsys(this UFMtx4 ufMtx4, double[] from_origin, double[] from_x_axis,
            Vector3d from_y_axis, Point3d to_origin, double[] to_x_axis, Vector3d to_y_axis, out Matrix4x4 mtx) =>
            ufMtx4.CsysToCsys(from_origin, from_x_axis, from_y_axis.ToArray(), to_origin.ToArray(), to_x_axis,
                to_y_axis.ToArray(), out mtx);

        /// <summary>
        ///     Returns the matrix which can be used to map from one csys to another.
        /// </summary>
        /// <remarks>
        ///     Refer to <see href="..ugopen_doc/uf_mtx/global.html#UF_MTX4_csys_to_csys">UF_MTX4_csys_to_csys</see> for documentation<br/>
        ///     <see href="..mapping/Uf2NxOpenNet.htm">Mapping Help</see><br/>
        ///     License requirements:None
        /// </remarks>
        /// <param name="ufMtx4"></param>
        /// <param name="from_origin">Input origin of csys to map from</param>
        /// <param name="from_x_axis">Input x axis of csys to map from</param>
        /// <param name="from_y_axis">Input y axis of csys to map from</param>
        /// <param name="to_origin">Input origin of csys to map to</param>
        /// <param name="to_x_axis">Input x axis of csys to map to</param>
        /// <param name="to_y_axis">Input y axis of csys to map to</param>
        /// <param name="mtx">Output Returned matrix that can be used to
        ///     transform objects</param>
        public static void CsysToCsys(this UFMtx4 ufMtx4, Point3d from_origin, double[] from_x_axis,
            Vector3d from_y_axis, Point3d to_origin, double[] to_x_axis, Vector3d to_y_axis, out Matrix4x4 mtx) =>
            ufMtx4.CsysToCsys(from_origin.ToArray(), from_x_axis, from_y_axis.ToArray(), to_origin.ToArray(), to_x_axis,
                to_y_axis.ToArray(), out mtx);

        /// <summary>
        ///     Returns the matrix which can be used to map from one csys to another.
        /// </summary>
        /// <remarks>
        ///     Refer to <see href="..ugopen_doc/uf_mtx/global.html#UF_MTX4_csys_to_csys">UF_MTX4_csys_to_csys</see> for documentation<br/>
        ///     <see href="..mapping/Uf2NxOpenNet.htm">Mapping Help</see><br/>
        ///     License requirements:None
        /// </remarks>
        /// <param name="ufMtx4"></param>
        /// <param name="from_origin">Input origin of csys to map from</param>
        /// <param name="from_x_axis">Input x axis of csys to map from</param>
        /// <param name="from_y_axis">Input y axis of csys to map from</param>
        /// <param name="to_origin">Input origin of csys to map to</param>
        /// <param name="to_x_axis">Input x axis of csys to map to</param>
        /// <param name="to_y_axis">Input y axis of csys to map to</param>
        /// <param name="mtx">Output Returned matrix that can be used to
        ///     transform objects</param>
        public static void CsysToCsys(this UFMtx4 ufMtx4, double[] from_origin, Vector3d from_x_axis,
            Vector3d from_y_axis, Point3d to_origin, double[] to_x_axis, Vector3d to_y_axis, out Matrix4x4 mtx) =>
            ufMtx4.CsysToCsys(from_origin, from_x_axis.ToArray(), from_y_axis.ToArray(), to_origin.ToArray(), to_x_axis,
                to_y_axis.ToArray(), out mtx);

        /// <summary>
        ///     Returns the matrix which can be used to map from one csys to another.
        /// </summary>
        /// <remarks>
        ///     Refer to <see href="..ugopen_doc/uf_mtx/global.html#UF_MTX4_csys_to_csys">UF_MTX4_csys_to_csys</see> for documentation<br/>
        ///     <see href="..mapping/Uf2NxOpenNet.htm">Mapping Help</see><br/>
        ///     License requirements:None
        /// </remarks>
        /// <param name="ufMtx4"></param>
        /// <param name="from_origin">Input origin of csys to map from</param>
        /// <param name="from_x_axis">Input x axis of csys to map from</param>
        /// <param name="from_y_axis">Input y axis of csys to map from</param>
        /// <param name="to_origin">Input origin of csys to map to</param>
        /// <param name="to_x_axis">Input x axis of csys to map to</param>
        /// <param name="to_y_axis">Input y axis of csys to map to</param>
        /// <param name="mtx">Output Returned matrix that can be used to
        ///     transform objects</param>
        public static void CsysToCsys(this UFMtx4 ufMtx4, Point3d from_origin, Vector3d from_x_axis,
            Vector3d from_y_axis, Point3d to_origin, double[] to_x_axis, Vector3d to_y_axis, out Matrix4x4 mtx) =>
            ufMtx4.CsysToCsys(from_origin.ToArray(), from_x_axis.ToArray(), from_y_axis.ToArray(), to_origin.ToArray(),
                to_x_axis, to_y_axis.ToArray(), out mtx);

        /// <summary>
        ///     Returns the matrix which can be used to map from one csys to another.
        /// </summary>
        /// <remarks>
        ///     Refer to <see href="..ugopen_doc/uf_mtx/global.html#UF_MTX4_csys_to_csys">UF_MTX4_csys_to_csys</see> for documentation<br/>
        ///     <see href="..mapping/Uf2NxOpenNet.htm">Mapping Help</see><br/>
        ///     License requirements:None
        /// </remarks>
        /// <param name="ufMtx4"></param>
        /// <param name="from_origin">Input origin of csys to map from</param>
        /// <param name="from_x_axis">Input x axis of csys to map from</param>
        /// <param name="from_y_axis">Input y axis of csys to map from</param>
        /// <param name="to_origin">Input origin of csys to map to</param>
        /// <param name="to_x_axis">Input x axis of csys to map to</param>
        /// <param name="to_y_axis">Input y axis of csys to map to</param>
        /// <param name="mtx">Output Returned matrix that can be used to
        ///     transform objects</param>
        public static void CsysToCsys(this UFMtx4 ufMtx4, double[] from_origin, double[] from_x_axis,
            double[] from_y_axis, double[] to_origin, Vector3d to_x_axis, Vector3d to_y_axis, out Matrix4x4 mtx) =>
            ufMtx4.CsysToCsys(from_origin, from_x_axis, from_y_axis, to_origin, to_x_axis.ToArray(),
                to_y_axis.ToArray(), out mtx);

        /// <summary>
        ///     Returns the matrix which can be used to map from one csys to another.
        /// </summary>
        /// <remarks>
        ///     Refer to <see href="..ugopen_doc/uf_mtx/global.html#UF_MTX4_csys_to_csys">UF_MTX4_csys_to_csys</see> for documentation<br/>
        ///     <see href="..mapping/Uf2NxOpenNet.htm">Mapping Help</see><br/>
        ///     License requirements:None
        /// </remarks>
        /// <param name="ufMtx4"></param>
        /// <param name="from_origin">Input origin of csys to map from</param>
        /// <param name="from_x_axis">Input x axis of csys to map from</param>
        /// <param name="from_y_axis">Input y axis of csys to map from</param>
        /// <param name="to_origin">Input origin of csys to map to</param>
        /// <param name="to_x_axis">Input x axis of csys to map to</param>
        /// <param name="to_y_axis">Input y axis of csys to map to</param>
        /// <param name="mtx">Output Returned matrix that can be used to
        ///     transform objects</param>
        public static void CsysToCsys(this UFMtx4 ufMtx4, Point3d from_origin, double[] from_x_axis,
            double[] from_y_axis, double[] to_origin, Vector3d to_x_axis, Vector3d to_y_axis, out Matrix4x4 mtx) =>
            ufMtx4.CsysToCsys(from_origin.ToArray(), from_x_axis, from_y_axis, to_origin, to_x_axis.ToArray(),
                to_y_axis.ToArray(), out mtx);

        /// <summary>
        ///     Returns the matrix which can be used to map from one csys to another.
        /// </summary>
        /// <remarks>
        ///     Refer to <see href="..ugopen_doc/uf_mtx/global.html#UF_MTX4_csys_to_csys">UF_MTX4_csys_to_csys</see> for documentation<br/>
        ///     <see href="..mapping/Uf2NxOpenNet.htm">Mapping Help</see><br/>
        ///     License requirements:None
        /// </remarks>
        /// <param name="ufMtx4"></param>
        /// <param name="from_origin">Input origin of csys to map from</param>
        /// <param name="from_x_axis">Input x axis of csys to map from</param>
        /// <param name="from_y_axis">Input y axis of csys to map from</param>
        /// <param name="to_origin">Input origin of csys to map to</param>
        /// <param name="to_x_axis">Input x axis of csys to map to</param>
        /// <param name="to_y_axis">Input y axis of csys to map to</param>
        /// <param name="mtx">Output Returned matrix that can be used to
        ///     transform objects</param>
        public static void CsysToCsys(this UFMtx4 ufMtx4, double[] from_origin, Vector3d from_x_axis,
            double[] from_y_axis, double[] to_origin, Vector3d to_x_axis, Vector3d to_y_axis, out Matrix4x4 mtx) =>
            ufMtx4.CsysToCsys(from_origin, from_x_axis.ToArray(), from_y_axis, to_origin, to_x_axis.ToArray(),
                to_y_axis.ToArray(), out mtx);

        /// <summary>
        ///     Returns the matrix which can be used to map from one csys to another.
        /// </summary>
        /// <remarks>
        ///     Refer to <see href="..ugopen_doc/uf_mtx/global.html#UF_MTX4_csys_to_csys">UF_MTX4_csys_to_csys</see> for documentation<br/>
        ///     <see href="..mapping/Uf2NxOpenNet.htm">Mapping Help</see><br/>
        ///     License requirements:None
        /// </remarks>
        /// <param name="ufMtx4"></param>
        /// <param name="from_origin">Input origin of csys to map from</param>
        /// <param name="from_x_axis">Input x axis of csys to map from</param>
        /// <param name="from_y_axis">Input y axis of csys to map from</param>
        /// <param name="to_origin">Input origin of csys to map to</param>
        /// <param name="to_x_axis">Input x axis of csys to map to</param>
        /// <param name="to_y_axis">Input y axis of csys to map to</param>
        /// <param name="mtx">Output Returned matrix that can be used to
        ///     transform objects</param>
        public static void CsysToCsys(this UFMtx4 ufMtx4, Point3d from_origin, Vector3d from_x_axis,
            double[] from_y_axis, double[] to_origin, Vector3d to_x_axis, Vector3d to_y_axis, out Matrix4x4 mtx) =>
            ufMtx4.CsysToCsys(from_origin.ToArray(), from_x_axis.ToArray(), from_y_axis, to_origin, to_x_axis.ToArray(),
                to_y_axis.ToArray(), out mtx);

        /// <summary>
        ///     Returns the matrix which can be used to map from one csys to another.
        /// </summary>
        /// <remarks>
        ///     Refer to <see href="..ugopen_doc/uf_mtx/global.html#UF_MTX4_csys_to_csys">UF_MTX4_csys_to_csys</see> for documentation<br/>
        ///     <see href="..mapping/Uf2NxOpenNet.htm">Mapping Help</see><br/>
        ///     License requirements:None
        /// </remarks>
        /// <param name="ufMtx4"></param>
        /// <param name="from_origin">Input origin of csys to map from</param>
        /// <param name="from_x_axis">Input x axis of csys to map from</param>
        /// <param name="from_y_axis">Input y axis of csys to map from</param>
        /// <param name="to_origin">Input origin of csys to map to</param>
        /// <param name="to_x_axis">Input x axis of csys to map to</param>
        /// <param name="to_y_axis">Input y axis of csys to map to</param>
        /// <param name="mtx">Output Returned matrix that can be used to
        ///     transform objects</param>
        public static void CsysToCsys(this UFMtx4 ufMtx4, double[] from_origin, double[] from_x_axis,
            Vector3d from_y_axis, double[] to_origin, Vector3d to_x_axis, Vector3d to_y_axis, out Matrix4x4 mtx) =>
            ufMtx4.CsysToCsys(from_origin, from_x_axis, from_y_axis.ToArray(), to_origin, to_x_axis.ToArray(),
                to_y_axis.ToArray(), out mtx);

        /// <summary>
        ///     Returns the matrix which can be used to map from one csys to another.
        /// </summary>
        /// <remarks>
        ///     Refer to <see href="..ugopen_doc/uf_mtx/global.html#UF_MTX4_csys_to_csys">UF_MTX4_csys_to_csys</see> for documentation<br/>
        ///     <see href="..mapping/Uf2NxOpenNet.htm">Mapping Help</see><br/>
        ///     License requirements:None
        /// </remarks>
        /// <param name="ufMtx4"></param>
        /// <param name="from_origin">Input origin of csys to map from</param>
        /// <param name="from_x_axis">Input x axis of csys to map from</param>
        /// <param name="from_y_axis">Input y axis of csys to map from</param>
        /// <param name="to_origin">Input origin of csys to map to</param>
        /// <param name="to_x_axis">Input x axis of csys to map to</param>
        /// <param name="to_y_axis">Input y axis of csys to map to</param>
        /// <param name="mtx">Output Returned matrix that can be used to
        ///     transform objects</param>
        public static void CsysToCsys(this UFMtx4 ufMtx4, Point3d from_origin, double[] from_x_axis,
            Vector3d from_y_axis, double[] to_origin, Vector3d to_x_axis, Vector3d to_y_axis, out Matrix4x4 mtx) =>
            ufMtx4.CsysToCsys(from_origin.ToArray(), from_x_axis, from_y_axis.ToArray(), to_origin, to_x_axis.ToArray(),
                to_y_axis.ToArray(), out mtx);

        /// <summary>
        ///     Returns the matrix which can be used to map from one csys to another.
        /// </summary>
        /// <remarks>
        ///     Refer to <see href="..ugopen_doc/uf_mtx/global.html#UF_MTX4_csys_to_csys">UF_MTX4_csys_to_csys</see> for documentation<br/>
        ///     <see href="..mapping/Uf2NxOpenNet.htm">Mapping Help</see><br/>
        ///     License requirements:None
        /// </remarks>
        /// <param name="ufMtx4"></param>
        /// <param name="from_origin">Input origin of csys to map from</param>
        /// <param name="from_x_axis">Input x axis of csys to map from</param>
        /// <param name="from_y_axis">Input y axis of csys to map from</param>
        /// <param name="to_origin">Input origin of csys to map to</param>
        /// <param name="to_x_axis">Input x axis of csys to map to</param>
        /// <param name="to_y_axis">Input y axis of csys to map to</param>
        /// <param name="mtx">Output Returned matrix that can be used to
        ///     transform objects</param>
        public static void CsysToCsys(this UFMtx4 ufMtx4, double[] from_origin, Vector3d from_x_axis,
            Vector3d from_y_axis, double[] to_origin, Vector3d to_x_axis, Vector3d to_y_axis, out Matrix4x4 mtx) =>
            ufMtx4.CsysToCsys(from_origin, from_x_axis.ToArray(), from_y_axis.ToArray(), to_origin, to_x_axis.ToArray(),
                to_y_axis.ToArray(), out mtx);

        /// <summary>
        ///     Returns the matrix which can be used to map from one csys to another.
        /// </summary>
        /// <remarks>
        ///     Refer to <see href="..ugopen_doc/uf_mtx/global.html#UF_MTX4_csys_to_csys">UF_MTX4_csys_to_csys</see> for documentation<br/>
        ///     <see href="..mapping/Uf2NxOpenNet.htm">Mapping Help</see><br/>
        ///     License requirements:None
        /// </remarks>
        /// <param name="ufMtx4"></param>
        /// <param name="from_origin">Input origin of csys to map from</param>
        /// <param name="from_x_axis">Input x axis of csys to map from</param>
        /// <param name="from_y_axis">Input y axis of csys to map from</param>
        /// <param name="to_origin">Input origin of csys to map to</param>
        /// <param name="to_x_axis">Input x axis of csys to map to</param>
        /// <param name="to_y_axis">Input y axis of csys to map to</param>
        /// <param name="mtx">Output Returned matrix that can be used to
        ///     transform objects</param>
        public static void CsysToCsys(this UFMtx4 ufMtx4, Point3d from_origin, Vector3d from_x_axis,
            Vector3d from_y_axis, double[] to_origin, Vector3d to_x_axis, Vector3d to_y_axis, out Matrix4x4 mtx) =>
            ufMtx4.CsysToCsys(from_origin.ToArray(), from_x_axis.ToArray(), from_y_axis.ToArray(), to_origin,
                to_x_axis.ToArray(), to_y_axis.ToArray(), out mtx);

        /// <summary>
        ///     Returns the matrix which can be used to map from one csys to another.
        /// </summary>
        /// <remarks>
        ///     Refer to <see href="..ugopen_doc/uf_mtx/global.html#UF_MTX4_csys_to_csys">UF_MTX4_csys_to_csys</see> for documentation<br/>
        ///     <see href="..mapping/Uf2NxOpenNet.htm">Mapping Help</see><br/>
        ///     License requirements:None
        /// </remarks>
        /// <param name="ufMtx4"></param>
        /// <param name="from_origin">Input origin of csys to map from</param>
        /// <param name="from_x_axis">Input x axis of csys to map from</param>
        /// <param name="from_y_axis">Input y axis of csys to map from</param>
        /// <param name="to_origin">Input origin of csys to map to</param>
        /// <param name="to_x_axis">Input x axis of csys to map to</param>
        /// <param name="to_y_axis">Input y axis of csys to map to</param>
        /// <param name="mtx">Output Returned matrix that can be used to
        ///     transform objects</param>
        public static void CsysToCsys(this UFMtx4 ufMtx4, double[] from_origin, double[] from_x_axis,
            double[] from_y_axis, Point3d to_origin, Vector3d to_x_axis, Vector3d to_y_axis, out Matrix4x4 mtx) =>
            ufMtx4.CsysToCsys(from_origin, from_x_axis, from_y_axis, to_origin.ToArray(), to_x_axis.ToArray(),
                to_y_axis.ToArray(), out mtx);

        /// <summary>
        ///     Returns the matrix which can be used to map from one csys to another.
        /// </summary>
        /// <remarks>
        ///     Refer to <see href="..ugopen_doc/uf_mtx/global.html#UF_MTX4_csys_to_csys">UF_MTX4_csys_to_csys</see> for documentation<br/>
        ///     <see href="..mapping/Uf2NxOpenNet.htm">Mapping Help</see><br/>
        ///     License requirements:None
        /// </remarks>
        /// <param name="ufMtx4"></param>
        /// <param name="from_origin">Input origin of csys to map from</param>
        /// <param name="from_x_axis">Input x axis of csys to map from</param>
        /// <param name="from_y_axis">Input y axis of csys to map from</param>
        /// <param name="to_origin">Input origin of csys to map to</param>
        /// <param name="to_x_axis">Input x axis of csys to map to</param>
        /// <param name="to_y_axis">Input y axis of csys to map to</param>
        /// <param name="mtx">Output Returned matrix that can be used to
        ///     transform objects</param>
        public static void CsysToCsys(this UFMtx4 ufMtx4, Point3d from_origin, double[] from_x_axis,
            double[] from_y_axis, Point3d to_origin, Vector3d to_x_axis, Vector3d to_y_axis, out Matrix4x4 mtx) =>
            ufMtx4.CsysToCsys(from_origin.ToArray(), from_x_axis, from_y_axis, to_origin.ToArray(), to_x_axis.ToArray(),
                to_y_axis.ToArray(), out mtx);

        /// <summary>
        ///     Returns the matrix which can be used to map from one csys to another.
        /// </summary>
        /// <remarks>
        ///     Refer to <see href="..ugopen_doc/uf_mtx/global.html#UF_MTX4_csys_to_csys">UF_MTX4_csys_to_csys</see> for documentation<br/>
        ///     <see href="..mapping/Uf2NxOpenNet.htm">Mapping Help</see><br/>
        ///     License requirements:None
        /// </remarks>
        /// <param name="ufMtx4"></param>
        /// <param name="from_origin">Input origin of csys to map from</param>
        /// <param name="from_x_axis">Input x axis of csys to map from</param>
        /// <param name="from_y_axis">Input y axis of csys to map from</param>
        /// <param name="to_origin">Input origin of csys to map to</param>
        /// <param name="to_x_axis">Input x axis of csys to map to</param>
        /// <param name="to_y_axis">Input y axis of csys to map to</param>
        /// <param name="mtx">Output Returned matrix that can be used to
        ///     transform objects</param>
        public static void CsysToCsys(this UFMtx4 ufMtx4, double[] from_origin, Vector3d from_x_axis,
            double[] from_y_axis, Point3d to_origin, Vector3d to_x_axis, Vector3d to_y_axis, out Matrix4x4 mtx) =>
            ufMtx4.CsysToCsys(from_origin, from_x_axis.ToArray(), from_y_axis, to_origin.ToArray(), to_x_axis.ToArray(),
                to_y_axis.ToArray(), out mtx);

        /// <summary>
        ///     Returns the matrix which can be used to map from one csys to another.
        /// </summary>
        /// <remarks>
        ///     Refer to <see href="..ugopen_doc/uf_mtx/global.html#UF_MTX4_csys_to_csys">UF_MTX4_csys_to_csys</see> for documentation<br/>
        ///     <see href="..mapping/Uf2NxOpenNet.htm">Mapping Help</see><br/>
        ///     License requirements:None
        /// </remarks>
        /// <param name="ufMtx4"></param>
        /// <param name="from_origin">Input origin of csys to map from</param>
        /// <param name="from_x_axis">Input x axis of csys to map from</param>
        /// <param name="from_y_axis">Input y axis of csys to map from</param>
        /// <param name="to_origin">Input origin of csys to map to</param>
        /// <param name="to_x_axis">Input x axis of csys to map to</param>
        /// <param name="to_y_axis">Input y axis of csys to map to</param>
        /// <param name="mtx">Output Returned matrix that can be used to
        ///     transform objects</param>
        public static void CsysToCsys(this UFMtx4 ufMtx4, Point3d from_origin, Vector3d from_x_axis,
            double[] from_y_axis, Point3d to_origin, Vector3d to_x_axis, Vector3d to_y_axis, out Matrix4x4 mtx) =>
            ufMtx4.CsysToCsys(from_origin.ToArray(), from_x_axis.ToArray(), from_y_axis, to_origin.ToArray(),
                to_x_axis.ToArray(), to_y_axis.ToArray(), out mtx);

        /// <summary>
        ///     Returns the matrix which can be used to map from one csys to another.
        /// </summary>
        /// <remarks>
        ///     Refer to <see href="..ugopen_doc/uf_mtx/global.html#UF_MTX4_csys_to_csys">UF_MTX4_csys_to_csys</see> for documentation<br/>
        ///     <see href="..mapping/Uf2NxOpenNet.htm">Mapping Help</see><br/>
        ///     License requirements:None
        /// </remarks>
        /// <param name="ufMtx4"></param>
        /// <param name="from_origin">Input origin of csys to map from</param>
        /// <param name="from_x_axis">Input x axis of csys to map from</param>
        /// <param name="from_y_axis">Input y axis of csys to map from</param>
        /// <param name="to_origin">Input origin of csys to map to</param>
        /// <param name="to_x_axis">Input x axis of csys to map to</param>
        /// <param name="to_y_axis">Input y axis of csys to map to</param>
        /// <param name="mtx">Output Returned matrix that can be used to
        ///     transform objects</param>
        public static void CsysToCsys(this UFMtx4 ufMtx4, double[] from_origin, double[] from_x_axis,
            Vector3d from_y_axis, Point3d to_origin, Vector3d to_x_axis, Vector3d to_y_axis, out Matrix4x4 mtx) =>
            ufMtx4.CsysToCsys(from_origin, from_x_axis, from_y_axis.ToArray(), to_origin.ToArray(), to_x_axis.ToArray(),
                to_y_axis.ToArray(), out mtx);

        /// <summary>
        ///     Returns the matrix which can be used to map from one csys to another.
        /// </summary>
        /// <remarks>
        ///     Refer to <see href="..ugopen_doc/uf_mtx/global.html#UF_MTX4_csys_to_csys">UF_MTX4_csys_to_csys</see> for documentation<br/>
        ///     <see href="..mapping/Uf2NxOpenNet.htm">Mapping Help</see><br/>
        ///     License requirements:None
        /// </remarks>
        /// <param name="ufMtx4"></param>
        /// <param name="from_origin">Input origin of csys to map from</param>
        /// <param name="from_x_axis">Input x axis of csys to map from</param>
        /// <param name="from_y_axis">Input y axis of csys to map from</param>
        /// <param name="to_origin">Input origin of csys to map to</param>
        /// <param name="to_x_axis">Input x axis of csys to map to</param>
        /// <param name="to_y_axis">Input y axis of csys to map to</param>
        /// <param name="mtx">Output Returned matrix that can be used to
        ///     transform objects</param>
        public static void CsysToCsys(this UFMtx4 ufMtx4, Point3d from_origin, double[] from_x_axis,
            Vector3d from_y_axis, Point3d to_origin, Vector3d to_x_axis, Vector3d to_y_axis, out Matrix4x4 mtx) =>
            ufMtx4.CsysToCsys(from_origin.ToArray(), from_x_axis, from_y_axis.ToArray(), to_origin.ToArray(),
                to_x_axis.ToArray(), to_y_axis.ToArray(), out mtx);

        /// <summary>
        ///     Returns the matrix which can be used to map from one csys to another.
        /// </summary>
        /// <remarks>
        ///     Refer to <see href="..ugopen_doc/uf_mtx/global.html#UF_MTX4_csys_to_csys">UF_MTX4_csys_to_csys</see> for documentation<br/>
        ///     <see href="..mapping/Uf2NxOpenNet.htm">Mapping Help</see><br/>
        ///     License requirements:None
        /// </remarks>
        /// <param name="ufMtx4"></param>
        /// <param name="from_origin">Input origin of csys to map from</param>
        /// <param name="from_x_axis">Input x axis of csys to map from</param>
        /// <param name="from_y_axis">Input y axis of csys to map from</param>
        /// <param name="to_origin">Input origin of csys to map to</param>
        /// <param name="to_x_axis">Input x axis of csys to map to</param>
        /// <param name="to_y_axis">Input y axis of csys to map to</param>
        /// <param name="mtx">Output Returned matrix that can be used to
        ///     transform objects</param>
        public static void CsysToCsys(this UFMtx4 ufMtx4, double[] from_origin, Vector3d from_x_axis,
            Vector3d from_y_axis, Point3d to_origin, Vector3d to_x_axis, Vector3d to_y_axis, out Matrix4x4 mtx) =>
            ufMtx4.CsysToCsys(from_origin, from_x_axis.ToArray(), from_y_axis.ToArray(), to_origin.ToArray(),
                to_x_axis.ToArray(), to_y_axis.ToArray(), out mtx);

        /// <summary>
        ///     Returns the matrix which can be used to map from one csys to another.
        /// </summary>
        /// <remarks>
        ///     Refer to <see href="..ugopen_doc/uf_mtx/global.html#UF_MTX4_csys_to_csys">UF_MTX4_csys_to_csys</see> for documentation<br/>
        ///     <see href="..mapping/Uf2NxOpenNet.htm">Mapping Help</see><br/>
        ///     License requirements:None
        /// </remarks>
        /// <param name="ufMtx4"></param>
        /// <param name="from_origin">Input origin of csys to map from</param>
        /// <param name="from_x_axis">Input x axis of csys to map from</param>
        /// <param name="from_y_axis">Input y axis of csys to map from</param>
        /// <param name="to_origin">Input origin of csys to map to</param>
        /// <param name="to_x_axis">Input x axis of csys to map to</param>
        /// <param name="to_y_axis">Input y axis of csys to map to</param>
        /// <param name="mtx">Output Returned matrix that can be used to
        ///     transform objects</param>
        public static void CsysToCsys(this UFMtx4 ufMtx4, Point3d from_origin, Vector3d from_x_axis,
            Vector3d from_y_axis, Point3d to_origin, Vector3d to_x_axis, Vector3d to_y_axis, out Matrix4x4 mtx) =>
            ufMtx4.CsysToCsys(from_origin.ToArray(), from_x_axis.ToArray(), from_y_axis.ToArray(), to_origin.ToArray(),
                to_x_axis.ToArray(), to_y_axis.ToArray(), out mtx);

        /// <summary>
        ///     Returns the matrix which can be used to map from one csys to another.
        /// </summary>
        /// <remarks>
        ///     Refer to <see href="..ugopen_doc/uf_mtx/global.html#UF_MTX4_csys_to_csys">UF_MTX4_csys_to_csys</see> for documentation<br/>
        ///     <see href="..mapping/Uf2NxOpenNet.htm">Mapping Help</see><br/>
        ///     License requirements:None
        ///</remarks>
        /// <param name="ufMtx4"></param>
        /// <param name="from_csys">Input csys to map from</param>
        /// <param name="to_csys">Input csys to map to</param>
        /// <param name="mtx">Output Returned matrix that can be used to
        ///     transform objects</param>
        public static void CsysToCsys(this UFMtx4 ufMtx4, CoordinateSystem from_csys, CoordinateSystem to_csys,
            out Matrix4x4 mtx)
        {
            from_csys.GetDirections(out Vector3d from_x_axis, out Vector3d from_y_axis);
            to_csys.GetDirections(out Vector3d to_x_axis, out Vector3d to_y_axis);

            ufMtx4.CsysToCsys(from_csys.Origin, from_x_axis, from_y_axis,
                to_csys.Origin, to_x_axis, to_y_axis, out mtx);
        }

        /// <summary>
        ///     Edits the 3x3 rotation matrix of a 4 x 4 matrix.
        /// </summary>
        /// <remarks>
        ///     Refer to <see href="..ugopen_doc/uf_mtx/global.html#UF_MTX4_edit_rotation">UF_MTX4_edit_rotation</see> for documentation<br/>
        ///     <see href="..mapping/Uf2NxOpenNet.htm">Mapping Help</see><br/>
        ///     License requirements:None
        /// </remarks>
        /// <param name="ufMtx4"></param>
        /// <param name="mtx_4D">Input / Output 4x4 matrix whose rotation is to be edited. (Input)
        ///     4x4 with an edited 3x3 rotation matrix. (Output)</param>
        /// <param name="mtx_3D">Input 3x3 rotation matrix to use as replacement in 4x4
        ///     matrix.</param>
        public static void EditRotation(this UFMtx4 ufMtx4, ref Matrix4x4 mtx_4D, double[] mtx_3D)
        {
            double[] matrix = mtx_4D.ToArray();

            ufMtx4.EditRotation(matrix, mtx_3D);

            mtx_4D = new Matrix4x4(matrix[0], matrix[1], matrix[2], matrix[3], matrix[4], matrix[5], matrix[6],
                matrix[7], matrix[8], matrix[9], matrix[10], matrix[11], matrix[12], matrix[13], matrix[14],
                matrix[15]);
        }

        /// <summary>
        ///     Edits the 3x3 rotation matrix of a 4 x 4 matrix.
        /// </summary>
        /// <remarks>
        ///     Refer to <see href="..ugopen_doc/uf_mtx/global.html#UF_MTX4_edit_rotation">UF_MTX4_edit_rotation</see> for documentation<br/>
        ///     <see href="..mapping/Uf2NxOpenNet.htm">Mapping Help</see><br/>
        ///     License requirements:None
        /// </remarks>
        /// <param name="ufMtx4"></param>
        /// <param name="mtx_4D">Input / Output 4x4 matrix whose rotation is to be edited. (Input)
        ///     4x4 with an edited 3x3 rotation matrix. (Output)</param>
        /// <param name="mtx_3D">Input 3x3 rotation matrix to use as replacement in 4x4
        ///     matrix.</param>
        public static void EditRotation(this UFMtx4 ufMtx4, ref Matrix4x4 mtx_4D, Matrix3x3 mtx_3D) =>
            ufMtx4.EditRotation(ref mtx_4D, mtx_3D.ToArray());

        /// <summary>
        ///     Edits the 3x3 scale factor of a 4 x 4 matrix.
        /// </summary>
        /// <remarks>
        ///     Refer to <see href="..ugopen_doc/uf_mtx/global.html#UF_MTX4_edit_scale">UF_MTX4_edit_scale</see> for documentation<br/>
        ///     <see href="..mapping/Uf2NxOpenNet.htm">Mapping Help</see><br/>
        ///     License requirements:None
        /// </remarks>
        /// <param name="ufMtx4"></param>
        /// <param name="mtx">Input / Output 4x4 matrix whose scale is to be edited. (Input)
        ///     4x4 with an edited 3x3 scale factor. (Output)</param>
        /// <param name="scale">Input Scale factor to use as replacement in 4x4 matrix.</param>
        public static void EditScale(this UFMtx4 ufMtx4, ref Matrix4x4 mtx, double scale)
        {
            double[] matrix = mtx.ToArray();

            ufMtx4.EditScale(matrix, scale);

            mtx = new Matrix4x4(matrix[0], matrix[1], matrix[2], matrix[3], matrix[4], matrix[5], matrix[6],
                matrix[7], matrix[8], matrix[9], matrix[10], matrix[11], matrix[12], matrix[13], matrix[14],
                matrix[15]);
        }

        /// <summary>
        ///     Edits the translation vector of a 4 x 4 matrix.
        /// </summary>
        /// <remarks>
        ///     Refer to <see href="..ugopen_doc/uf_mtx/global.html#UF_MTX4_edit_translation">UF_MTX4_edit_translation</see> for documentation<br/>
        ///     <see href="..mapping/Uf2NxOpenNet.htm">Mapping Help</see><br/>
        ///     License requirements:None
        /// </remarks>
        /// <param name="ufMtx4"></param>
        /// <param name="mtx">Input / Output 4x4 matrix whose translation is to be edited. (Input)
        ///     4x4 with an edited translation vector. (Output)</param>
        /// <param name="translate_vec">Input Translation vector to use as replacement in 4x4
        ///     matrix.</param>
        public static void EditTranslation(this UFMtx4 ufMtx4, ref Matrix4x4 mtx, double[] translate_vec)
        {
            double[] matrix = mtx.ToArray();

            ufMtx4.EditTranslation(matrix, translate_vec);

            mtx = new Matrix4x4(matrix[0], matrix[1], matrix[2], matrix[3], matrix[4], matrix[5], matrix[6],
                matrix[7], matrix[8], matrix[9], matrix[10], matrix[11], matrix[12], matrix[13], matrix[14],
                matrix[15]);
        }

        /// <summary>
        ///     Edits the translation vector of a 4 x 4 matrix.
        /// </summary>
        /// <remarks>
        ///     Refer to <see href="..ugopen_doc/uf_mtx/global.html#UF_MTX4_edit_translation">UF_MTX4_edit_translation</see> for documentation<br/>
        ///     <see href="..mapping/Uf2NxOpenNet.htm">Mapping Help</see><br/>
        ///     License requirements:None
        /// </remarks>
        /// <param name="ufMtx4"></param>
        /// <param name="mtx">Input / Output 4x4 matrix whose translation is to be edited. (Input)
        ///     4x4 with an edited translation vector. (Output)</param>
        /// <param name="translate_vec">Input Translation vector to use as replacement in 4x4
        ///     matrix.</param>
        public static void EditTranslation(this UFMtx4 ufMtx4, ref Matrix4x4 mtx, Vector3d translate_vec) =>
            ufMtx4.EditTranslation(ref mtx, translate_vec.ToArray());

        /// <summary>
        ///     Returns a 4 x 4 identity matrix.
        /// </summary>
        /// <remarks>
        ///     Refer to <see href="..ugopen_doc/uf_mtx/global.html#UF_MTX4_identity">UF_MTX4_identity</see> for documentation<br/>
        ///     <see href="..mapping/Uf2NxOpenNet.htm">Mapping Help</see><br/>
        ///     License requirements:None
        /// </remarks>
        /// <param name="ufMtx4"></param>
        /// <param name="mtx">Output Identity Matrix</param>
        public static void Identity(this UFMtx4 ufMtx4, out double[] mtx)
        {
            mtx = new double[16];

            ufMtx4.Identity(mtx);
        }

        /// <summary>
            ///     Returns a 4 x 4 identity matrix.
            /// </summary>
            /// <remarks>
            ///     Refer to <see href="..ugopen_doc/uf_mtx/global.html#UF_MTX4_identity">UF_MTX4_identity</see> for documentation<br/>
            ///     <see href="..mapping/Uf2NxOpenNet.htm">Mapping Help</see><br/>
            ///     License requirements:None
            /// </remarks>
            /// <param name="ufMtx4"></param>
            /// <param name="mtx">Output Identity Matrix</param>
        public static void Identity(this UFMtx4 ufMtx4, out Matrix4x4 mtx)
        {
            ufMtx4.Identity(out double[] matrix);
            
            mtx = new Matrix4x4(matrix[0], matrix[1], matrix[2], matrix[3], matrix[4], matrix[5], matrix[6],
                matrix[7], matrix[8], matrix[9], matrix[10], matrix[11], matrix[12], matrix[13], matrix[14],
                matrix[15]);
        }

        /// <summary>
        ///     Returns the 4x4 matrix formed from a 3x3 rotation matrix, a 3D
        ///     translation vector, and a scale factor.
        /// </summary>
        /// <remarks>
        ///     Refer to <see href="..ugopen_doc/uf_mtx/global.html#UF_MTX4_initialize">UF_MTX4_initialize</see> for documentation<br/>
        ///     <see href="..mapping/Uf2NxOpenNet.htm">Mapping Help</see><br/>
        ///     License requirements:None
        /// </remarks>
        /// <param name="ufMtx4"></param>
        /// <param name="scale">Input Scale factor</param>
        /// <param name="translation_vec">Input Translation vector</param>
        /// <param name="mtx_3d">Input 3x3 rotation matrix</param>
        /// <param name="mtx_4D">Output 4x4 matrix</param>
        public static void Initialize(this UFMtx4 ufMtx4, double scale, double[] translation_vec, double[] mtx_3d,
            out double[] mtx_4D)
        {
            mtx_4D = new double[16];

            ufMtx4.Initialize(scale, translation_vec, mtx_3d, mtx_4D);
        }

        /// <summary>
        ///     Returns the 4x4 matrix formed from a 3x3 rotation matrix, a 3D
        ///     translation vector, and a scale factor.
        /// </summary>
        /// <remarks>
        ///     Refer to <see href="..ugopen_doc/uf_mtx/global.html#UF_MTX4_initialize">UF_MTX4_initialize</see> for documentation<br/>
        ///     <see href="..mapping/Uf2NxOpenNet.htm">Mapping Help</see><br/>
        ///     License requirements:None
        /// </remarks>
        /// <param name="ufMtx4"></param>
        /// <param name="scale">Input Scale factor</param>
        /// <param name="translation_vec">Input Translation vector</param>
        /// <param name="mtx_3d">Input 3x3 rotation matrix</param>
        /// <param name="mtx_4D">Output 4x4 matrix</param>
        public static void Initialize(this UFMtx4 ufMtx4, double scale, double[] translation_vec, double[] mtx_3d,
            out Matrix4x4 mtx_4D)
        {
            ufMtx4.Initialize(scale, translation_vec, mtx_3d, out double[] matrix);

            mtx_4D = new Matrix4x4(matrix[0], matrix[1], matrix[2], matrix[3], matrix[4], matrix[5], matrix[6],
                matrix[7], matrix[8], matrix[9], matrix[10], matrix[11], matrix[12], matrix[13], matrix[14],
                matrix[15]);
        }

        /// <summary>
        ///     Returns the 4x4 matrix formed from a 3x3 rotation matrix, a 3D
        ///     translation vector, and a scale factor.
        /// </summary>
        /// <remarks>
        ///     Refer to <see href="..ugopen_doc/uf_mtx/global.html#UF_MTX4_initialize">UF_MTX4_initialize</see> for documentation<br/>
        ///     <see href="..mapping/Uf2NxOpenNet.htm">Mapping Help</see><br/>
        ///     License requirements:None
        /// </remarks>
        /// <param name="ufMtx4"></param>
        /// <param name="scale">Input Scale factor</param>
        /// <param name="translation_vec">Input Translation vector</param>
        /// <param name="mtx_3d">Input 3x3 rotation matrix</param>
        /// <param name="mtx_4D">Output 4x4 matrix</param>
        public static void Initialize(this UFMtx4 ufMtx4, double scale, Vector3d translation_vec, double[] mtx_3d,
            out Matrix4x4 mtx_4D) => ufMtx4.Initialize(scale, translation_vec.ToArray(), mtx_3d, out mtx_4D);

        /// <summary>
        ///     Returns the 4x4 matrix formed from a 3x3 rotation matrix, a 3D
        ///     translation vector, and a scale factor.
        /// </summary>
        /// <remarks>
        ///     Refer to <see href="..ugopen_doc/uf_mtx/global.html#UF_MTX4_initialize">UF_MTX4_initialize</see> for documentation<br/>
        ///     <see href="..mapping/Uf2NxOpenNet.htm">Mapping Help</see><br/>
        ///     License requirements:None
        /// </remarks>
        /// <param name="ufMtx4"></param>
        /// <param name="scale">Input Scale factor</param>
        /// <param name="translation_vec">Input Translation vector</param>
        /// <param name="mtx_3d">Input 3x3 rotation matrix</param>
        /// <param name="mtx_4D">Output 4x4 matrix</param>
        public static void Initialize(this UFMtx4 ufMtx4, double scale, double[] translation_vec, Matrix3x3 mtx_3d,
            out Matrix4x4 mtx_4D) => ufMtx4.Initialize(scale, translation_vec, mtx_3d.ToArray(), out mtx_4D);

        /// <summary>
        ///     Returns the 4x4 matrix formed from a 3x3 rotation matrix, a 3D
        ///     translation vector, and a scale factor.
        /// </summary>
        /// <remarks>
        ///     Refer to <see href="..ugopen_doc/uf_mtx/global.html#UF_MTX4_initialize">UF_MTX4_initialize</see> for documentation<br/>
        ///     <see href="..mapping/Uf2NxOpenNet.htm">Mapping Help</see><br/>
        ///     License requirements:None
        /// </remarks>
        /// <param name="ufMtx4"></param>
        /// <param name="scale">Input Scale factor</param>
        /// <param name="translation_vec">Input Translation vector</param>
        /// <param name="mtx_3d">Input 3x3 rotation matrix</param>
        /// <param name="mtx_4D">Output 4x4 matrix</param>
        public static void Initialize(this UFMtx4 ufMtx4, double scale, Vector3d translation_vec, Matrix3x3 mtx_3d,
            out Matrix4x4 mtx_4D) => ufMtx4.Initialize(scale, translation_vec.ToArray(), mtx_3d.ToArray(), out mtx_4D);

        /// <summary>
        ///     Returns the matrix which is the invert of the input one
        /// </summary>
        /// <remarks>
        ///     Refer to <see href="..ugopen_doc/uf_mtx/global.html#UF_MTX4_invert">UF_MTX4_invert</see> for documentation<br/>
        ///     <see href="..mapping/Uf2NxOpenNet.htm">Mapping Help</see><br/>
        ///     License requirements:None
        /// </remarks>
        /// <param name="ufMtx4"></param>
        /// <param name="mtx_in">Input Input matrix</param>
        /// <param name="mtx_out">Output Returned inverted matrix</param>
        public static void Invert(this UFMtx4 ufMtx4, double[] mtx_in, out double[] mtx_out)
        {
            mtx_out = new double[16];

            ufMtx4.Invert(mtx_in, mtx_out);
        }

        /// <summary>
        ///     Returns the matrix which is the invert of the input one
        /// </summary>
        /// <remarks>
        ///     Refer to <see href="..ugopen_doc/uf_mtx/global.html#UF_MTX4_invert">UF_MTX4_invert</see> for documentation<br/>
        ///     <see href="..mapping/Uf2NxOpenNet.htm">Mapping Help</see><br/>
        ///     License requirements:None
        /// </remarks>
        /// <param name="ufMtx4"></param>
        /// <param name="mtx_in">Input Input matrix</param>
        /// <param name="mtx_out">Output Returned inverted matrix</param>
        public static void Invert(this UFMtx4 ufMtx4, double[] mtx_in, out Matrix4x4 mtx_out)
        {
            ufMtx4.Invert(mtx_in, out double[] matrix);

            mtx_out = new Matrix4x4(matrix[0], matrix[1], matrix[2], matrix[3], matrix[4], matrix[5], matrix[6],
                matrix[7], matrix[8], matrix[9], matrix[10], matrix[11], matrix[12], matrix[13], matrix[14],
                matrix[15]);
        }

        /// <summary>
        ///     Returns the matrix which is the invert of the input one
        /// </summary>
        /// <remarks>
        ///     Refer to <see href="..ugopen_doc/uf_mtx/global.html#UF_MTX4_invert">UF_MTX4_invert</see> for documentation<br/>
        ///     <see href="..mapping/Uf2NxOpenNet.htm">Mapping Help</see><br/>
        ///     License requirements:None
        /// </remarks>
        /// <param name="ufMtx4"></param>
        /// <param name="mtx_in">Input Input matrix</param>
        /// <param name="mtx_out">Output Returned inverted matrix</param>
        public static void Invert(this UFMtx4 ufMtx4, Matrix4x4 mtx_in, out Matrix4x4 mtx_out) =>
            ufMtx4.Invert(mtx_in.ToArray(), out mtx_out);

        /// <summary>
        ///     Returns the matrix which can be used to mirror about a plane
        /// </summary>
        /// <remarks>
        ///     Refer to <see href="..ugopen_doc/uf_mtx/global.html#UF_MTX4_mirror">UF_MTX4_mirror</see> for documentation<br/>
        ///     <see href="..mapping/Uf2NxOpenNet.htm">Mapping Help</see><br/>
        ///     License requirements:None
        /// </remarks>
        /// <param name="ufMtx4"></param>
        /// <param name="origin">Input The origin of the plane.</param>
        /// <param name="normal">Input The plane normal</param>
        /// <param name="mtx">Output Returned matrix that can be used to
        ///     transform objects</param>
        public static void Mirror(this UFMtx4 ufMtx4, double[] origin, double[] normal, out double[] mtx)
        {
            mtx = new double[16];

            ufMtx4.Mirror(origin, normal, mtx);
        }

        /// <summary>
        ///     Returns the matrix which can be used to mirror about a plane
        /// </summary>
        /// <remarks>
        ///     Refer to <see href="..ugopen_doc/uf_mtx/global.html#UF_MTX4_mirror">UF_MTX4_mirror</see> for documentation<br/>
        ///     <see href="..mapping/Uf2NxOpenNet.htm">Mapping Help</see><br/>
        ///     License requirements:None
        /// </remarks>
        /// <param name="ufMtx4"></param>
        /// <param name="origin">Input The origin of the plane.</param>
        /// <param name="normal">Input The plane normal</param>
        /// <param name="mtx">Output Returned matrix that can be used to
        ///     transform objects</param>
        public static void Mirror(this UFMtx4 ufMtx4, double[] origin, double[] normal, out Matrix4x4 mtx)
        {
            ufMtx4.Mirror(origin, normal, out double[] matrix);

            mtx = new Matrix4x4(matrix[0], matrix[1], matrix[2], matrix[3], matrix[4], matrix[5], matrix[6],
                matrix[7], matrix[8], matrix[9], matrix[10], matrix[11], matrix[12], matrix[13], matrix[14],
                matrix[15]);
        }

        /// <summary>
        ///     Returns the matrix which can be used to mirror about a plane
        /// </summary>
        /// <remarks>
        ///     Refer to <see href="..ugopen_doc/uf_mtx/global.html#UF_MTX4_mirror">UF_MTX4_mirror</see> for documentation<br/>
        ///     <see href="..mapping/Uf2NxOpenNet.htm">Mapping Help</see><br/>
        ///     License requirements:None
        /// </remarks>
        /// <param name="ufMtx4"></param>
        /// <param name="origin">Input The origin of the plane.</param>
        /// <param name="normal">Input The plane normal</param>
        /// <param name="mtx">Output Returned matrix that can be used to
        ///     transform objects</param>
        public static void Mirror(this UFMtx4 ufMtx4, Point3d origin, double[] normal, out Matrix4x4 mtx) =>
            ufMtx4.Mirror(origin.ToArray(), normal, out mtx);

        /// <summary>
        ///     Returns the matrix which can be used to mirror about a plane
        /// </summary>
        /// <remarks>
        ///     Refer to <see href="..ugopen_doc/uf_mtx/global.html#UF_MTX4_mirror">UF_MTX4_mirror</see> for documentation<br/>
        ///     <see href="..mapping/Uf2NxOpenNet.htm">Mapping Help</see><br/>
        ///     License requirements:None
        /// </remarks>
        /// <param name="ufMtx4"></param>
        /// <param name="origin">Input The origin of the plane.</param>
        /// <param name="normal">Input The plane normal</param>
        /// <param name="mtx">Output Returned matrix that can be used to
        ///     transform objects</param>
        public static void Mirror(this UFMtx4 ufMtx4, double[] origin, Vector3d normal, out Matrix4x4 mtx) =>
            ufMtx4.Mirror(origin, normal.ToArray(), out mtx);

        /// <summary>
        ///     Returns the matrix which can be used to mirror about a plane
        /// </summary>
        /// <remarks>
        ///     Refer to <see href="..ugopen_doc/uf_mtx/global.html#UF_MTX4_mirror">UF_MTX4_mirror</see> for documentation<br/>
        ///     <see href="..mapping/Uf2NxOpenNet.htm">Mapping Help</see><br/>
        ///     License requirements:None
        /// </remarks>
        /// <param name="ufMtx4"></param>
        /// <param name="origin">Input The origin of the plane.</param>
        /// <param name="normal">Input The plane normal</param>
        /// <param name="mtx">Output Returned matrix that can be used to
        ///     transform objects</param>
        public static void Mirror(this UFMtx4 ufMtx4, Point3d origin, Vector3d normal, out Matrix4x4 mtx) =>
            ufMtx4.Mirror(origin.ToArray(), normal.ToArray(), out mtx);

        /// <summary>
        ///     Returns a 4x4 matrix product from two input matrices.
        /// </summary>
        /// <remarks>
        ///     Refer to <see href="..ugopen_doc/uf_mtx/global.html#UF_MTX4_multiply">UF_MTX4_multiply</see> for documentation<br/>
        ///     <see href="..mapping/Uf2NxOpenNet.htm">Mapping Help</see><br/>
        ///     License requirements:None
        /// </remarks>
        /// <param name="ufMtx4"></param>
        /// <param name="mtx1">Input Matrix #1</param>
        /// <param name="mtx2">Input Matrix #2</param>
        /// <param name="mtx_product">Output Matrix product
        ///     mtx_product = mtx1 X mtx2</param>
        public static void Multiply(this UFMtx4 ufMtx4, double[] mtx1, double[] mtx2, out double[] mtx_product)
        {
            mtx_product = new double[16];

            ufMtx4.Multiply(mtx1, mtx2, mtx_product);
        }

        /// <summary>
        ///     Returns a 4x4 matrix product from two input matrices.
        /// </summary>
        /// <remarks>
        ///     Refer to <see href="..ugopen_doc/uf_mtx/global.html#UF_MTX4_multiply">UF_MTX4_multiply</see> for documentation<br/>
        ///     <see href="..mapping/Uf2NxOpenNet.htm">Mapping Help</see><br/>
        ///     License requirements:None
        /// </remarks>
        /// <param name="ufMtx4"></param>
        /// <param name="mtx1">Input Matrix #1</param>
        /// <param name="mtx2">Input Matrix #2</param>
        /// <param name="mtx_product">Output Matrix product
        ///     mtx_product = mtx1 X mtx2</param>
        public static void Multiply(this UFMtx4 ufMtx4, double[] mtx1, double[] mtx2, out Matrix4x4 mtx_product)
        {
            ufMtx4.Multiply(mtx1, mtx2, out double[] matrix);

            mtx_product = new Matrix4x4(matrix[0], matrix[1], matrix[2], matrix[3], matrix[4], matrix[5], matrix[6],
                matrix[7], matrix[8], matrix[9], matrix[10], matrix[11], matrix[12], matrix[13], matrix[14],
                matrix[15]);
        }

        /// <summary>
        ///     Returns a 4x4 matrix product from two input matrices.
        /// </summary>
        /// <remarks>
        ///     Refer to <see href="..ugopen_doc/uf_mtx/global.html#UF_MTX4_multiply">UF_MTX4_multiply</see> for documentation<br/>
        ///     <see href="..mapping/Uf2NxOpenNet.htm">Mapping Help</see><br/>
        ///     License requirements:None
        /// </remarks>
        /// <param name="ufMtx4"></param>
        /// <param name="mtx1">Input Matrix #1</param>
        /// <param name="mtx2">Input Matrix #2</param>
        /// <param name="mtx_product">Output Matrix product
        ///     mtx_product = mtx1 X mtx2</param>
        public static void Multiply(this UFMtx4 ufMtx4, Matrix4x4 mtx1, double[] mtx2, out Matrix4x4 mtx_product) =>
            ufMtx4.Multiply(mtx1.ToArray(), mtx2, out mtx_product);

        /// <summary>
        ///     Returns a 4x4 matrix product from two input matrices.
        /// </summary>
        /// <remarks>
        ///     Refer to <see href="..ugopen_doc/uf_mtx/global.html#UF_MTX4_multiply">UF_MTX4_multiply</see> for documentation<br/>
        ///     <see href="..mapping/Uf2NxOpenNet.htm">Mapping Help</see><br/>
        ///     License requirements:None
        /// </remarks>
        /// <param name="ufMtx4"></param>
        /// <param name="mtx1">Input Matrix #1</param>
        /// <param name="mtx2">Input Matrix #2</param>
        /// <param name="mtx_product">Output Matrix product
        ///     mtx_product = mtx1 X mtx2</param>
        public static void Multiply(this UFMtx4 ufMtx4,  double[] mtx1, Matrix4x4 mtx2, out Matrix4x4 mtx_product) =>
            ufMtx4.Multiply(mtx1, mtx2.ToArray(), out mtx_product);

        /// <summary>
        ///     Returns a 4x4 matrix product from two input matrices.
        /// </summary>
        /// <remarks>
        ///     Refer to <see href="..ugopen_doc/uf_mtx/global.html#UF_MTX4_multiply">UF_MTX4_multiply</see> for documentation<br/>
        ///     <see href="..mapping/Uf2NxOpenNet.htm">Mapping Help</see><br/>
        ///     License requirements:None
        /// </remarks>
        /// <param name="ufMtx4"></param>
        /// <param name="mtx1">Input Matrix #1</param>
        /// <param name="mtx2">Input Matrix #2</param>
        /// <param name="mtx_product">Output Matrix product
        ///     mtx_product = mtx1 X mtx2</param>
        public static void Multiply(this UFMtx4 ufMtx4, Matrix4x4 mtx1, Matrix4x4 mtx2, out Matrix4x4 mtx_product) =>
            ufMtx4.Multiply(mtx1.ToArray(), mtx2.ToArray(), out mtx_product);

        /// <summary>
        ///     Returns a 4x4 matrix product by transposing the first matrix before
        ///     performing the multiplication.
        /// </summary>
        /// <remarks>
        ///     Refer to <see href="..ugopen_doc/uf_mtx/global.html#UF_MTX4_multiply_t">UF_MTX4_multiply_t</see> for documentation<br/>
        ///     <see href="..mapping/Uf2NxOpenNet.htm">Mapping Help</see><br/>
        ///     License requirements:None
        /// </remarks>
        /// <param name="ufMtx4"></param>
        /// <param name="mtx1">	Input Matrix #1 gets transposed before the
        ///     multiplication.</param>
        /// <param name="mtx2">	Input Matrix #2</param>
        /// <param name="mtx_product">OutputMatrix product
        ///     mtx_product = mtx1 X mtx2</param>
        public static void MultiplyT(this UFMtx4 ufMtx4, double[] mtx1, double[] mtx2, out double[] mtx_product)
        {
            mtx_product = new double[16];

            ufMtx4.MultiplyT(mtx1, mtx2, mtx_product);
        }

        /// <summary>
        ///     Returns a 4x4 matrix product by transposing the first matrix before
        ///     performing the multiplication.
        /// </summary>
        /// <remarks>
        ///     Refer to <see href="..ugopen_doc/uf_mtx/global.html#UF_MTX4_multiply_t">UF_MTX4_multiply_t</see> for documentation<br/>
        ///     <see href="..mapping/Uf2NxOpenNet.htm">Mapping Help</see><br/>
        ///     License requirements:None
        /// </remarks>
        /// <param name="ufMtx4"></param>
        /// <param name="mtx1">	Input Matrix #1 gets transposed before the
        ///     multiplication.</param>
        /// <param name="mtx2">	Input Matrix #2</param>
        /// <param name="mtx_product">OutputMatrix product
        ///     mtx_product = mtx1 X mtx2</param>
        public static void MultiplyT(this UFMtx4 ufMtx4, double[] mtx1, double[] mtx2, out Matrix4x4 mtx_product)
        {
            ufMtx4.MultiplyT(mtx1, mtx2, out double[] matrix);

            mtx_product = new Matrix4x4(matrix[0], matrix[1], matrix[2], matrix[3], matrix[4], matrix[5], matrix[6],
                matrix[7], matrix[8], matrix[9], matrix[10], matrix[11], matrix[12], matrix[13], matrix[14],
                matrix[15]);
        }

        /// <summary>
        ///     Returns a 4x4 matrix product by transposing the first matrix before
        ///     performing the multiplication.
        /// </summary>
        /// <remarks>
        ///     Refer to <see href="..ugopen_doc/uf_mtx/global.html#UF_MTX4_multiply_t">UF_MTX4_multiply_t</see> for documentation<br/>
        ///     <see href="..mapping/Uf2NxOpenNet.htm">Mapping Help</see><br/>
        ///     License requirements:None
        /// </remarks>
        /// <param name="ufMtx4"></param>
        /// <param name="mtx1">	Input Matrix #1 gets transposed before the
        ///     multiplication.</param>
        /// <param name="mtx2">	Input Matrix #2</param>
        /// <param name="mtx_product">OutputMatrix product
        ///     mtx_product = mtx1 X mtx2</param>
        public static void MultiplyT(this UFMtx4 ufMtx4, Matrix4x4 mtx1, double[] mtx2, out Matrix4x4 mtx_product) =>
            ufMtx4.MultiplyT(mtx1.ToArray(), mtx2, out mtx_product);

        /// <summary>
        ///     Returns a 4x4 matrix product by transposing the first matrix before
        ///     performing the multiplication.
        /// </summary>
        /// <remarks>
        ///     Refer to <see href="..ugopen_doc/uf_mtx/global.html#UF_MTX4_multiply_t">UF_MTX4_multiply_t</see> for documentation<br/>
        ///     <see href="..mapping/Uf2NxOpenNet.htm">Mapping Help</see><br/>
        ///     License requirements:None
        /// </remarks>
        /// <param name="ufMtx4"></param>
        /// <param name="mtx1">	Input Matrix #1 gets transposed before the
        ///     multiplication.</param>
        /// <param name="mtx2">	Input Matrix #2</param>
        /// <param name="mtx_product">OutputMatrix product
        ///     mtx_product = mtx1 X mtx2</param>
        public static void MultiplyT(this UFMtx4 ufMtx4, double[] mtx1, Matrix4x4 mtx2, out Matrix4x4 mtx_product) =>
            ufMtx4.MultiplyT(mtx1, mtx2.ToArray(), out mtx_product);

        /// <summary>
        ///     Returns a 4x4 matrix product by transposing the first matrix before
        ///     performing the multiplication.
        /// </summary>
        /// <remarks>
        ///     Refer to <see href="..ugopen_doc/uf_mtx/global.html#UF_MTX4_multiply_t">UF_MTX4_multiply_t</see> for documentation<br/>
        ///     <see href="..mapping/Uf2NxOpenNet.htm">Mapping Help</see><br/>
        ///     License requirements:None
        /// </remarks>
        /// <param name="ufMtx4"></param>
        /// <param name="mtx1">	Input Matrix #1 gets transposed before the
        ///     multiplication.</param>
        /// <param name="mtx2">	Input Matrix #2</param>
        /// <param name="mtx_product">OutputMatrix product
        ///     mtx_product = mtx1 X mtx2</param>
        public static void MultiplyT(this UFMtx4 ufMtx4, Matrix4x4 mtx1, Matrix4x4 mtx2, out Matrix4x4 mtx_product) =>
            ufMtx4.MultiplyT(mtx1.ToArray(), mtx2.ToArray(), out mtx_product);

        /// <summary>
        ///     Returns a 4x4 matrix whose direction vectors are orthogonal and of
        ///     unit length.
        /// </summary>
        /// <remarks>
        ///     Refer to <see href="..ugopen_doc/uf_mtx/global.html#UF_MTX4_ortho_normalize">UF_MTX4_ortho_normalize</see> for documentation<br/>
        ///     <see href="..mapping/Uf2NxOpenNet.htm">Mapping Help</see><br/>
        ///     License requirements:None
        /// </remarks>
        /// <param name="ufMtx4"></param>
        /// <param name="mtx">Input / Output Matrix to be ortho-normalized. (Input)
        ///     Ortho-normalized matrix. (Output)</param>
        public static void OrthoNormalize(this UFMtx4 ufMtx4, ref Matrix4x4 mtx)
        {
            double[] matrix = mtx.ToArray();

            ufMtx4.OrthoNormalize(matrix);

            mtx = new Matrix4x4(matrix[0], matrix[1], matrix[2], matrix[3], matrix[4], matrix[5], matrix[6],
                matrix[7], matrix[8], matrix[9], matrix[10], matrix[11], matrix[12], matrix[13], matrix[14],
                matrix[15]);
        }

        /// <summary>
        ///     Returns the matrix which can be used to rotate about a point
        /// </summary>
        /// <remarks>
        ///     Refer to <see href="..ugopen_doc/uf_mtx/global.html#UF_MTX4_rotation">UF_MTX4_rotation</see> for documentation<br/>
        ///     <see href="..mapping/Uf2NxOpenNet.htm">Mapping Help</see><br/>
        ///     License requirements:None
        /// </remarks>
        /// <param name="ufMtx4"></param>
        /// <param name="rotation_point">Input Point about which the rotation is to
        ///     be performed.</param>
        /// <param name="rotation_axis">Input Axis about which rotation to occur.</param>
        /// <param name="angle">Input rotation angle in degrees</param>
        /// <param name="mtx">Output returned matrix that can be used to
        ///     transform objects</param>
        public static void Rotation(this UFMtx4 ufMtx4, double[] rotation_point, double[] rotation_axis, double angle,
            out double[] mtx)
        {
            mtx = new double[16];

            ufMtx4.Rotation(rotation_point, rotation_axis, angle, mtx);
        }

        /// <summary>
        ///     Returns the matrix which can be used to rotate about a point
        /// </summary>
        /// <remarks>
        ///     Refer to <see href="..ugopen_doc/uf_mtx/global.html#UF_MTX4_rotation">UF_MTX4_rotation</see> for documentation<br/>
        ///     <see href="..mapping/Uf2NxOpenNet.htm">Mapping Help</see><br/>
        ///     License requirements:None
        /// </remarks>
        /// <param name="ufMtx4"></param>
        /// <param name="rotation_point">Input Point about which the rotation is to
        ///     be performed.</param>
        /// <param name="rotation_axis">Input Axis about which rotation to occur.</param>
        /// <param name="angle">Input rotation angle in degrees</param>
        /// <param name="mtx">Output returned matrix that can be used to
        ///     transform objects</param>
        public static void Rotation(this UFMtx4 ufMtx4, double[] rotation_point, double[] rotation_axis, double angle,
            out Matrix4x4 mtx)
        {
            ufMtx4.Rotation(rotation_point, rotation_axis, angle, out double[] matrix);

            mtx = new Matrix4x4(matrix[0], matrix[1], matrix[2], matrix[3], matrix[4], matrix[5], matrix[6],
                matrix[7], matrix[8], matrix[9], matrix[10], matrix[11], matrix[12], matrix[13], matrix[14],
                matrix[15]);
        }

        /// <summary>
        ///     Returns the matrix which can be used to rotate about a point
        /// </summary>
        /// <remarks>
        ///     Refer to <see href="..ugopen_doc/uf_mtx/global.html#UF_MTX4_rotation">UF_MTX4_rotation</see> for documentation<br/>
        ///     <see href="..mapping/Uf2NxOpenNet.htm">Mapping Help</see><br/>
        ///     License requirements:None
        /// </remarks>
        /// <param name="ufMtx4"></param>
        /// <param name="rotation_point">Input Point about which the rotation is to
        ///     be performed.</param>
        /// <param name="rotation_axis">Input Axis about which rotation to occur.</param>
        /// <param name="angle">Input rotation angle in degrees</param>
        /// <param name="mtx">Output returned matrix that can be used to
        ///     transform objects</param>
        public static void Rotation(this UFMtx4 ufMtx4, Point3d rotation_point, double[] rotation_axis, double angle,
            out Matrix4x4 mtx) => ufMtx4.Rotation(rotation_point.ToArray(), rotation_axis, angle, out mtx);

        /// <summary>
        ///     Returns the matrix which can be used to rotate about a point
        /// </summary>
        /// <remarks>
        ///     Refer to <see href="..ugopen_doc/uf_mtx/global.html#UF_MTX4_rotation">UF_MTX4_rotation</see> for documentation<br/>
        ///     <see href="..mapping/Uf2NxOpenNet.htm">Mapping Help</see><br/>
        ///     License requirements:None
        /// </remarks>
        /// <param name="ufMtx4"></param>
        /// <param name="rotation_point">Input Point about which the rotation is to
        ///     be performed.</param>
        /// <param name="rotation_axis">Input Axis about which rotation to occur.</param>
        /// <param name="angle">Input rotation angle in degrees</param>
        /// <param name="mtx">Output returned matrix that can be used to
        ///     transform objects</param>
        public static void Rotation(this UFMtx4 ufMtx4, double[] rotation_point, Vector3d rotation_axis, double angle,
            out Matrix4x4 mtx) => ufMtx4.Rotation(rotation_point, rotation_axis.ToArray(), angle, out mtx);

        /// <summary>
        ///     Returns the matrix which can be used to rotate about a point
        /// </summary>
        /// <remarks>
        ///     Refer to <see href="..ugopen_doc/uf_mtx/global.html#UF_MTX4_rotation">UF_MTX4_rotation</see> for documentation<br/>
        ///     <see href="..mapping/Uf2NxOpenNet.htm">Mapping Help</see><br/>
        ///     License requirements:None
        /// </remarks>
        /// <param name="ufMtx4"></param>
        /// <param name="rotation_point">Input Point about which the rotation is to
        ///     be performed.</param>
        /// <param name="rotation_axis">Input Axis about which rotation to occur.</param>
        /// <param name="angle">Input rotation angle in degrees</param>
        /// <param name="mtx">Output returned matrix that can be used to
        ///     transform objects</param>
        public static void Rotation(this UFMtx4 ufMtx4, Point3d rotation_point, Vector3d rotation_axis, double angle,
            out Matrix4x4 mtx) => ufMtx4.Rotation(rotation_point.ToArray(), rotation_axis.ToArray(), angle, out mtx);

        /// <summary>
        ///     Returns the matrix using scaling and invariant point information.
        /// </summary>
        /// <remarks>
        ///     Refer to <see href="..ugopen_doc/uf_mtx/global.html#UF_MTX4_scaling">UF_MTX4_scaling</see> for documentation<br/>
        ///     <see href="..mapping/Uf2NxOpenNet.htm">Mapping Help</see><br/>
        ///     License requirements:None
        /// </remarks>
        /// <param name="ufMtx4"></param>
        /// <param name="invariant_point">Input Point which will be invariant to the
        ///     scaling, in other words the center
        ///     point of the scale operation.</param>
        /// <param name="scale">Input scaling in x, y, z directions</param>
        /// <param name="mtx">Output returned matrix that can be used to
        ///     transform objects</param>
        public static void Scaling(this UFMtx4 ufMtx4, double[] invariant_point, double[] scale, out double[] mtx)
        {
            mtx = new double[16];

            ufMtx4.Scaling(invariant_point, scale, mtx);
        }

        /// <summary>
        ///     Returns the matrix using scaling and invariant point information.
        /// </summary>
        /// <remarks>
        ///     Refer to <see href="..ugopen_doc/uf_mtx/global.html#UF_MTX4_scaling">UF_MTX4_scaling</see> for documentation<br/>
        ///     <see href="..mapping/Uf2NxOpenNet.htm">Mapping Help</see><br/>
        ///     License requirements:None
        /// </remarks>
        /// <param name="ufMtx4"></param>
        /// <param name="invariant_point">Input Point which will be invariant to the
        ///     scaling, in other words the center
        ///     point of the scale operation.</param>
        /// <param name="scale">Input scaling in x, y, z directions</param>
        /// <param name="mtx">Output returned matrix that can be used to
        ///     transform objects</param>
        public static void Scaling(this UFMtx4 ufMtx4, double[] invariant_point, double[] scale, out Matrix4x4 mtx)
        {
            ufMtx4.Scaling(invariant_point, scale, out double[] matrix);

            mtx = new Matrix4x4(matrix[0], matrix[1], matrix[2], matrix[3], matrix[4], matrix[5], matrix[6],
                matrix[7], matrix[8], matrix[9], matrix[10], matrix[11], matrix[12], matrix[13], matrix[14],
                matrix[15]);
        }

        /// <summary>
        ///     Returns the matrix using scaling and invariant point information.
        /// </summary>
        /// <remarks>
        ///     Refer to <see href="..ugopen_doc/uf_mtx/global.html#UF_MTX4_scaling">UF_MTX4_scaling</see> for documentation<br/>
        ///     <see href="..mapping/Uf2NxOpenNet.htm">Mapping Help</see><br/>
        ///     License requirements:None
        /// </remarks>
        /// <param name="ufMtx4"></param>
        /// <param name="invariant_point">Input Point which will be invariant to the
        ///     scaling, in other words the center
        ///     point of the scale operation.</param>
        /// <param name="scale">Input scaling in x, y, z directions</param>
        /// <param name="mtx">Output returned matrix that can be used to
        ///     transform objects</param>
        public static void Scaling(this UFMtx4 ufMtx4, Point3d invariant_point, double[] scale, out Matrix4x4 mtx) =>
            ufMtx4.Scaling(invariant_point.ToArray(), scale, out mtx);

        /// <summary>
        ///     Returns the transpose of a 4x4 matrix.
        /// </summary>
        /// <remarks>
        ///     Refer to <see href="..ugopen_doc/uf_mtx/global.html#UF_MTX4_transpose">UF_MTX4_transpose</see> for documentation<br/>
        ///     <see href="..mapping/Uf2NxOpenNet.htm">Mapping Help</see><br/>
        ///     License requirements:None
        /// </remarks>
        /// <param name="ufMtx4"></param>
        /// <param name="mtx">Input Matrix to transpose</param>
        /// <param name="transpose_mtx">Output Transposed matrix
        ///     transpose_mtx = trns(mtx)</param>
        public static void Transpose(this UFMtx4 ufMtx4, double[] mtx, out double[] transpose_mtx)
        {
            transpose_mtx = new double[16];

            ufMtx4.Transpose(mtx, transpose_mtx);
        }

        /// <summary>
        ///     Returns the transpose of a 4x4 matrix.
        /// </summary>
        /// <remarks>
        ///     Refer to <see href="..ugopen_doc/uf_mtx/global.html#UF_MTX4_transpose">UF_MTX4_transpose</see> for documentation<br/>
        ///     <see href="..mapping/Uf2NxOpenNet.htm">Mapping Help</see><br/>
        ///     License requirements:None
        /// </remarks>
        /// <param name="ufMtx4"></param>
        /// <param name="mtx">Input Matrix to transpose</param>
        /// <param name="transpose_mtx">Output Transposed matrix
        ///     transpose_mtx = trns(mtx)</param>
        public static void Transpose(this UFMtx4 ufMtx4, double[] mtx, out Matrix4x4 transpose_mtx)
        {
            ufMtx4.Transpose(mtx, out double[] matrix);

            transpose_mtx = new Matrix4x4(matrix[0], matrix[1], matrix[2], matrix[3], matrix[4], matrix[5], matrix[6],
                matrix[7], matrix[8], matrix[9], matrix[10], matrix[11], matrix[12], matrix[13], matrix[14],
                matrix[15]);
        }

        /// <summary>
        ///     Returns the transpose of a 4x4 matrix.
        /// </summary>
        /// <remarks>
        ///     Refer to <see href="..ugopen_doc/uf_mtx/global.html#UF_MTX4_transpose">UF_MTX4_transpose</see> for documentation<br/>
        ///     <see href="..mapping/Uf2NxOpenNet.htm">Mapping Help</see><br/>
        ///     License requirements:None
        /// </remarks>
        /// <param name="ufMtx4"></param>
        /// <param name="mtx">Input Matrix to transpose</param>
        /// <param name="transpose_mtx">Output Transposed matrix
        ///     transpose_mtx = trns(mtx)</param>
        public static void Transpose(this UFMtx4 ufMtx4, Matrix4x4 mtx, out Matrix4x4 transpose_mtx) =>
            ufMtx4.Transpose(mtx.ToArray(), out transpose_mtx);
    }
}
