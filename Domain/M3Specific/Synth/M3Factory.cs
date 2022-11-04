#region copyright

// (c) Copyright 2011-2022 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

using Domain.Common.File;
using Domain.Common.Synth.MemoryAndFactory;
using Domain.Common.Synth.SongsRelated;
using Domain.M3Specific.Pcg;
using Domain.M3Specific.Song;
using Domain.MSpecific.Synth;

namespace Domain.M3Specific.Synth
{
    /// <summary>
    /// </summary>
    public class M3Factory : MFactory
    {
        /// <summary>
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        public override IPcgMemory CreatePcgMemory(string fileName)
        {
            PcgMemory pcgMemory = new M3PcgMemory(fileName);
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
            return new M3PcgFileReader(pcgMemory, content);
        }


        /// <summary>
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        public override ISongMemory CreateSongMemory(string fileName)
        {
            SongMemory songMemory = new M3SongMemory(fileName);
            return songMemory;
        }


        /// <summary>
        /// </summary>
        /// <param name="memory"></param>
        /// <param name="content"></param>
        /// <returns></returns>
        public override ISongFileReader CreateSongFileReader(ISongMemory memory, byte[] content)
        {
            return new M3SongFileReader(memory, content);
        }
    }
}