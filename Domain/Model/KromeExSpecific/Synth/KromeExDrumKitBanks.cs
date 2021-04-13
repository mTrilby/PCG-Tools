

// (c) 2011 Michel Keijzers

using Domain.Model.Common.Synth.MemoryAndFactory;
using Domain.Model.Common.Synth.Meta;
using Domain.Model.Common.Synth.PatchDrumKits;

namespace Domain.Model.KromeExSpecific.Synth
{
    /// <summary>
    /// 
    /// </summary>
    public class KromeExDrumKitBanks : DrumKitBanks
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pcgMemory"></param>
        public KromeExDrumKitBanks(PcgMemory pcgMemory)
            : base(pcgMemory)
        {
        }


        /// <summary>
        /// 
        /// </summary>
        protected override void CreateBanks()
        {
            // 00(INT)..47(INT)
            //48(USER)..79(USER)
            //80(GM)..88(USER)
            Add(new KromeExDrumKitBank(this, BankTypeEType.Int , "INT", -1));
            Add(new KromeExDrumKitBank(this, BankTypeEType.User, "USER", -1));
            Add(new KromeExDrumKitBank(this, BankTypeEType.Gm  , "GM", -1));
        }
    }
}
