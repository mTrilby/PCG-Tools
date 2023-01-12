#region copyright

// (c) Copyright 2011-2023 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

#region using

using Domain.Common.Synth.PatchCombis;

#endregion

namespace Domain.KronosSpecific.Synth
{
    /// <summary>
    /// </summary>
    public sealed class KronosTimbres : Timbres
    {
        /// <summary>
        /// </summary>
        /// <param name="combi"></param>
        public KronosTimbres(Combi combi)
            : base(combi, TimbresPerCombiConstant, TimbresOffsetConstant)
        {
            for (var n = 0; n < TimbresPerCombi; n++)
            {
                TimbresCollection.Add(new KronosTimbre(this, n));
            }
        }

        /// <summary>
        /// </summary>
        public static int TimbresPerCombiConstant => 16;

        /// <summary>
        /// </summary>
        private static int TimbresOffsetConstant => 4802;

        /// <summary>
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        protected override ITimbre CreateNewTimbre(int index)
        {
            return new KronosTimbre(this, index);
        }
    }
}