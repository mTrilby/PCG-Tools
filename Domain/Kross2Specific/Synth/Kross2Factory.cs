#region copyright

// (c) Copyright 2011-2023 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

#region using

using Domain.Common;
using Domain.Common.File;
using Domain.Common.Synth.MemoryAndFactory;
using Domain.Common.Synth.SongsRelated;
using Domain.Kross2Specific.Pcg;
using Domain.Kross2Specific.Song;
using Domain.MSpecific.Synth;

#endregion

namespace Domain.Kross2Specific.Synth
{
    /// <summary>
    /// </summary>
    public class Kross2Factory : MFactory
    {
        /// <summary>
        /// </summary>
        private readonly PcgMemory.ContentType _contentType;

        /// <summary>
        /// </summary>
        /// <param name="contentType"></param>
        public Kross2Factory(PcgMemory.ContentType contentType)
        {
            _contentType = contentType;
        }

        /// <summary>
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        public override IPcgMemory CreatePcgMemory(string fileName)
        {
            PcgMemory pcgMemory = new Kross2PcgMemory(fileName);
            pcgMemory.Fill();
            return pcgMemory;
        }

        /// <summary>
        /// </summary>
        /// <param name="pcgMemory"></param>
        /// <param name="content"></param>
        /// <returns></returns>
        public override IPatchesFileReader CreateFileReader(IPcgMemory pcgMemory, byte[] content)
        {
            PatchesFileReader reader;
            if (Util.GetChars(content, 0, 2) == "tr")
            {
                reader = new Kross2TrFileReader(pcgMemory, content, _contentType);
            }
            else
            {
                reader = new Kross2PcgFileReader(pcgMemory, content);
            }

            return reader;
        }

        /// <summary>
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        public override ISongMemory CreateSongMemory(string fileName)
        {
            SongMemory songMemory = new Kross2SongMemory(fileName);
            return songMemory;
        }

        /// <summary>
        /// </summary>
        /// <param name="memory"></param>
        /// <param name="content"></param>
        /// <returns></returns>
        public override ISongFileReader CreateSongFileReader(ISongMemory memory, byte[] content)
        {
            return new Kross2SongFileReader(memory, content);
        }
    }
}