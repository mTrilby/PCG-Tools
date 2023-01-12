﻿#region copyright

// (c) Copyright 2011-2023 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

#region using

using Domain.Common.Synth.MemoryAndFactory;
using Domain.TritonSpecific.Song;

#endregion

namespace Domain.TritonTrClassicStudioRackSpecific.Song
{
    /// <summary>
    /// </summary>
    public class TritonTrClassicStudioRackSongMemory : TritonSongMemory
    {
        /// <summary>
        /// </summary>
        /// <param name="fileName"></param>
        public TritonTrClassicStudioRackSongMemory(string fileName)
            : base(fileName)
        {
            Model = Models.Find(Models.EOsVersion.EOsVersionTritonTrClassicStudioRack);
        }
    }
}