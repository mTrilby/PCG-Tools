// (c) Copyright 2011-2019 MiKeSoft, Michel Keijzers, All rights reserved

using System;
using Domain.Model.Common.Synth.MemoryAndFactory;
using Domain.Model.KronosOasysSpecific.Pcg;

namespace Domain.Model.KronosSpecific.Pcg
{
    /// <summary>
    /// 
    /// </summary>
    public class KronosPcgFileReader : KronosOasysPcgFileReader
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="currentPcgMemory"></param>
        /// <param name="content"></param>
        public KronosPcgFileReader(IPcgMemory currentPcgMemory, byte[] content)
            : base(currentPcgMemory, content)
        {
            // PcgFileHeader PcgFileHeader;
            // Pcg1Chunk Pcg1Chunk;
            // Div1Chunk Div1Chunk;
            // Ini2Chunk Ini2Chunk;
            // Ini1Chunk Ini1Chunk;
            // Sls1Chunk Sls1Chunk;
            // Prg1Chunk Prg1Chunk;
            // Cmb1Chunk Cmb1Chunk;
            // Dkt1Chunk Dkt1Chunk;
            // Arp1Chunk Arp1Chunk;
            // Glb1Chunk Glb1Chunk;

            // Checksum flag -> used since Kronos OS 2.x, 1 = OS2.x, 2 = OS3.x
            switch (content[7])
            {
                case 0:
                    currentPcgMemory.Model = Models.Find(ModelsEOsVersion.EOsVersionKronos10_11);
                     // Will be later set to 1.5/1.6 in case an XXX2 or 3 chunk is found.
                    break;

                case 1:
                    currentPcgMemory.Model = Models.Find(ModelsEOsVersion.EOsVersionKronos2x);
                    currentPcgMemory.PcgChecksumType = PcgMemoryChecksumType.Kronos2XOr3X;
                    break;

                case 2:
                    currentPcgMemory.Model = Models.Find(ModelsEOsVersion.EOsVersionKronos3x);
                    currentPcgMemory.PcgChecksumType = PcgMemoryChecksumType.Kronos2XOr3X;
                    break;

                default:
                    throw new ApplicationException("Unsupported file");
            }
        }

        protected override int Dpi1NumberOfDrumPatternsOffset
        {
            get { throw new NotImplementedException(); }
        }
    }
}