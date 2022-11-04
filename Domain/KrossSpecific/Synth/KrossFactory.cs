#region copyright

// (c) Copyright 2011-2022 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

using Domain.Common;
using Domain.Common.File;
using Domain.Common.Synth.MemoryAndFactory;
using Domain.Common.Synth.SongsRelated;
using Domain.KrossSpecific.Pcg;
using Domain.KrossSpecific.Song;
using Domain.MSpecific.Synth;

namespace Domain.KrossSpecific.Synth
{
    /// <summary>
    /// </summary>
    public class KrossFactory : MFactory
    {
        /// <summary>
        /// </summary>
        private readonly PcgMemory.ContentType _contentType;


        /// <summary>
        /// </summary>
        /// <param name="contentType"></param>
        public KrossFactory(PcgMemory.ContentType contentType)
        {
            _contentType = contentType;
        }


        /// <summary>
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        public override IPcgMemory CreatePcgMemory(string fileName)
        {
            PcgMemory pcgMemory = new KrossPcgMemory(fileName);
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
            PatchesFileReader reader;
            if (Util.GetChars(content, 0, 2) == "tr")
            {
                reader = new KrossTrFileReader(pcgMemory, content, _contentType);
            }
            else
            {
                reader = new KrossPcgFileReader(pcgMemory, content);
            }

            return reader;
        }


        /// <summary>
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        public override ISongMemory CreateSongMemory(string fileName)
        {
            SongMemory songMemory = new KrossSongMemory(fileName);
            return songMemory;
        }


        /// <summary>
        /// </summary>
        /// <param name="memory"></param>
        /// <param name="content"></param>
        /// <returns></returns>
        public override ISongFileReader CreateSongFileReader(ISongMemory memory, byte[] content)
        {
            return new KrossSongFileReader(memory, content);
        }
    }
}