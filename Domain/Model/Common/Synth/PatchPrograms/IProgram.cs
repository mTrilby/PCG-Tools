﻿// (c) Copyright 2011-2019 MiKeSoft, Michel Keijzers, All rights reserved

using System.Collections.Generic;
using Domain.Model.Common.Synth.DrumTrack;
using Domain.Model.Common.Synth.Meta;
using Domain.Model.Common.Synth.OldParameters;
using Domain.Model.Common.Synth.PatchDrumKits;
using Domain.Model.Common.Synth.PatchInterfaces;
using Domain.Model.Common.Synth.PatchWaveSequences;

namespace Domain.Model.Common.Synth.PatchPrograms
{
    /// <summary>
    /// IMPR: FixedParameter only used for certain programs (MS2000/micro)
    /// </summary>
    public interface IProgram : IPatch, ICategoriesNamable, IFixedParameterValue, IReferencable, IDrumTrackReference
    {
        List<IDrumKit> UsedDrumKits { get; }

        /// <summary>
        /// Replaces all occurences of patch to the new drum kit.
        /// </summary>
        /// <param name="changes"></param>
        void ReplaceDrumKit(Dictionary<IDrumKit, IDrumKit> changes);


        /// <summary>
        /// 
        /// </summary>
        IEnumerable<IWaveSequence> UsedWaveSequences { get; } 


        /// <summary>
        /// Replaces all occurences of patch to the new wave sequence.
        /// </summary>
        /// <param name="changes"></param>
        void ReplaceWaveSequence(Dictionary<IWaveSequence, IWaveSequence> changes);


        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        IParameter GetParam(ParameterNames.ProgramParameterName name);


        /// <summary>
        /// Return wave sequence in the specified osc/zone
        /// </summary>
        /// <param name="osc"></param>
        /// /// <param name="zone"></param>
        /// <returns></returns>
        IWaveSequence GetUsedWaveSequence(int osc, int zone);


        /// <summary>
        /// Sets wave sequence in the specified zone
        /// </summary>
        /// <param name="osc"></param>
        /// <param name="zone"></param>
        /// /// <param name="waveSequence"></param>
        void SetWaveSequence(int osc, int zone, IWaveSequence waveSequence);
    }
}