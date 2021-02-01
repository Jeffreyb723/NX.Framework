using NXOpen;
using NXOpen.UF;

using System;

namespace NX.Framework
{
    public static class EvalExtensions
    {
        /// <summary>
        ///     Returns the arc data of the evaluator of a circular curve or edge.
        /// </summary>
        /// <remarks>
        ///     Refer to <see href="..ugopen_doc/uf_eval/global.html#UF_EVAL_ask_arc">UF_EVAL_ask_arc</see> for documentation<br/>
        ///     License requirements:None
        /// </remarks>
        /// <param name="ufEval"></param>
        /// <param name="arcTag">Object identifier of a curve</param>
        /// <param name="arc">arc data</param>
        public static void AskArc(this UFEval ufEval, Tag arcTag, out UFEval.Arc arc)
        {
            ufEval.Initialize(arcTag, out IntPtr evaluator);
            ufEval.AskArc(evaluator, out arc);
            ufEval.Free(evaluator);
        }
    }
}
