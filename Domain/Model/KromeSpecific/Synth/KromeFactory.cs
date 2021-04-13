// (c) Copyright 2011-2019 MiKeSoft, Michel Keijzers, All rights reserved

using Domain.Model.Common.File;
using Domain.Model.Common.Synth.MemoryAndFactory;
using Domain.Model.Common.Synth.SongsRelated;
using Domain.Model.KromeSpecific.Pcg;
using Domain.Model.KromeSpecific.Song;
using Domain.Model.MSpecific.Synth;

namespace Domain.Model.KromeSpecific.Synth
{
    public class KromeFactory : MFactory
    {
        public override IPcgMemory CreatePcgMemory(string fileName)
        {
            PcgMemory pcgMemory = new KromePcgMemory(fileName);
            pcgMemory.Fill();
            return pcgMemory;
        }

        public override IPatchesFileReader CreateFileReader(IPcgMemory pcgMemory, byte[] content)
        {
            return new KromePcgFileReader(pcgMemory, content);
        }

        public override ISongMemory CreateSongMemory(string fileName)
        {
            SongMemory songMemory = new KromeSongMemory(fileName);
            return songMemory;
        }

        public override ISongFileReader CreateSongFileReader(ISongMemory memory, byte[] content)
        {
            return new KromeSongFileReader(memory, content);
        }
    }
}
