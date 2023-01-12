#region copyright

// (c) Copyright 2011-2023 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

#region using

using PcgTools.Model.Common.Synth.Meta;
using PcgTools.Model.Common.Synth.PatchCombis;
using PcgTools.Model.MntxSeriesSpecific.Synth;

#endregion

namespace PcgTools.Model.M1Specific.Synth
{
    /// <summary>
    /// </summary>
    public class M1CombiBank : MntxCombiBank
    {
        /// <summary>
        /// </summary>
        /// <param name="combiBanks"></param>
        /// <param name="type"></param>
        /// <param name="id"></param>
        /// <param name="pcgId"></param>
        public M1CombiBank(ICombiBanks combiBanks, BankType.EType type, string id, int pcgId)
            : base(combiBanks, type, id, pcgId)
        {
        }

        /// <summary>
        /// </summary>
        public override int NrOfPatches => 100;

        /// <summary>
        /// </summary>
        /// <param name="index"></param>
        public override void CreatePatch(int index)
        {
            Add(new M1Combi(this, index));
        }
    }
}