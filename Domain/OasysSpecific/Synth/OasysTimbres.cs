#region copyright

// (c) Copyright 2011-2023 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

#region using

using Domain.Common.Synth.PatchCombis;

#endregion

namespace Domain.OasysSpecific.Synth
{
    /// <summary>
    /// </summary>
    public sealed class OasysTimbres : Timbres
    {
        /// <summary>
        /// </summary>
        /// <param name="combi"></param>
        public OasysTimbres(ICombi combi)
            : base(combi, TimbresPerCombiConstant, TimbresOffsetConstant)
        {
            for (var n = 0; n < TimbresPerCombi; n++)
            {
                TimbresCollection.Add(new OasysTimbre(this, n));
            }
        }

        /// <summary>
        /// </summary>
        private static int TimbresPerCombiConstant => 16;

        /// <summary>
        /// </summary>
        private static int TimbresOffsetConstant => 4790;

        /// <summary>
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        protected override ITimbre CreateNewTimbre(int index)
        {
            return new OasysTimbre(this, index);
        }
    }
}