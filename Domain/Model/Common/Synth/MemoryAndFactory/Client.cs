// (c) Copyright 2011-2019 MiKeSoft, Michel Keijzers, All rights reserved

using Domain.Model.Common.Synth.SongsRelated;

namespace Domain.Model.Common.Synth.MemoryAndFactory
{
    /// <summary>
    /// From abstract factory design pattern.
    /// </summary>
    public class Client
    {
        /// <summary>
        /// 
        /// </summary>
        readonly IPcgMemory _pcgMemory;


        /// <summary>
        /// 
        /// </summary>
        readonly ISongMemory _songMemory;


        /// <summary>
        /// 
        /// </summary>
        /// <param name="factory"></param>
        /// <param name="fileName"></param>
        public Client(IFactory factory, string fileName)
        {
            _pcgMemory = factory.CreatePcgMemory(fileName);
            _songMemory = factory.CreateSongMemory(fileName);
        }


        /// <summary>
        /// 
        /// </summary>
        public IPcgMemory PcgMemory => _pcgMemory;


        /// <summary>
        /// 
        /// </summary>
        public ISongMemory SongMemory => _songMemory;
    }
}
