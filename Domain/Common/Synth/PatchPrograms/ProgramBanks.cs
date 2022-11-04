#region copyright

// (c) Copyright 2011-2022 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

using System.Collections.Generic;
using System.Linq;
using Domain.Common.Synth.MemoryAndFactory;
using Domain.Common.Synth.Meta;
using Domain.Common.Synth.PatchDrumKits;
using Domain.Common.Synth.PatchWaveSequences;

namespace Domain.Common.Synth.PatchPrograms
{
    /// <summary>
    /// </summary>
    public abstract class ProgramBanks : Banks<IProgramBank>, IProgramBanks
    {
        // Virtual banks.

        /// <summary>
        /// </summary>
        public const int FirstVirtualBankId = 0x30;


        /// <summary>
        /// </summary>
        public const int NumberOfVirtualBanks = 100;

        /// <summary>
        /// </summary>
        /// <param name="pcgMemory"></param>
        protected ProgramBanks(IPcgMemory pcgMemory) : base(pcgMemory)
        {
        }


        /// <summary>
        /// </summary>
        // ReSharper disable once UnusedMember.Global
        public string Name => "n.a.";


        /// <summary>
        /// </summary>
        public override void Fill()
        {
            CreateBanks();
            FillPrograms();
        }


        /// <summary>
        /// </summary>
        /// <param name="pcgId"></param>
        /// <returns></returns>
        public override IBank GetBankWithPcgId(int pcgId)
        {
            var bank = base.GetBankWithPcgId(pcgId);

            // GM variation bank selected, select GM bank (last).
            if (bank == null)
            {
                bank = BankCollection.Last();
            }

            return bank;
        }


        /// <summary>
        ///     /// Changes drum kit references; only used from programs not from a master file.
        /// </summary>
        /// <param name="changes"></param>
        public void ChangeDrumKitReferences(Dictionary<IDrumKit, IDrumKit> changes)
        {
            foreach (var program in BankCollection.Where(bank => bank.IsFilled)
                         .SelectMany(bank => bank.Patches)
                         .Where(program => program.IsLoaded))
            {
                ((IProgram)program).ReplaceDrumKit(changes);
            }
        }


        /// <summary>
        ///     /// Changes wave sequence references; only used from programs not from a master file.
        /// </summary>
        /// <param name="changes"></param>
        public void ChangeWaveSequenceReferences(Dictionary<IWaveSequence, IWaveSequence> changes)
        {
            foreach (var program in BankCollection.Where(bank => bank.IsFilled && !((IProgramBank)bank).IsModeled)
                         .SelectMany(bank => bank.Patches)
                         .Where(program => program.IsLoaded))
            {
                ((IProgram)program).ReplaceWaveSequence(changes);
            }
        }


        // ISetNavigation
        /// <summary>
        ///     CountPatches filled banks (except GM banks).
        /// </summary>
        public override int CountFilledBanks
        {
            get { return BankCollection.Count(bank => bank.IsFilled && bank.Type != BankType.EType.Gm); }
        }


        /// <summary>
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public new IBank this[int index] => base[index];


        /// <summary>
        /// </summary>
        protected abstract void CreateBanks();


        /// <summary>
        /// </summary>
        private void FillPrograms()
        {
            foreach (var bank in BankCollection)
            {
                for (var index = 0; index < bank.NrOfPatches; index++)
                {
                    bank.CreatePatch(index);
                }
            }
        }


        /// <summary>
        /// </summary>
        // ReSharper disable once UnusedMemberInSuper.Global
        protected virtual void CreateVirtualBanks()
        {
            // Default do not create virtual banks.
        }
    }
}