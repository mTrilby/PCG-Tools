// (c) Copyright 2011-2019 MiKeSoft, Michel Keijzers, All rights reserved

using Domain.Model.Common.Synth.MemoryAndFactory;
using Domain.Model.Common.Synth.Meta;
using Domain.Model.Common.Synth.PatchPrograms;
using Domain.Model.MntxSeriesSpecific.Synth;

namespace Domain.Model.ZeroSeries.Synth
{
    /// <summary>
    /// 
    /// </summary>
    public class ZeroSeriesProgramBanks : MntxProgramBanks
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pcgMemory"></param>
        public ZeroSeriesProgramBanks(IPcgMemory pcgMemory)
            : base(pcgMemory)
        {
        }


        /// <summary>
        /// 
        /// </summary>
        protected override void CreateBanks()
        {
            // Add internal banks.
            var pcgId = 0;
            foreach (var id in new[] {"A", "B", "C", "D"})
            {
                Add(
                    new ZeroSeriesProgramBank(
                        this, BankTypeEType.Int, id, pcgId, ProgramBankSynthesisType.Ai2, string.Empty));
                pcgId++;
            }

            // Add virtual banks for raw disk image file.
            for (var id = 0; id <= 4; id++)
            {
                Add(new ZeroSeriesProgramBank(
                        this, BankTypeEType.Virtual, $"V{id + 1}", pcgId, 
                        ProgramBankSynthesisType.Ai2, string.Empty));
                pcgId++;
            }
        }
    }
}
