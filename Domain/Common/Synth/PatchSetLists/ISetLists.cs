#region copyright

// (c) Copyright 2011-2022 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

using System.Collections.Generic;
using Domain.Common.Synth.Meta;
using Domain.Common.Synth.PatchCombis;
using Domain.Common.Synth.PatchPrograms;

namespace Domain.Common.Synth.PatchSetLists
{
    /// <summary>
    /// </summary>
    public interface ISetLists : IBanks
    {
        /// <summary>
        /// </summary>
        int Stl2PcgOffset { get; set; }

        /// <summary>
        /// </summary>
        /// <param name="changes"></param>
        void ChangeProgramReferences(Dictionary<IProgram, IProgram> changes);


        /// <summary>
        /// </summary>
        /// <param name="changes"></param>
        void ChangeCombiReferences(Dictionary<ICombi, ICombi> changes);
    }
}