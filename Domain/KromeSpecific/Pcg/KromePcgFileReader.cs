#region copyright

// (c) Copyright 2011-2022 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

using Domain.Common.Synth.MemoryAndFactory;
using Domain.MSpecific.Pcg;

namespace Domain.KromeSpecific.Pcg
{
    public class KromePcgFileReader : MPcgFileReader
    {
        /// <summary>
        /// </summary>
        /// <param name="currentPcgMemory"></param>
        /// <param name="content"></param>
        public KromePcgFileReader(IPcgMemory currentPcgMemory, byte[] content)
            : base(currentPcgMemory, content)
        {
            // PcgFileHeader PcgFileHeader;
            // Pcg1Chunk Pcg1Chunk;
            // Div1Chunk Div1Chunk;
            // Ini2Chunk Ini2Chunk;
            // Ini1Chunk Ini1Chunk;
            // Prg1Chunk Prg1Chunk;
            // Cmb1Chunk Cmb1Chunk;
            // Dkt1Chunk Dkt1Chunk;
            // Arp1Chunk Arp1Chunk;
            // Glb1Chunk Glb1Chunk;

            if (content[9] == 1)
            {
                currentPcgMemory.PcgChecksumType = PcgMemory.ChecksumType.Krome;
            }
        }
    }
}