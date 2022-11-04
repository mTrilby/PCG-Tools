#region copyright

// (c) Copyright 2011-2022 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

using Domain.Common.File;
using Domain.Common.Synth.MemoryAndFactory;
using Domain.Common.Synth.SongsRelated;
using Domain.TrinitySpecific.Pcg;
using Domain.TritonSpecific.Synth;

namespace Domain.TrinitySpecific.Synth
{
    /// <summary>
    /// </summary>
    public class TrinityFactory : TritonFactory
    {
        /// <summary>
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        public override IPcgMemory CreatePcgMemory(string fileName)
        {
            PcgMemory pcgMemory = new TrinityPcgMemory(fileName, Models.EModelType.Trinity);
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
            return new TrinityPcgFileReader(pcgMemory, content);
        }


        /// <summary>
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        public override ISongMemory CreateSongMemory(string fileName)
        {
            return null; // Not supported
        }


        /// <summary>
        /// </summary>
        /// <param name="memory"></param>
        /// <param name="content"></param>
        /// <returns></returns>
        public override ISongFileReader CreateSongFileReader(ISongMemory memory, byte[] content)
        {
            return null; // Not supported
        }
    }
}