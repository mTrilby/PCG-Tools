#region copyright

// (c) Copyright 2011-2023 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

#region using

using Domain.Common.File;
using Domain.Common.Synth.MemoryAndFactory;
using Domain.Common.Synth.SongsRelated;
using Domain.KromeSpecific.Pcg;
using Domain.KromeSpecific.Song;
using Domain.MSpecific.Synth;

#endregion

namespace Domain.KromeSpecific.Synth
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