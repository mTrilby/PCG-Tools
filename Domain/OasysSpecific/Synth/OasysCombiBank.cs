#region copyright

// (c) Copyright 2011-2023 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

#region using

using PcgTools.Model.Common.Synth.Meta;
using PcgTools.Model.Common.Synth.PatchCombis;
using PcgTools.Model.KronosOasysSpecific.Synth;

#endregion

namespace PcgTools.Model.OasysSpecific.Synth
{
    /// <summary>
    /// </summary>
    public class OasysCombiBank : KronosOasysCombiBank
    {
        /// <summary>
        /// </summary>
        /// <param name="combiBanks"></param>
        /// <param name="type"></param>
        /// <param name="id"></param>
        /// <param name="pcgId"></param>
        public OasysCombiBank(ICombiBanks combiBanks, BankType.EType type, string id, int pcgId) :
            base(combiBanks, type, id, pcgId)
        {
        }

        /// <summary>
        /// </summary>
        /// <param name="index"></param>
        public override void CreatePatch(int index)
        {
            Add(new OasysCombi(this, index));
        }
    }
}