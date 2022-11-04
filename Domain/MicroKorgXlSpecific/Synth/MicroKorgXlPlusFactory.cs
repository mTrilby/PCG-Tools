#region copyright

// (c) Copyright 2011-2022 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

using System;
using Domain.Common.File;
using Domain.Common.Synth.MemoryAndFactory;
using Domain.Common.Synth.SongsRelated;
using Domain.MicroKorgXlSpecific.Pcg;
using Domain.MicroKorgXlSpecific.Song;
using Domain.MSpecific.Synth;

namespace Domain.MicroKorgXlSpecific.Synth
{
    /// <summary>
    /// </summary>
    public class MicroKorgXlPlusFactory : MFactory
    {
        /// <summary>
        /// </summary>
        private readonly Memory.FileType _fileType;


        /// <summary>
        /// </summary>
        /// <param name="fileType"></param>
        public MicroKorgXlPlusFactory(Memory.FileType fileType)
        {
            _fileType = fileType;
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
                case Memory.FileType.MkxlPAll:
                    pcgMemory = new MicroKorgXlMkxlPAllMemory(fileName);
                    break;

                case Memory.FileType.MkxlPProg:
                    pcgMemory = new MicroKorgXlMkxlPProgMemory(fileName);
                    break;

                default:
                    throw new NotSupportedException("Unsupported memory type");
            }

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
            IPatchesFileReader reader = null;

            switch (_fileType)
            {
                case Memory.FileType.MkxlPAll:
                    reader = new MicroKorgXlMkxlPAllFileReader(pcgMemory, content);
                    break;

                case Memory.FileType.MkxlPProg:
                    reader = new MicroKorgXlMkxlPProgFileReader(pcgMemory, content);
                    break;

                default:
                    throw new NotSupportedException("Unsupported reader");
            }

            return reader;
        }


        /// <summary>
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        public override ISongMemory CreateSongMemory(string fileName)
        {
            SongMemory songMemory = new MicroKorgXlSongMemory(fileName);
            return songMemory;
        }


        /// <summary>
        /// </summary>
        /// <param name="memory"></param>
        /// <param name="content"></param>
        /// <returns></returns>
        public override ISongFileReader CreateSongFileReader(ISongMemory memory, byte[] content)
        {
            return new MicroKorgXlSongFileReader(memory, content);
        }
    }
}