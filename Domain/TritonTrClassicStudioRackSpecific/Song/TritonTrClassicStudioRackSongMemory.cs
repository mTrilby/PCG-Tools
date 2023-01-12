﻿#region copyright

// (c) Copyright 2011-2023 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

#region using

using PcgTools.Model.Common.Synth.MemoryAndFactory;
using PcgTools.Model.TritonSpecific.Song;

#endregion

namespace PcgTools.Model.TritonTrClassicStudioRackSpecific.Song
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