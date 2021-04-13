// (c) Copyright 2011-2019 MiKeSoft, Michel Keijzers, All rights reserved

using Domain.Model.Common.Synth.Meta;

namespace Domain.Model.Common.Synth.PatchPrograms
{
    /// <summary>
    /// 
    /// </summary>
    public interface IProgramBank : IBank
    {
        /// <summary>
        /// 
        /// </summary>
        bool IsModeled { get; }


        /// <summary>
        /// 
        /// </summary>
        ProgramBankSynthesisType BankSynthesisType { get; set;  }


        /// <summary>
        /// 
        /// </summary>
        ProgramBankSynthesisType DefaultSampledSynthesisType { get; }
    }
}
