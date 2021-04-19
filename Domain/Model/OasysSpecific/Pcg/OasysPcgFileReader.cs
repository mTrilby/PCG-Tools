﻿// (c) Copyright 2011-2019 MiKeSoft, Michel Keijzers, All rights reserved

using Domain.Model.Common.Synth.MemoryAndFactory;
using Domain.Model.KronosOasysSpecific.Pcg;

namespace Domain.Model.OasysSpecific.Pcg
{
    /// <summary>
    /// 
    /// </summary>
    public class OasysPcgFileReader : KronosOasysPcgFileReader
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="currentPcgMemory"></param>
        /// <param name="content"></param>
        public OasysPcgFileReader(IPcgMemory currentPcgMemory, byte[] content): 
            base(currentPcgMemory, content)
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
        }

        protected override int Dpi1NumberOfDrumPatternsOffset
        {
            get { throw new System.NotImplementedException(); }
        }
    }
}