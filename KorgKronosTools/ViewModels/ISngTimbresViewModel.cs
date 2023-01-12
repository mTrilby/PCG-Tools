#region copyright

// (c) Copyright 2011-2023 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

#region using

using System;
using Domain.Common;
using Domain.Common.Synth.SongsRelated;

#endregion

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