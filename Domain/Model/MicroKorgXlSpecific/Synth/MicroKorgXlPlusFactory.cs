// (c) Copyright 2011-2019 MiKeSoft, Michel Keijzers, All rights reserved

using System;
using Domain.Model.Common.File;
using Domain.Model.Common.Synth.MemoryAndFactory;
using Domain.Model.Common.Synth.SongsRelated;
using Domain.Model.MicroKorgXlSpecific.Pcg;
using Domain.Model.MicroKorgXlSpecific.Song;
using Domain.Model.MSpecific.Synth;

namespace Domain.Model.MicroKorgXlSpecific.Synth
{
    /// <summary>
    /// 
    /// </summary>
    public class MicroKorgXlPlusFactory : MFactory
    {
        /// <summary>
        /// 
        /// </summary>
        private readonly MemoryFileType _fileType;


        /// <summary>
        /// 
        /// </summary>
        /// <param name="fileType"></param>
        public MicroKorgXlPlusFactory(MemoryFileType fileType) : base()
        {
            _fileType = fileType;
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        public override IPcgMemory CreatePcgMemory(string fileName)
        {
            IPcgMemory pcgMemory;

            switch (_fileType)
            {
                case MemoryFileType.MkxlPAll:
                    pcgMemory = new MicroKorgXlMkxlPAllMemory(fileName);
                    break;

                case MemoryFileType.MkxlPProg:
                    pcgMemory = new MicroKorgXlMkxlPProgMemory(fileName);
                    break;

                default:
                    throw new NotSupportedException("Unsupported memory type");
            }

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
            IPatchesFileReader reader = null;

            switch (_fileType)
            {
                case MemoryFileType.MkxlPAll:
                    reader = new MicroKorgXlMkxlPAllFileReader(pcgMemory, content);
                    break;

                case MemoryFileType.MkxlPProg:
                    reader = new MicroKorgXlMkxlPProgFileReader(pcgMemory, content);
                    break;

                default:
                    throw new NotSupportedException("Unsupported reader");
            }
            return reader;
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        public override ISongMemory CreateSongMemory(string fileName)
        {
            SongMemory songMemory = new MicroKorgXlSongMemory(fileName);
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
            return new MicroKorgXlSongFileReader(memory, content);
        }
    }
}
