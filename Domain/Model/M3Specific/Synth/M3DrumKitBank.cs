using Domain.MasterFiles;
using Domain.Model.Common.Synth.Meta;
using Domain.Model.Common.Synth.PatchDrumKits;
using Domain.Model.MSpecific.Synth;

// (c) 2011 Michel Keijzers

namespace Domain.Model.M3Specific.Synth
{
    /// <summary>
    /// 
    /// </summary>
    public class M3DrumKitBank : MDrumKitBank
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="drumKitBanks"></param>
        /// <param name="type"></param>
        /// <param name="id"></param>
        /// <param name="pcgId"></param>
        public M3DrumKitBank(IDrumKitBanks drumKitBanks, BankTypeEType type, string id, int pcgId)
            : base(drumKitBanks, type, id, pcgId)
        {
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="index"></param>
        public override void CreatePatch(int index)
        {
            Add(new M3DrumKit(this, index));
        }
    }
}