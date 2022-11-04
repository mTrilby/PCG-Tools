#region copyright

// (c) Copyright 2011-2022 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

using PcgTools.Model.Common.Synth.PatchCombis;
using PcgTools.Model.MSpecific.Synth;

namespace PcgTools.Model.MicroStationSpecific.Synth
{
    /// <summary>
    /// </summary>
    public sealed class MicroStationTimbre : MTimbre
    {
        /// <summary>
        /// </summary>
        /// <param name="timbres"></param>
        /// <param name="index"></param>
        public MicroStationTimbre(ITimbres timbres, int index)
            : base(timbres, index, TimbresSizeConstant)
        {
        }

        /// <summary>
        /// </summary>
        private static int TimbresSizeConstant => 44;
    }
}