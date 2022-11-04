#region copyright

// (c) Copyright 2011-2022 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

using Domain.Common.File;
using Domain.Common.Synth.MemoryAndFactory;
using Domain.Common.Synth.SongsRelated;
using Domain.TritonKarmaSpecific.Pcg;
using Domain.TritonKarmaSpecific.Song;
using Domain.TritonSpecific.Synth;

namespace Domain.TritonKarmaSpecific.Synth
{
    /// <summary>
    /// </summary>
    public class TritonKarmaFactory : TritonFactory
    {
        /// <summary>
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        public override IPcgMemory CreatePcgMemory(string fileName)
        {
            IPcgMemory pcgMemory = new TritonKarmaPcgMemory(fileName);
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
            return new TritonKarmaPcgFileReader(pcgMemory, content);
        }


        /// <summary>
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        public override ISongMemory CreateSongMemory(string fileName)
        {
            ISongMemory songMemory = new TritonKarmaSongMemory(fileName);
            return songMemory;
        }


        /// <summary>
        /// </summary>
        /// <param name="memory"></param>
        /// <param name="content"></param>
        /// <returns></returns>
        public override ISongFileReader CreateSongFileReader(ISongMemory memory, byte[] content)
        {
            return new TritonKarmaSongFileReader(memory, content);
        }
    }
}