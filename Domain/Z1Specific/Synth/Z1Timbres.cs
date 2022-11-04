#region copyright

// (c) Copyright 2011-2022 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

using PcgTools.Model.Common.Synth.PatchCombis;

namespace PcgTools.Model.Z1Specific.Synth
{
    /// <summary>
    /// </summary>
    public sealed class Z1Timbres : Timbres // Note: Not from MntxTimbres
    {
        /// <summary>
        /// </summary>
        /// <param name="combi"></param>
        public Z1Timbres(ICombi combi)
            : base(combi, TimbresPerCombiConstant, TimbresOffsetConstant)
        {
            for (var n = 0; n < TimbresPerCombi; n++)
            {
                TimbresCollection.Add(new Z1Timbre(this, n));
            }
        }

        /// <summary>
        /// </summary>
        private static int TimbresPerCombiConstant => 6;


        /// <summary>
        /// </summary>
        private static int TimbresOffsetConstant => 16;


        /// <summary>
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        protected override ITimbre CreateNewTimbre(int index)
        {
            return new Z1Timbre(this, index);
        }
    }
}