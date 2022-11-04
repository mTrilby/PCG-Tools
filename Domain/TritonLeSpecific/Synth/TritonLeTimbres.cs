#region copyright

// (c) Copyright 2011-2022 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

using Domain.Common.Synth.PatchCombis;
using Domain.TritonSpecific.Synth;

namespace Domain.TritonLeSpecific.Synth
{
    /// <summary>
    /// </summary>
    public sealed class TritonLeTimbres : TritonTimbres
    {
        /// <summary>
        /// </summary>
        /// <param name="combi"></param>
        public TritonLeTimbres(ICombi combi)
            : base(combi, TimbresOffsetConstant)
        {
            for (var n = 0; n < TimbresPerCombi; n++)
            {
                TimbresCollection.Add(new TritonLeTimbre(this, n));
            }
        }

        /// <summary>
        ///     Triton non LE is 224, a Triton LE combi is 96 shorter than a Triton non LE combi.
        /// </summary>
        private static int TimbresOffsetConstant => 224 - 96;


        /// <summary>
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        protected override ITimbre CreateNewTimbre(int index)
        {
            return new TritonLeTimbre(this, index);
        }
    }
}