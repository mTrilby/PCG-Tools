﻿#region copyright

// (c) Copyright 2011-2023 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

#region using

using Domain.Common.Synth.PatchCombis;
using Domain.MSpecific.Synth;

#endregion

namespace Domain.MicroStationSpecific.Synth
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