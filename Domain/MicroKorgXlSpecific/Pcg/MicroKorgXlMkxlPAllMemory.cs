#region copyright

// (c) Copyright 2011-2023 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

#region using

using PcgTools.Model.Common.Synth.MemoryAndFactory;

#endregion

namespace PcgTools.Model.MicroKorgXlSpecific.Pcg
{
    /// <summary>
    /// </summary>
    public class MicroKorgXlMkxlPAllMemory : MicroKorgXlMkxlAllMemory
    {
        /// <summary>
        /// </summary>
        /// <param name="fileName"></param>
        public MicroKorgXlMkxlPAllMemory(string fileName)
            : base(fileName)
        {
            // Overwrite model.
            Model = Models.Find(Models.EOsVersion.EOsVersionMicroKorgXlPlus);
        }
    }
}