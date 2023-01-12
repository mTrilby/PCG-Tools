#region copyright

// (c) Copyright 2011-2023 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

#region using

using Domain.Common.File;
using Domain.Common.Synth.SongsRelated;

#endregion

namespace Domain.Common.Synth.MemoryAndFactory
{
    /// <summary>
    /// </summary>
    public interface IFactory
    {
        /// <summary>
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        IPcgMemory CreatePcgMemory(string fileName);

        /// <summary>
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        ISongMemory CreateSongMemory(string fileName);

        /// <summary>
        /// </summary>
        /// <param name="pcgMemory"></param>
        /// <param name="content"></param>
        /// <returns></returns>
        IPatchesFileReader CreateFileReader(IPcgMemory pcgMemory, byte[] content);

        /// <summary>
        /// </summary>
        /// <param name="songMemory"></param>
        /// <param name="content"></param>
        /// <returns></returns>
        ISongFileReader CreateSongFileReader(ISongMemory songMemory, byte[] content);
    }
}