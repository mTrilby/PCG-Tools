#region copyright

// (c) Copyright 2011-2023 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

#region using

using System;
using PcgTools.Model.Common.Synth.PatchCombis;

#endregion

namespace PcgTools.ViewModels
{
    public interface ICombiViewModel : IViewModel
    {
        /// <summary>
        /// </summary>
        ICombi Combi { get; }

        /// <summary>
        /// </summary>
        Action UpdateUiContent { get; }
    }
}