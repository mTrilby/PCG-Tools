#region copyright

// (c) Copyright 2011-2022 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

using Domain.Common.Synth.PatchCombis;
using Domain.TritonSpecific.Synth;

namespace Domain.TritonExtremeSpecific.Synth
{
    /// <summary>
    /// </summary>
    public sealed class TritonExtremeTimbres : TritonTimbres
    {
        /// <summary>
        /// </summary>
        /// <param name="combi"></param>
        public TritonExtremeTimbres(ICombi combi)
            : base(combi, TimbresOffsetConstant)
        {
            for (var n = 0; n < TimbresPerCombi; n++)
            {
                TimbresCollection.Add(new TritonExtremeTimbre(this, n));
            }
        }

        /// <summary>
        /// </summary>
        private static int TimbresOffsetConstant => 224;


        /// <summary>
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        protected override ITimbre CreateNewTimbre(int index)
        {
            return new TritonExtremeTimbre(this, index);
        }
    }
}