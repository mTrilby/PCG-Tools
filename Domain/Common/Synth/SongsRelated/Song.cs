#region copyright

// (c) Copyright 2011-2022 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

using System;
using Common.MVVM;
using Common.Utils;
using Domain.Common.File;
using Domain.Common.OpenedFiles;
using Domain.Common.Synth.MemoryAndFactory;
using Domain.Common.Synth.PatchInterfaces;

namespace Domain.Common.Synth.SongsRelated
{
    /// <summary>
    /// </summary>
    public class Song : ObservableObject, ISong
    {
        /// <summary>
        /// </summary>
        // ReSharper disable UnusedAutoPropertyAccessor.Local
        [UsedImplicitly]
        private int Index { [global::Common.Properties.UsedImplicitly] get; }


        /// <summary>
        /// </summary>
        public ISongMemory Memory { get; }


        /// <summary>
        /// </summary>
        public ISongTimbres Timbres { get; set; }


        /// <summary>
        /// </summary>
        private string _name;


        /// <summary>
        ///     Used for UI control binding for selections.
        /// </summary>
        private bool _isSelected;


        /// <summary>
        /// </summary>
        public bool IsSelected
        {
            get => _isSelected;
            set
            {
                if (_isSelected != value)
                {
                    _isSelected = value;
                    RaisePropertyChanged("IsSelected");
                }
            }
        }


        /// <summary>
        /// </summary>
        [UsedImplicitly]
        // ReSharper disable UnusedAutoPropertyAccessor.Local
        public string Name
        {
            [global::Common.Properties.UsedImplicitly] get => _name;
            set
            {
                if (value != _name)
                {
                    _name = value;
                    OnPropertyChanged("Name");
                }
            }
        }


        /// <summary>
        /// </summary>
        public int MaxNameLength => throw new NotImplementedException();


        /// <summary>
        /// </summary>
        /// <param name="strName"></param>
        /// <returns></returns>
        public bool IsNameLike(string strName)
        {
            throw new NotImplementedException();
        }


        public void SetNameSuffix(string suffix)
        {
            throw new NotImplementedException();
        }


        /// <summary>
        /// </summary>
        /// <param name="reader"></param>
        /// <param name="index"></param>
        /// <param name="memory"></param>
        /// <param name="name"></param>
        public Song(SongFileReader reader, int index, ISongMemory memory, string name)
        {
            Index = index;
            Memory = memory;
            Name = name;

            Timbres = new SongTimbres(this);

            for (var timbreIndex = 0; timbreIndex < reader.NumberOfSongTracks; timbreIndex++)
            {
                Timbres.TimbresCollection.Add(reader.CreateTimbre(Timbres, timbreIndex));
            }
        }


        /// <summary>
        /// </summary>
        public IMemory Root => Memory;


        /// <summary>
        /// </summary>
        public INavigable Parent => Memory;


        /// <summary>
        ///     Unused for songs.
        /// </summary>
        public int ByteOffset { get; set; }


        /// <summary>
        /// </summary>
        public int ByteLength { get; set; }


        /// <summary>
        ///     PCG file the song is connected with; should be of same model.
        /// </summary>
        public OpenedPcgWindow ConnectedPcgWindow { get; set; }
    }
}