#region copyright

// (c) Copyright 2011-2022 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

using System.Collections.Generic;
using PcgTools.Model.Common.Synth.MemoryAndFactory;
using PcgTools.Model.Common.Synth.Meta;
using PcgTools.Model.Common.Synth.PatchPrograms;

namespace PcgTools.Model.Common.Synth.PatchCombis
{
    /// <summary>
    /// </summary>
    public interface ICombiBanks : IBanks
    {
        void ChangeTimbreReferences(Dictionary<IProgram, IProgram> changes, IPcgMemory pcgMemory);
    }
}