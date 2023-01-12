#region copyright

// (c) Copyright 2011-2023 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

#region using

using PcgTools.Model.Common.Synth.MemoryAndFactory;

#endregion

namespace PcgTools.Model.Common.Synth.SongsRelated
{
    /// <summary>
    /// </summary>
    public abstract class SongMemory : Memory, ISongMemory
    {
        /// <summary>
        /// </summary>
        private IPcgMemory _connectedPcgMemory;

        /// <summary>
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
        /// </summary>
        public ISongs Songs { get; }

        /// <summary>
        /// </summary>
        public IRegions Regions { get; }

        /// <summary>
        /// </summary>
        /// <param name="saveAs"></param>
        /// <param name="saveToFile"></param>
        public override void SaveFile(bool saveAs, bool saveToFile)
        {
            System.IO.File.WriteAllBytes(FileName, Content);
            IsDirty = false;
        }

        /// <summary>
        ///     PCG memory is connected with; should be of same model.
        /// </summary>
        public IPcgMemory ConnectedPcgMemory
        {
            get => _connectedPcgMemory;

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