// (c) Copyright 2011-2019 MiKeSoft, Michel Keijzers, All rights reserved


using Domain.MasterFiles;
using Domain.Model.Common.Synth.PatchCombis;
using Domain.Model.TritonSpecific.Synth;

namespace Domain.Model.TritonExtremeSpecific.Synth
{
    /// <summary>
    /// 
    /// </summary>
    public sealed class TritonExtremeTimbre : TritonTimbre
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="timbres"></param>
        /// <param name="index"></param>
        public TritonExtremeTimbre(ITimbres timbres, int index)
            : base(timbres, index)
        {
        }
    }
}
