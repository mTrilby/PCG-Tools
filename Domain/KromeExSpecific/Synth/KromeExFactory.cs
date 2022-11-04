#region copyright

// (c) Copyright 2011-2022 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

using Domain.Common.File;
using Domain.Common.Synth.MemoryAndFactory;
using Domain.Common.Synth.SongsRelated;
using Domain.KromeExSpecific.Pcg;
using Domain.KromeExSpecific.Song;
using Domain.MSpecific.Synth;

namespace Domain.KromeExSpecific.Synth
{
    public class KromeExFactory : MFactory
    {
        public override IPcgMemory CreatePcgMemory(string fileName)
        {
            PcgMemory pcgMemory = new KromeExPcgMemory(fileName);
            pcgMemory.Fill();
            return pcgMemory;
        }

        public override IPatchesFileReader CreateFileReader(IPcgMemory pcgMemory, byte[] content)
        {
            return new KromeExPcgFileReader(pcgMemory, content);
        }

        public override ISongMemory CreateSongMemory(string fileName)
        {
            SongMemory songMemory = new KromeExSongMemory(fileName);
            return songMemory;
        }

        public override ISongFileReader CreateSongFileReader(ISongMemory memory, byte[] content)
        {
            return new KromeExSongFileReader(memory, content);
        }
    }
}