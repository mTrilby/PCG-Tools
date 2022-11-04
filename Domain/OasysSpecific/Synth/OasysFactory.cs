#region copyright

// (c) Copyright 2011-2022 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

using Domain.Common.File;
using Domain.Common.Synth.MemoryAndFactory;
using Domain.Common.Synth.SongsRelated;
using Domain.KronosOasysSpecific.Synth;
using Domain.OasysSpecific.Pcg;
using Domain.OasysSpecific.Song;

namespace Domain.OasysSpecific.Synth
{
    /// <summary>
    /// </summary>
    public class OasysFactory : KronosOasysFactory
    {
        /// <summary>
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        public override IPcgMemory CreatePcgMemory(string fileName)
        {
            IPcgMemory pcgMemory = new OasysPcgMemory(fileName);
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
            return new OasysPcgFileReader(pcgMemory, content);
        }


        /// <summary>
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        public override ISongMemory CreateSongMemory(string fileName)
        {
            ISongMemory songMemory = new OasysSongMemory(fileName);
            return songMemory;
        }


        /// <summary>
        /// </summary>
        /// <param name="memory"></param>
        /// <param name="content"></param>
        /// <returns></returns>
        public override ISongFileReader CreateSongFileReader(ISongMemory memory, byte[] content)
        {
            return new OasysSongFileReader(memory, content);
        }
    }
}