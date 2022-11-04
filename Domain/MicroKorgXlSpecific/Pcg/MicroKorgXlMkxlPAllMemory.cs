#region copyright

// (c) Copyright 2011-2022 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

using Domain.Common.Synth.MemoryAndFactory;

namespace Domain.MicroKorgXlSpecific.Pcg
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