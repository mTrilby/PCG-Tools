#region copyright

// (c) Copyright 2011-2022 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

using Domain.Common.File;
using Domain.Common.Synth.MemoryAndFactory;
using Domain.Common.Synth.SongsRelated;
using Domain.KronosOasysSpecific.Synth;
using Domain.KronosSpecific.Pcg;
using Domain.KronosSpecific.Song;

namespace Domain.KronosSpecific.Synth
{
    /// <summary>
    /// </summary>
    public class KronosFactory : KronosOasysFactory
    {
        /// <summary>
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        public override IPcgMemory CreatePcgMemory(string fileName)
        {
            PcgMemory pcgMemory = new KronosPcgMemory(fileName);
            pcgMemory.Fill();
            return pcgMemory;
        }


        /// <summary>
        /// </summary>
        /// <param name="memory"></param>
        /// <param name="content"></param>
        /// <returns></returns>
        public override IPatchesFileReader CreateFileReader(IPcgMemory memory, byte[] content)
        {
            return new KronosPcgFileReader(memory, content);
        }


        /// <summary>
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        public override ISongMemory CreateSongMemory(string fileName)
        {
            ISongMemory songMemory = new KronosSongMemory(fileName);
            return songMemory;
        }


        /// <summary>
        /// </summary>
        /// <param name="memory"></param>
        /// <param name="content"></param>
        /// <returns></returns>
        public override ISongFileReader CreateSongFileReader(ISongMemory memory, byte[] content)
        {
            return new KronosSongFileReader(memory, content);
        }
    }
}