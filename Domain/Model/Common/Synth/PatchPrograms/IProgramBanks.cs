// (c) Copyright 2011-2019 MiKeSoft, Michel Keijzers, All rights reserved

using Domain.Model.Common.Synth.Meta;

namespace Domain.Model.Common.Synth.PatchPrograms
{
    /// <summary>
    /// 
    /// </summary>
    public interface IProgramBanks : IBanks
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="changes"></param>
        void ChangeDrumKitReferences(
            System.Collections.Generic.Dictionary<PatchDrumKits.IDrumKit, PatchDrumKits.IDrumKit> changes);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="changes"></param>
        void ChangeWaveSequenceReferences(
            System.Collections.Generic.Dictionary<PatchWaveSequences.IWaveSequence, PatchWaveSequences.IWaveSequence> changes);
    }
}
