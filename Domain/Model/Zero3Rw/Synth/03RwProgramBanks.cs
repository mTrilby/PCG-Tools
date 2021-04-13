// (c) Copyright 2011-2019 MiKeSoft, Michel Keijzers, All rights reserved

using Domain.Model.Common.Synth.MemoryAndFactory;
using Domain.Model.Common.Synth.Meta;
using Domain.Model.Common.Synth.PatchPrograms;
using Domain.Model.ZeroSeries.Synth;

namespace Domain.Model.Zero3Rw.Synth
{
    /// <summary>
    /// 
    /// </summary>
    public class Zero3RwProgramBanks : ZeroSeriesProgramBanks
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pcgMemory"></param>
        public Zero3RwProgramBanks(IPcgMemory pcgMemory)
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
            foreach (var id in new[] {"A"}) // Banks C and D not used in file, pretending everything is in A.
            {
                Add(
                    new Zero3RwProgramBank(
                        this, BankTypeEType.Int, id, pcgId, ProgramBankSynthesisType.Ai2, string.Empty));
                pcgId++;
            }

            Add(new Zero3RwGmProgramBank(this, BankTypeEType.Gm, "GM", 255, ProgramBankSynthesisType.Ai2, "GM Bank"));
        }
    }
}
