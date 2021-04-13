// (c) Copyright 2011-2019 MiKeSoft, Michel Keijzers, All rights reserved

using System.Collections.Generic;
using Domain.Model.Common.Synth.Meta;
using Domain.Model.Common.Synth.PatchCombis;
using Domain.Model.Common.Synth.PatchPrograms;

namespace Domain.Model.Common.Synth.PatchSetLists
{
    /// <summary>
    /// 
    /// </summary>
    public interface ISetLists : IBanks
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="changes"></param>
        void ChangeProgramReferences(Dictionary<IProgram, IProgram> changes);


        /// <summary>
        /// 
        /// </summary>
        /// <param name="changes"></param>
        void ChangeCombiReferences(Dictionary<ICombi, ICombi> changes);


        /// <summary>
        /// 
        /// </summary>
        int Stl2PcgOffset { get; set; }
    }
}
