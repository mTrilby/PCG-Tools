// (c) Copyright 2011-2019 MiKeSoft, Michel Keijzers, All rights reserved


using Domain.Model.Common.Synth.MemoryAndFactory;
using Domain.Model.Common.Synth.Meta;

namespace Domain.Model.Common.Synth.OldParameters
{
    /// <summary>
    /// 
    /// </summary>
    public interface IFixedParameter : IParameter
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="memory"></param>
        /// <param name="data"></param>
        /// <param name="type"></param>
        /// <param name="patch"></param>
        void Set(IMemory memory, byte[] data, FixedParameter.EType type, IPatch patch);
    }
}