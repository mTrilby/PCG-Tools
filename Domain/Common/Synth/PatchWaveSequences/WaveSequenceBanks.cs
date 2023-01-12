#region copyright

// (c) Copyright 2011-2023 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

#region using

using Domain.Common.Synth.MemoryAndFactory;
using Domain.Common.Synth.Meta;

#endregion

namespace Domain.Common.Synth.PatchWaveSequences
{
    /// <summary>
    /// </summary>
    public abstract class WaveSequenceBanks : Banks<IBank>, IWaveSequenceBanks
    {
        /// <summary>
        /// </summary>
        /// <param name="pcgMemory"></param>
        protected WaveSequenceBanks(IPcgMemory pcgMemory) : base(pcgMemory)
        {
        }

        /// <summary>
        /// </summary>
        public string Name => "n.a.";

        /// <summary>
        /// </summary>
        public override void Fill()
        {
            CreateBanks();
            FillWaveSequences();
        }

        /// <summary>
        /// </summary>
        public int Wsq2PcgOffset { get; set; }

        /// <summary>
        /// </summary>
        protected abstract void CreateBanks();

        /// <summary>
        /// </summary>
        private void FillWaveSequences()
        {
            foreach (var bank in BankCollection)
            {
                for (var index = 0; index < bank.NrOfPatches; index++)
                {
                    bank.CreatePatch(index);
                }
            }
        }
    }
}