#region copyright

// (c) Copyright 2011-2023 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

#region using

using System.Collections.Generic;
using Domain.Common.Synth.Meta;
using Domain.Common.Synth.PatchDrumKits;
using Domain.Common.Synth.PatchWaveSequences;

#endregion

namespace Domain.Common.Synth.PatchPrograms
{
    /// <summary>
    /// </summary>
    public interface IProgramBanks : IBanks
    {
        /// <summary>
        /// </summary>
        /// <param name="changes"></param>
        void ChangeDrumKitReferences(
            Dictionary<IDrumKit, IDrumKit> changes);

        /// <summary>
        /// </summary>
        /// <param name="changes"></param>
        void ChangeWaveSequenceReferences(
            Dictionary<IWaveSequence, IWaveSequence> changes);
    }
}