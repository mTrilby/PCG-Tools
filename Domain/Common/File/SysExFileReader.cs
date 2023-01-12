﻿#region copyright

// (c) Copyright 2011-2023 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

#region using

using System.Diagnostics;
using Common.Utils;
using Domain.Common.Synth.MemoryAndFactory;
using Domain.Common.Synth.Meta;
using Domain.Common.Synth.PatchCombis;
using Domain.Common.Synth.PatchPrograms;

#endregion

namespace Domain.Common.File
{
    /// <summary>
    /// </summary>
    public abstract class SysExFileReader : PatchesFileReader
    {
        /// <summary>
        /// </summary>
        /// <param name="currentPcgMemory"></param>
        /// <param name="content"></param>
        /// <param name="contentType"></param>
        /// <param name="sysExStartOffset"></param>
        /// <param name="sysExEndOffset"></param>
        protected SysExFileReader(IPcgMemory currentPcgMemory, byte[] content,
            PcgMemory.ContentType contentType, int sysExStartOffset, int sysExEndOffset)
            : base(currentPcgMemory, content)
        {
            ContentType = contentType;
            SysExStartOffset = sysExStartOffset;
            SysExEndOffset = sysExEndOffset;
        }

        /// <summary>
        /// </summary>
        protected PcgMemory.ContentType ContentType { get; set; }

        /// <summary>
        /// </summary>
        protected int SysExStartOffset { get; set; }

        /// <summary>
        /// </summary>
        private int SysExEndOffset { [UsedImplicitly] get; }

        /// <summary>
        /// </summary>
        /// <param name="programPatchSize"></param>
        /// <param name="combiPatchSize"></param>
        /// <param name="globalSize"></param>
        /// <param name="startProgramBank"></param>
        /// <param name="startCombiBank"></param>
        protected void ReadAllData(int programPatchSize, int combiPatchSize, int globalSize,
            int startProgramBank = 0, int startCombiBank = 0)
        {
            Index = SysExStartOffset;

            // Read global data.
            CurrentPcgMemory.Global.ByteOffset = Index;

            if (ContentType == PcgMemory.ContentType.All)
            {
                // Skip global.
                Index += globalSize;
            }

            ReadCombis(combiPatchSize, startCombiBank);

            ReadPrograms(programPatchSize, startProgramBank);
        }

        /// <summary>
        /// </summary>
        /// <param name="combiPatchSize"></param>
        /// <param name="startCombiBank"></param>
        private void ReadCombis(int combiPatchSize, int startCombiBank)
        {
            if (ContentType == PcgMemory.ContentType.All ||
                ContentType == PcgMemory.ContentType.AllCombis)
            {
                // Read combi data.
                var combiBank = (CombiBank)CurrentPcgMemory.CombiBanks[0];

                for (var bankIndex = startCombiBank;
                     bankIndex < CurrentPcgMemory.CombiBanks.BankCollection.Count;
                     bankIndex++)
                {
                    var bank = (ICombiBank)CurrentPcgMemory.CombiBanks[bankIndex];
                    if (bank.Type != BankType.EType.Virtual)
                    {
                        bank.ByteOffset = Index;
                        bank.ByteLength = combiPatchSize;
                        bank.IsWritable = true;
                        bank.IsLoaded = true;

                        foreach (var combi in bank.Patches)
                        {
                            combi.ByteOffset = Index;
                            combi.ByteLength = combiBank.PatchSize;
                            combi.IsLoaded = true;

                            // Skip to next.
                            Index += bank.ByteLength;
                        }
                    }

                    // When virtual banks are used, here needs to be checked to stop reading combi banks.
                }
            }
        }

        /// <summary>
        /// </summary>
        /// <param name="programPatchSize"></param>
        /// <param name="startProgramBank"></param>
        private void ReadPrograms(int programPatchSize, int startProgramBank)
        {
            if (ContentType == PcgMemory.ContentType.All ||
                ContentType == PcgMemory.ContentType.AllPrograms)
            {
                // Read program data.
                for (var bankIndex = startProgramBank;
                     bankIndex < CurrentPcgMemory.ProgramBanks.BankCollection.Count;
                     bankIndex++)
                {
                    ReadProgram(programPatchSize, bankIndex);
                }
            }
        }

        /// <summary>
        /// </summary>
        /// <param name="programPatchSize"></param>
        /// <param name="bankIndex"></param>
        private void ReadProgram(int programPatchSize, int bankIndex)
        {
            var bank = (IProgramBank)CurrentPcgMemory.ProgramBanks[bankIndex];
            if (bank.Type != BankType.EType.Virtual && bank.Type != BankType.EType.Gm)
            {
                bank.ByteOffset = Index;
                bank.ByteLength = programPatchSize;
                bank.IsWritable = true;
                bank.IsLoaded = true;

                foreach (var program in bank.Patches)
                {
                    program.ByteOffset = Index;
                    Debug.Assert(program.ByteOffset > 0);
                    program.ByteLength = bank.ByteLength;
                    program.IsLoaded = true;

                    // Skip to next.
                    Index += bank.ByteLength;
                }
            }
        }
    }
}