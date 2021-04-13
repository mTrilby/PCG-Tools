// (c) Copyright 2011-2019 MiKeSoft, Michel Keijzers, All rights reserved

using System;
using Domain.Model.Common;
using Domain.Model.Common.File;
using Domain.Model.Common.Synth.MemoryAndFactory;
using Domain.Model.Common.Synth.PatchCombis;
using Domain.Model.Common.Synth.PatchPrograms;

namespace Domain.Model.M1Specific.Pcg
{
    //
    public class M1FileReader : SysExFileReader
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="currentPcgMemory"></param>
        /// <param name="content"></param>
        /// <param name="contentType"></param>
        /// <param name="sysExStartOffset"></param>
        /// <param name="sysExEndOffset"></param>
        public M1FileReader(
            IPcgMemory currentPcgMemory, byte[] content, PcgMemoryContentType contentType,
            int sysExStartOffset, int sysExEndOffset)
            : base(currentPcgMemory, content, contentType, sysExStartOffset, sysExEndOffset)
        {
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="filetype"></param>
        /// <param name="modelType"></param>
        public override void ReadContent(MemoryFileType filetype, ModelsEModelType modelType)
        {
            var memory = SkipModeChange(filetype);

            // Continue parsing.
            switch (filetype)
            {
                case MemoryFileType.Syx: // Fall through
                case MemoryFileType.Mid: 
                    memory.Convert7To8Bits();
                    
                    switch (ContentType)
                    {
                        case PcgMemoryContentType.CurrentProgram:
                            ReadSingleProgram(SysExStartOffset);
                            memory.SynchronizeProgramName();
                            break;

                        case PcgMemoryContentType.CurrentCombi:
                            ReadSingleCombi(SysExStartOffset);
                            memory.SynchronizeCombiName();
                            break;

                        case PcgMemoryContentType.All:
                        case PcgMemoryContentType.AllCombis:
                        case PcgMemoryContentType.AllPrograms:
                            ReadAllData();
                            break;

                        case PcgMemoryContentType.Global:
                        case PcgMemoryContentType.AllSequence:
                            // Do not read anything.
                            break;
                        
                        default:
                            throw new NotSupportedException("Unsupported SysEx function");
                    }
                    break;

                default:
                    throw new NotSupportedException("Unsupported file type");
            }
        }


        /// <summary>
        /// Skip Mode Change (not for Sysex Manager file and OrigKorg file).
        /// </summary>
        /// <param name="filetype"></param>
        /// <returns></returns>
        private SysExMemory SkipModeChange(MemoryFileType filetype)
        {
            var memory = (SysExMemory) CurrentPcgMemory;
            switch (filetype)
            {
                case MemoryFileType.Syx:
                    if ((Util.GetChars(memory.Content, 0, 14) != "Sysex Manager-") &&
                        (Util.GetChars(memory.Content, 2, 8) != "OrigKorg"))
                    {
                        var offset = SkipModeChanges();
                        SysExStartOffset += offset;
                        ContentType = (PcgMemoryContentType) memory.Content[offset + 4];
                    }
                    break;

                case MemoryFileType.Mid:
                    break;

                    //default: // Do nothing
            }
            return memory;
        }


        /// <summary>
        /// Skip mode changes.
        /// Also adapts the contentType.
        /// </summary>
        int SkipModeChanges()
        {
            var offset = 0;
            var memory = (SysExMemory)CurrentPcgMemory;

            while ((memory.Content[offset] == 0xF0) && // MIDI SysEx
                   (memory.Content[offset + 1] == 0x42) && // Korg
                   (memory.Content[offset + 4] == (int) PcgMemoryContentType.ModeChange))
            {
                offset += 8;
            }
            memory.SysExStartOffset += offset;
            return offset;
        }

        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="offset"></param>
        private void ReadSingleProgram(int offset)
        {
            var bank = (ProgramBank) (CurrentPcgMemory.ProgramBanks[0]);
            bank.ByteOffset = 0;
            bank.BankSynthesisType = ProgramBankSynthesisType.AnalogModeling;
            bank.PatchSize = 143;
            bank.IsWritable = true;
            bank.IsLoaded = true;

            var program = (Program) bank[0];
            program.ByteOffset = offset;
            program.ByteLength = bank.PatchSize;
            program.IsLoaded = true;
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="offset"></param>
        private void ReadSingleCombi(int offset)
        {
            var bank = (CombiBank)(CurrentPcgMemory.CombiBanks[0]);
            bank.ByteOffset = 0;
            bank.PatchSize = 124;
            bank.IsWritable = true;
            bank.IsLoaded = true;

            var combi = (Combi)bank[0];
            combi.ByteOffset = offset;
            combi.ByteLength = bank.PatchSize;
            combi.IsLoaded = true;
        }


        /// <summary>
        /// 
        /// </summary>
        private void ReadAllData()
        {
            Index = SysExStartOffset;
            var nrOfPatches = Util.GetBits(CurrentPcgMemory.Content, Index - 3, 1, 1) > 0 ? 50 : 100;
            var bankIndex = Util.GetBits(CurrentPcgMemory.Content, Index - 3, 0, 0); // Internal: 0, Card: 1

            // Read global data.
            CurrentPcgMemory.Global.ByteOffset = Index;

            if (ContentType == PcgMemoryContentType.All)
            {
                // Skip global.
                Index += 861;
            }

            ReadAllCombis(bankIndex, nrOfPatches);
            ReadAllPrograms(bankIndex, nrOfPatches);
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="bankIndex"></param>
        /// <param name="nrOfPatches"></param>
        private void ReadAllCombis(int bankIndex, int nrOfPatches)
        {
            if ((ContentType == PcgMemoryContentType.All) ||
                (ContentType == PcgMemoryContentType.AllCombis))
            {
                // Read combi data.
                var bank = (CombiBank) (CurrentPcgMemory.CombiBanks[bankIndex]);
                bank.ByteOffset = Index;
                bank.PatchSize = 124;
                bank.IsWritable = true;
                bank.IsLoaded = true;

                for (var index = 0; index < nrOfPatches; index++)
                {
                    // Place in PcgMemory.
                    var combi = (Combi) bank[index];
                    combi.ByteOffset = Index;
                    combi.ByteLength = bank.PatchSize;
                    combi.IsLoaded = true;

                    // Skip to next.
                    Index += bank.PatchSize;
                }

                // When virtual banks are used, here needs to be checked to stop reading combi banks.
            }
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="bankIndex"></param>
        /// <param name="nrOfPatches"></param>
        private void ReadAllPrograms(int bankIndex, int nrOfPatches)
        {
            if ((ContentType == PcgMemoryContentType.All) ||
                (ContentType == PcgMemoryContentType.AllPrograms))
            {
                // Read program data.

                var bank = (ProgramBank) (CurrentPcgMemory.ProgramBanks[bankIndex]);
                bank.ByteOffset = Index;

                bank.BankSynthesisType = ProgramBankSynthesisType.Ai;
                bank.PatchSize = 143;
                bank.IsWritable = true;
                bank.IsLoaded = true;

                for (var index = 0; index < nrOfPatches; index++)
                {
                    // Place in PcgMemory.
                    var program = (Program) bank[index];
                    program.ByteOffset = Index;
                    program.ByteLength = bank.PatchSize;
                    program.IsLoaded = true;

                    // Skip to next.
                    Index += bank.PatchSize;
                }
            }
        }


        /// <summary>
        /// Read length (of a chunk) where all four bytes are swapped: LSB .. .. MSB.
        /// </summary>
        /// <returns></returns>
        private int ReadLength()
        {
            var content = CurrentPcgMemory.Content;
            var value = Util.GetInt(content, Index + 3, 1)*256*256*256 +
                        Util.GetInt(content, Index + 2, 1) * 256 * 256 +
                        Util.GetInt(content, Index + 1, 1) * 256 +
                        Util.GetInt(content, Index + 0, 1);
            Index += 4;
            return value;
        }
    }
}