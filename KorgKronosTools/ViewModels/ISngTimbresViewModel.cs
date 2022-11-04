#region copyright

// (c) Copyright 2011-2022 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

using System;
using PcgTools.Model.Common.Synth.SongsRelated;

namespace PcgTools.ViewModels
{
    public interface ISngTimbresViewModel : IViewModel
    {
        /// <summary>
        /// </summary>
        ISong Song { get; }


        /// <summary>
        /// </summary>
        Action UpdateUiContent { get; }
    }
}