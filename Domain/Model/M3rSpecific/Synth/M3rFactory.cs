// (c) Copyright 2011-2019 MiKeSoft, Michel Keijzers, All rights reserved

using System;
using System.Diagnostics;
using Domain.Model.Common.File;
using Domain.Model.Common.Synth.MemoryAndFactory;
using Domain.Model.Common.Synth.SongsRelated;
using Domain.Model.M3rSpecific.Pcg;
using Domain.Model.M3rSpecific.Song;
using Domain.Model.MntxSeriesSpecific.Synth;

namespace Domain.Model.M3rSpecific.Synth
{
    /// <summary>
    /// 
    /// </summary>
    public class M3RFactory : MntxFactory
    {
        /// <summary>
        /// 
        /// </summary>
        readonly MemoryFileType _fileType ;

        
        /// <summary>
        /// 
        /// </summary>
        private readonly PcgMemoryContentType _contentType;


        /// <summary>
        /// 
        /// </summary>
        private readonly int _sysExStartOffset;


        /// <summary>
        /// 
        /// </summary>
        private readonly int _sysExEndOffset;


        /// <summary>
        /// 
        /// </summary>
        /// <param name="fileType"></param>
        /// <param name="contentType"></param>
        /// <param name="sysExStartOffset"></param>
        /// <param name="sysExEndOffset"></param>
        public M3RFactory(MemoryFileType fileType, PcgMemoryContentType contentType,
            int sysExStartOffset, int sysExEndOffset)
        {
            _fileType = fileType;
            _contentType = contentType;
            _sysExStartOffset = sysExStartOffset;
            _sysExEndOffset = sysExEndOffset;
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        public override IPcgMemory CreatePcgMemory(string fileName)
        {
            IPcgMemory pcgMemory = null;

            switch (_fileType)
            {
                case MemoryFileType.Syx: // Fall through
                case MemoryFileType.Mid:
                    pcgMemory = new M3RSysExMemory(fileName, _contentType, _sysExStartOffset, _sysExEndOffset);
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
            return new M3RFileReader(pcgMemory, content, _contentType, _sysExStartOffset, _sysExEndOffset);
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        public override ISongMemory CreateSongMemory(string fileName)
        {
            SongMemory songMemory = new M3RSongMemory(fileName);
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
            return new M3RSongFileReader(memory, content);
        }
    }
}