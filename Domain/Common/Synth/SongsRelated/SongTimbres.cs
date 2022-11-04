﻿#region copyright

// (c) Copyright 2011-2022 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

using PcgTools.Model.Common.Synth.MemoryAndFactory;
using PcgTools.Model.Common.Synth.PatchCombis;
using PcgTools.Model.Common.Synth.PatchInterfaces;
using PcgTools.Mvvm;

namespace PcgTools.Model.Common.Synth.SongsRelated
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