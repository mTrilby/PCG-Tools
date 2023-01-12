#region copyright

// (c) Copyright 2011-2023 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

#region using

using System;
using System.Diagnostics;
using Domain.Common.File;
using Domain.Common.Synth.MemoryAndFactory;
using Domain.Common.Synth.SongsRelated;
using Domain.M1Specific.Pcg;
using Domain.M1Specific.Song;
using Domain.MntxSeriesSpecific.Synth;

#endregion

namespace Domain.M1Specific.Synth
{
    /// <summary>
    /// </summary>
    public class M1Factory : MntxFactory
    {
        /// <summary>
        /// </summary>
        private readonly PcgMemory.ContentType _contentType;

        /// <summary>
        /// </summary>
        private readonly Memory.FileType _fileType;

        /// <summary>
        /// </summary>
        private readonly int _sysExEndOffset;

        /// <summary>
        /// </summary>
        private readonly int _sysExStartOffset;

        /// <summary>
        /// </summary>
        /// <param name="fileType"></param>
        /// <param name="contentType"></param>
        /// <param name="sysExStartOffset"></param>
        /// <param name="sysExEndOffset"></param>
        public M1Factory(Memory.FileType fileType, PcgMemory.ContentType contentType,
            int sysExStartOffset, int sysExEndOffset)
        {
            _fileType = fileType;
            _contentType = contentType;
            _sysExStartOffset = sysExStartOffset;
            _sysExEndOffset = sysExEndOffset;
        }

        /// <summary>
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        public override IPcgMemory CreatePcgMemory(string fileName)
        {
            IPcgMemory pcgMemory;

            switch (_fileType)
            {
                case Memory.FileType.Syx: // Fall through
                case Memory.FileType.Mid:
                    pcgMemory = new M1SysExMemory(fileName, _contentType, _sysExStartOffset, _sysExEndOffset);
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
            return new M1FileReader(pcgMemory, content, _contentType, _sysExStartOffset, _sysExEndOffset);
        }

        /// <summary>
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        public override ISongMemory CreateSongMemory(string fileName)
        {
            SongMemory songMemory = new M1SongMemory(fileName);
            return songMemory;
        }

        /// <summary>
        /// </summary>
        /// <param name="memory"></param>
        /// <param name="content"></param>
        /// <returns></returns>
        public override ISongFileReader CreateSongFileReader(ISongMemory memory, byte[] content)
        {
            return new M1SongFileReader(memory, content);
        }
    }
}