﻿// (c) Copyright 2011-2019 MiKeSoft, Michel Keijzers, All rights reserved

using PcgTools.Model.Common.Synth.MemoryAndFactory;

namespace PcgTools.Model.Common.Synth.SongsRelated
{
    /// <summary>
    ///
    /// </summary>
    public abstract class SongMemory : Memory, ISongMemory
    {
        /// <summary>
        ///
        /// </summary>
        public ISongs Songs { get; private set; }


        /// <summary>
        ///
        /// </summary>
        public IRegions Regions { get; private set; }


        /// <summary>
        ///
        /// </summary>
        /// <param name="fileName"></param>
        protected SongMemory(string fileName)
        {
            OriginalFileName = fileName;
            FileName = fileName;
            MemoryFileType = FileType.Sng;
            Songs = new Songs();
            Regions = new Regions();
            ConnectedPcgMemory = null;
        }


        /// <summary>
        ///
        /// </summary>
        /// <param name="saveAs"></param>
        /// <param name="saveToFile"></param>
        public override void SaveFile(bool saveAs, bool saveToFile)
        {
            System.IO.File.WriteAllBytes(FileName, Content);
            IsDirty = false;
        }


        /// <summary>
        ///
        /// </summary>
        private IPcgMemory _connectedPcgMemory;


        /// <summary>
        /// PCG memory is connected with; should be of same model.
        /// </summary>
        public IPcgMemory ConnectedPcgMemory
        {
            get { return _connectedPcgMemory; }

            set
            {
                if (_connectedPcgMemory != value)
                {
                    _connectedPcgMemory = value;
                    OnPropertyChanged("ConnectedPcgMemory");
                }
            }
        }
    }
}