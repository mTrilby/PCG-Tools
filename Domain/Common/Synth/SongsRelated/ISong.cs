#region copyright

// (c) Copyright 2011-2023 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

#region using

using System.ComponentModel;
using PcgTools.Model.Common.Synth.PatchInterfaces;

#endregion

namespace PcgTools.Model.Common.Synth.SongsRelated
{
    /// <summary>
    /// </summary>
    public interface ISong : ISelectable, INotifyPropertyChanged, INavigable, ILocatable, INamable
    {
        /// <summary>
        /// </summary>
        ISongTimbres Timbres { get; }

        /// <summary>
        /// </summary>
        ISongMemory Memory { get; }
    }
}