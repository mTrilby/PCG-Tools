#region copyright

// (c) Copyright 2011-2023 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

#region using

using Common.MVVM;
using Domain.Common.Synth.MemoryAndFactory;
using Domain.Common.Synth.PatchCombis;
using Domain.Common.Synth.PatchInterfaces;

#endregion

namespace Domain.Common.Synth.SongsRelated
{
    public class SongTimbres : ISongTimbres
    {
        /// <summary>
        /// </summary>
        private readonly ISong _song;

        /// <summary>
        /// </summary>
        public SongTimbres(ISong song)
        {
            _song = song;
            TimbresCollection = new ObservableCollectionEx<ITimbre>();
        }

        /// <summary>
        /// </summary>
        public int ByteLength { get; set; }

        /// <summary>
        /// </summary>
        public ObservableCollectionEx<ITimbre> TimbresCollection { get; }

        /// <summary>
        /// </summary>
        public IMemory Root => _song.Memory;

        /// <summary>
        /// </summary>
        public INavigable Parent => _song;

        /// <summary>
        /// </summary>
        public int ByteOffset { get; set; }
    }
}