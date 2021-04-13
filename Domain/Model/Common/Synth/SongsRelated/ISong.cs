// (c) Copyright 2011-2019 MiKeSoft, Michel Keijzers, All rights reserved

using System.ComponentModel;
using Domain.Model.Common.Synth.PatchInterfaces;

namespace Domain.Model.Common.Synth.SongsRelated
{
    /// <summary>
    /// 
    /// </summary>
    public interface ISong : ISelectable, INotifyPropertyChanged, INavigable, ILocatable, INamable
    {
        /// <summary>
        /// 
        /// </summary>
        ISongTimbres Timbres { get; }

        
        /// <summary>
        /// 
        /// </summary>
        ISongMemory Memory { get; }
    }
}
