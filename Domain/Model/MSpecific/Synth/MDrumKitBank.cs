using System;
using Domain.Model.Common.Synth.Meta;
using Domain.Model.Common.Synth.PatchDrumKits;

namespace Domain.Model.MSpecific.Synth
{
    /// <summary>
    /// 
    /// </summary>
    public abstract class MDrumKitBank : DrumKitBank
    {
        /// <summary>
        /// 
        /// </summary>
        public override int NrOfPatches
        {
            get
            {
                switch (Type)
                {
                    case BankTypeEType.Int:
                        return 32;

                    case BankTypeEType.User:
                        return 16;

                    default:
                        throw new NotSupportedException();
                }
            }
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="drumKitBanks"></param>
        /// <param name="type"></param>
        /// <param name="id"></param>
        /// <param name="pcgId"></param>
        protected MDrumKitBank(IBanks drumKitBanks, BankTypeEType type, string id, int pcgId)
            : base(drumKitBanks,type, id, pcgId)
        {
        }
    }
}
