#region copyright

// (c) Copyright 2011-2023 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

#region using

using PcgTools.Model.Common.Synth.Meta;

#endregion

namespace PcgTools.Model.Common.Synth.PatchDrumKits
{
    /// <summary>
    /// </summary>
    public interface IDrumKitBanks : IBanks
    {
        /// <summary>
        /// </summary>
        int Drk2PcgOffset { get; set; }

        /// <summary>
        ///     Returns the indexToSearch, starting with indexToSearch 0 as first bank, first indexToSearch,
        ///     and continuing over banks.
        /// </summary>
        /// <param name="indexToSearch"></param>
        /// <returns></returns>
        IDrumKit GetByIndex(int indexToSearch);

        /// <summary>
        ///     Returns the drum kit index.
        /// </summary>
        /// <param name="drumKit"></param>
        /// <returns></returns>
        int FindIndexOf(IDrumKit drumKit);
    }
}