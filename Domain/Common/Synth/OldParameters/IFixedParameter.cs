#region copyright

// (c) Copyright 2011-2022 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

using Domain.Common.Synth.MemoryAndFactory;
using Domain.Common.Synth.Meta;

namespace Domain.Common.Synth.OldParameters
{
    /// <summary>
    /// </summary>
    public interface IFixedParameter : IParameter
    {
        /// <summary>
        /// </summary>
        /// <param name="memory"></param>
        /// <param name="data"></param>
        /// <param name="type"></param>
        /// <param name="patch"></param>
        void Set(IMemory memory, byte[] data, FixedParameter.EType type, IPatch patch);
    }
}