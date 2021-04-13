// (c) Copyright 2011-2019 MiKeSoft, Michel Keijzers, All rights reserved

using System;
using System.Diagnostics;
using Domain.Model.Common.File;
using Domain.Model.Common.Synth.MemoryAndFactory;
using Domain.Model.Common.Synth.SongsRelated;
using Domain.Model.MntxSeriesSpecific.Synth;
using Domain.Model.ZeroSeries.Pcg;
using Domain.Model.ZeroSeries.Song;

namespace Domain.Model.ZeroSeries.Synth
{
    /// <summary>
    /// 
    /// </summary>
    public class ZeroSeriesFactory : MntxFactory
    {
        /// <summary>
        /// 
        /// </summary>
        protected MemoryFileType FileType { get; private set; }

        
        /// <summary>
        /// 
        /// </summary>
        protected PcgMemoryContentType ContentType { get; private set; }


        /// <summary>
        /// 
        /// </summary>
        protected int SysExStartOffset { get; private set; }


        /// <summary>
        /// 
        /// </summary>
        protected int SysExEndOffset { get; private set; }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="fileType"></param>
        /// <param name="contentType"></param>
        /// <param name="sysExStartOffset"></param>
        /// <param name="sysExEndOffset"></param>
        public ZeroSeriesFactory(MemoryFileType fileType, PcgMemoryContentType contentType,
            int sysExStartOffset, int sysExEndOffset)
        {
            FileType = fileType;
            ContentType = contentType;
            SysExStartOffset = sysExStartOffset;
            SysExEndOffset = sysExEndOffset;
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        public override IPcgMemory CreatePcgMemory(string fileName)
        {
            IPcgMemory pcgMemory;

            switch (FileType)
            {
                case MemoryFileType.Syx: // Fall through
                case MemoryFileType.Mid: // Fall through
                case MemoryFileType.Raw:
                    pcgMemory = new ZeroSeriesSysExMemory(fileName, ContentType, SysExStartOffset, SysExEndOffset, FileType ==
                        MemoryFileType.Raw);
                    break;
                    
                default:
                    throw new NotSupportedException("Unsupported file type");
            }

            Debug.Assert(pcgMemory != null);
            pcgMemory.Fill();
            return pcgMemory;
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="pcgMemory"></param>
        /// <param name="content"></param>
        /// <returns></returns>
        public override IPatchesFileReader CreateFileReader(IPcgMemory pcgMemory, byte[] content)
        {
            return new ZeroSeriesFileReader(pcgMemory, content, ContentType, SysExStartOffset, SysExEndOffset);
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        public override ISongMemory CreateSongMemory(string fileName)
        {
            ISongMemory songMemory = new ZeroSeriesSongMemory(fileName);
            return songMemory;
        }


        /// <summary>
        /// 
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
