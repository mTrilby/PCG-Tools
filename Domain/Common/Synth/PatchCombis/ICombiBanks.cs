#region copyright

// (c) Copyright 2011-2023 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

#region using

using System.Collections.Generic;
using PcgTools.Model.Common.Synth.MemoryAndFactory;
using PcgTools.Model.Common.Synth.Meta;
using PcgTools.Model.Common.Synth.PatchPrograms;

#endregion

namespace PcgTools.Model.Common.Synth.PatchCombis
{
    /// <summary>
    /// </summary>
    public interface ICombiBanks : IBanks
    {
        void ChangeTimbreReferences(Dictionary<IProgram, IProgram> changes, IPcgMemory pcgMemory);
    }
}