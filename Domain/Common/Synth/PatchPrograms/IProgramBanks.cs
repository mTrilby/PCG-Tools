#region copyright

// (c) Copyright 2011-2023 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

#region using

using System.Collections.Generic;
using PcgTools.Model.Common.Synth.Meta;
using PcgTools.Model.Common.Synth.PatchDrumKits;
using PcgTools.Model.Common.Synth.PatchWaveSequences;

#endregion

namespace PcgTools.Model.Common.Synth.PatchPrograms
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