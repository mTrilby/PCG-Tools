﻿#region copyright

// (c) Copyright 2011-2022 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

using System;
using Domain.Common.Synth.MemoryAndFactory;
using Domain.MSpecific.Pcg;

namespace Domain.MicroStationSpecific.Pcg
{
    /// <summary>
    /// </summary>
    public class MicroStationPcgFileReader : MPcgFileReader
    {
        /// <summary>
        /// </summary>
        /// <param name="currentPcgMemory"></param>
        /// <param name="content"></param>
        public MicroStationPcgFileReader(IPcgMemory currentPcgMemory, byte[] content)
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

            currentPcgMemory.PcgChecksumType = PcgMemory.ChecksumType.MicroStation;
        }

        protected override int Dpi1NumberOfDrumPatternsOffset => throw new NotImplementedException();
    }
}