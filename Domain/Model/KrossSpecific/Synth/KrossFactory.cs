// (c) Copyright 2011-2019 MiKeSoft, Michel Keijzers, All rights reserved

using Domain.Model.Common;
using Domain.Model.Common.File;
using Domain.Model.Common.Synth.MemoryAndFactory;
using Domain.Model.Common.Synth.SongsRelated;
using Domain.Model.KrossSpecific.Pcg;
using Domain.Model.KrossSpecific.Song;
using Domain.Model.MSpecific.Synth;

namespace Domain.Model.KrossSpecific.Synth
{
    /// <summary>
    /// 
    /// </summary>
    public class KrossFactory : MFactory
    {
        /// <summary>
        /// 
        /// </summary>
        private readonly PcgMemoryContentType _contentType;


        /// <summary>
        /// 
        /// </summary>
        /// <param name="contentType"></param>
        public KrossFactory(PcgMemoryContentType contentType)
        {
            _contentType = contentType;
        }


        /// <summary>
        /// 
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
        /// 
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
        /// 
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        public override ISongMemory CreateSongMemory(string fileName)
        {
            SongMemory songMemory = new KrossSongMemory(fileName);
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
            return new KrossSongFileReader(memory, content);
        }
    }
}
