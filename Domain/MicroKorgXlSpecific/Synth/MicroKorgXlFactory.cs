#region copyright

// (c) Copyright 2011-2023 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

#region using

using PcgTools.Model.Common.File;
using PcgTools.Model.Common.Synth.MemoryAndFactory;
using PcgTools.Model.Common.Synth.SongsRelated;
using PcgTools.Model.MicroKorgXlSpecific.Pcg;
using PcgTools.Model.MicroKorgXlSpecific.Song;
using PcgTools.Model.MSpecific.Synth;

#endregion

namespace PcgTools.Model.MicroKorgXlSpecific.Synth
{
    /// <summary>
    /// </summary>
    public class MicroKorgXlFactory : MFactory
    {
        /// <summary>
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        public override IPcgMemory CreatePcgMemory(string fileName)
        {
            PcgMemory pcgMemory = new MicroKorgXlMkxlAllMemory(fileName);
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
            return new MicroKorgXlMkxlAllFileReader(pcgMemory, content);
        }

        /// <summary>
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        public override ISongMemory CreateSongMemory(string fileName)
        {
            SongMemory songMemory = new MicroKorgXlSongMemory(fileName);
            return songMemory;
        }

        /// <summary>
        /// </summary>
        /// <param name="memory"></param>
        /// <param name="content"></param>
        /// <returns></returns>
        public override ISongFileReader CreateSongFileReader(ISongMemory memory, byte[] content)
        {
            return new MicroKorgXlSongFileReader(memory, content);
        }
    }
}