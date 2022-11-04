#region copyright

// (c) Copyright 2011-2022 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

using Domain.Common.Synth.MemoryAndFactory;

namespace Domain.Common.Synth.PatchInterfaces
{
    public interface IPcgNavigable : INavigable
    {
        IPcgMemory PcgRoot { get; }
    }
}