﻿
using PcgTools.Model.Common.Synth.Meta;
using PcgTools.Model.Common.Synth.PatchDrumPatterns;
using PcgTools.Model.MSpecific.Synth;

// (c) 2011 Michel Keijzers

namespace PcgTools.Model.M3Specific.Synth
{
    /// <summary>
    /// 
    /// </summary>
    public class M3DrumPatternBank : MDrumPatternBank
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="drumPatternBanks"></param>
        /// <param name="type"></param>
        /// <param name="id"></param>
        /// <param name="pcgId"></param>
        public M3DrumPatternBank(IDrumPatternBanks drumPatternBanks, BankType.EType type, string id, int pcgId)
            : base(drumPatternBanks, type, id, pcgId)
        {
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="index"></param>
        public override void CreatePatch(int index)
        {
            Add(new M3DrumPattern(this, index));
        }
    }
}
