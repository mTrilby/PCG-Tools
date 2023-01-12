#region copyright

// (c) Copyright 2011-2023 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

#region using

using System.ComponentModel;
using Domain.Common.Synth.PatchInterfaces;

#endregion

namespace Domain.Common.Synth.SongsRelated
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