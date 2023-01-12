#region copyright

// (c) Copyright 2011-2023 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

#region using

using System.Collections.Generic;
using Domain.Common.Synth.MemoryAndFactory;
using Domain.Common.Synth.Meta;
using Domain.Common.Synth.PatchPrograms;

#endregion

namespace Domain.Common.Synth.PatchCombis
{
    /// <summary>
    /// </summary>
    public interface ICombiBanks : IBanks
    {
        void ChangeTimbreReferences(Dictionary<IProgram, IProgram> changes, IPcgMemory pcgMemory);
    }
}