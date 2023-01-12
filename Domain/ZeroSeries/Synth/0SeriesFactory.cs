#region copyright

// (c) Copyright 2011-2023 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

#region using

using System;
using System.Diagnostics;
using Domain.Common.File;
using Domain.Common.Synth.MemoryAndFactory;
using Domain.Common.Synth.SongsRelated;
using Domain.MntxSeriesSpecific.Synth;
using Domain.ZeroSeries.Pcg;
using Domain.ZeroSeries.Song;

#endregion

namespace Domain.ZeroSeries.Synth
{
    /// <summary>
    /// </summary>
    public class ZeroSeriesFactory : MntxFactory
    {
        /// <summary>
        /// </summary>
        /// <param name="fileType"></param>
        /// <param name="contentType"></param>
        /// <param name="sysExStartOffset"></param>
        /// <param name="sysExEndOffset"></param>
        public ZeroSeriesFactory(Memory.FileType fileType, PcgMemory.ContentType contentType,
            int sysExStartOffset, int sysExEndOffset)
        {
            FileType = fileType;
            ContentType = contentType;
            SysExStartOffset = sysExStartOffset;
            SysExEndOffset = sysExEndOffset;
        }

        /// <summary>
        /// </summary>
        protected Memory.FileType FileType { get; }

        /// <summary>
        /// </summary>
        protected PcgMemory.ContentType ContentType { get; }

        /// <summary>
        /// </summary>
        protected int SysExStartOffset { get; }

        /// <summary>
        /// </summary>
        protected int SysExEndOffset { get; }

        /// <summary>
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        public override IPcgMemory CreatePcgMemory(string fileName)
        {
            IPcgMemory pcgMemory;

            switch (FileType)
            {
                case Memory.FileType.Syx: // Fall through
                case Memory.FileType.Mid: // Fall through
                case Memory.FileType.Raw:
                    pcgMemory = new ZeroSeriesSysExMemory(fileName, ContentType, SysExStartOffset, SysExEndOffset,
                        FileType ==
                        Memory.FileType.Raw);
                    break;

                default:
                    throw new NotSupportedException("Unsupported file type");
            }

            Debug.Assert(pcgMemory != null);
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
            return new ZeroSeriesFileReader(pcgMemory, content, ContentType, SysExStartOffset, SysExEndOffset);
        }

        /// <summary>
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        public override ISongMemory CreateSongMemory(string fileName)
        {
            ISongMemory songMemory = new ZeroSeriesSongMemory(fileName);
            return songMemory;
        }

        /// <summary>
        /// </summary>
        /// <param name="memory"></param>
        /// <param name="content"></param>
        /// <returns></returns>
        public override ISongFileReader CreateSongFileReader(ISongMemory memory, byte[] content)
        {
            return new ZeroSeriesSongFileReader(memory, content);
        }
    }
}