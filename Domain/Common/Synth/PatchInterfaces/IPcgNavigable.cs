#region copyright

// (c) Copyright 2011-2023 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

#region using

using Domain.Common.Synth.MemoryAndFactory;

#endregion

namespace Domain.Common.Synth.PatchInterfaces
{
    public interface IPcgNavigable : INavigable
    {
        IPcgMemory PcgRoot { get; }
    }
}