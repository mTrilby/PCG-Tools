using System;
using Domain.MasterFiles;
using Domain.Model.Common.Synth.Meta;
using Domain.Model.Common.Synth.PatchDrumKits;
using Domain.Model.MSpecific.Synth;

// (c) 2011 Michel Keijzers

namespace Domain.Model.KromeExSpecific.Synth
{
    /// <summary>
    /// 
    /// </summary>
    public class KromeExDrumKitBank : MDrumKitBank
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="drumKitBanks"></param>
        /// <param name="type"></param>
        /// <param name="id"></param>
        /// <param name="pcgId"></param>
        public KromeExDrumKitBank(IDrumKitBanks drumKitBanks, BankTypeEType type, string id, int pcgId)
            : base(drumKitBanks, type, id, pcgId)
        {
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="index"></param>
        public override void CreatePatch(int index)
        {
            Add(new KromeExDrumKit(this, index));
        }


        /// <summary>
        /// 
        /// </summary>
        public override int NrOfPatches
        {
            get
            {
                int nrOfPatches;
                switch (Type)
                {
                    case BankTypeEType.Int:
                        nrOfPatches = 48;
                        break;

                    case BankTypeEType.User:
                        nrOfPatches = 80 -48;
                        break;

                    case BankTypeEType.Gm:
                        nrOfPatches = 88 - 80;
                        break;

                    default:
                        throw new NotSupportedException();
                }

                return nrOfPatches;
            }
        }
    }
}
