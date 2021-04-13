// (c) Copyright 2011-2019 MiKeSoft, Michel Keijzers, All rights reserved

using System;
using Domain.Model.Common;
using Domain.Model.Common.File;
using Domain.Model.Common.Synth.MemoryAndFactory;
using Domain.Model.Common.Synth.Meta;
using Domain.Model.Common.Synth.PatchInterfaces;
using Domain.Model.Common.Synth.PatchPrograms;

namespace Domain.Model.Ms2000Specific.Pcg
{
    /// <summary>
    /// 
    /// </summary>
    public class Ms2000FileReader : SysExFileReader
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="currentPcgMemory"></param>
        /// <param name="content"></param>
        /// <param name="contentType"></param>
        /// <param name="sysExStartOffset"></param>
        /// <param name="sysExEndOffset"></param>
        public Ms2000FileReader(
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
            switch (filetype)
            {
                case MemoryFileType.Lib:
                    ReadLibData();
                    break;

                case MemoryFileType.MkP0:
                    ReadMkP0Data();
                    break;

                case MemoryFileType.Bnk: // Fall through
                case MemoryFileType.Exl: // Fall through
                case MemoryFileType.Syx: // Fall through
                case MemoryFileType.Mid: 
                    var memory = (SysExMemory) CurrentPcgMemory;

                    memory.Convert7To8Bits();

                    switch (ContentType)
                    {
                        case PcgMemoryContentType.CurrentProgram:
                            ReadSingleProgram(SysExStartOffset);
                            memory.SynchronizeProgramName();
                            break;

                        case PcgMemoryContentType.All:
                            ReadAllData();
                            break;

                        case PcgMemoryContentType.AllPrograms:
                            ReadAllData();
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
        /// 
        /// </summary>
        /// <param name="offset"></param>
        private void ReadSingleProgram(int offset)
        {
            var bank = (IProgramBank) (CurrentPcgMemory.ProgramBanks[0]);
            bank.ByteOffset = 0;
            bank.BankSynthesisType = ProgramBankSynthesisType.AnalogModeling;
            bank.ByteLength = 254;
            bank.IsWritable = true;
            bank.IsLoaded = true;

            var program = (Program) bank[0];
            program.ByteOffset = offset;
            program.ByteLength = bank.ByteLength;
            program.IsLoaded = true;
        }


        /// <summary>
        /// 
        /// </summary>
        private void ReadAllData()
        {
            Index = SysExStartOffset;

            var programBank = (IProgramBank) CurrentPcgMemory.ProgramBanks[0];

            const int numberOfProgramsInBank = 16;
            for (var bankIndex = 0; bankIndex < CurrentPcgMemory.ProgramBanks.BankCollection.Count; bankIndex++)
            {
                var bank = (IProgramBank) (CurrentPcgMemory.ProgramBanks[bankIndex]);
                bank.ByteOffset = Index;
                bank.BankSynthesisType = ProgramBankSynthesisType.AnalogModeling;
                bank.ByteLength = 254;
                bank.IsWritable = true;
                bank.IsLoaded = true;

                for (var index = 0; index < numberOfProgramsInBank; index++)
                {
                    // Place in PcgMemory.
                    var program = (Program) bank[index];
                    program.ByteOffset = Index;
                    program.ByteLength = programBank.ByteLength;
                    program.IsLoaded = true;

                    // Skip to next.
                    Index += bank.ByteLength;
                }

                if (Index + bank.ByteLength >= CurrentPcgMemory.Content.Length)
                {
                    break;
                }
            }
        }


        /// <summary>
        /// 
        /// </summary>
        private void ReadMkP0Data()
        {
            var content = CurrentPcgMemory.Content;

            if ((Util.GetInt(content, 0x4, 4) != 0) ||
                (Util.GetInt(content, 0x8, 4) != 0x8414) || // Length
                (Util.GetChars(content, 0x10, 4) != "mkP0"))
            {
                throw new NotSupportedException("Unsupported mkP0 chunk");
            }

            Index = 0x120;

            var programBank = (IProgramBank) CurrentPcgMemory.ProgramBanks[0];

            const int numberOfProgramsInBank = 16;

            var patchSize = Util.GetInt(content, Index, 8);

            for (var bankIndex = 0; bankIndex < CurrentPcgMemory.ProgramBanks.BankCollection.Count; bankIndex++)
            {
                if (ReadMkp0Bank(content, patchSize, bankIndex, numberOfProgramsInBank, programBank))
                {
                    break;
                }
            }
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="content"></param>
        /// <param name="patchSize"></param>
        /// <param name="bankIndex"></param>
        /// <param name="numberOfProgramsInBank"></param>
        /// <param name="programBank"></param>
        /// <returns></returns>
        private bool ReadMkp0Bank(byte[] content, int patchSize, int bankIndex, int numberOfProgramsInBank,
            ILocatable programBank)
        {
            if (Util.GetInt(content, Index, 8) != patchSize)
            {
                throw new ApplicationException("Illegal length");
            }

            var bank = (IProgramBank) (CurrentPcgMemory.ProgramBanks[bankIndex]);
            bank.ByteOffset = Index;
            bank.BankSynthesisType = ProgramBankSynthesisType.AnalogModeling;
            bank.ByteLength = patchSize;
            bank.IsWritable = true;
            bank.IsLoaded = true;

            for (var index = 0; index < numberOfProgramsInBank; index++)
            {
                Index += 8; // Skip patch size

                // Place in PcgMemory.
                var program = (Program) bank[index];
                program.ByteOffset = Index;
                program.ByteLength = programBank.ByteLength;
                program.IsLoaded = true;

                // Skip to next.
                Index += bank.ByteLength;
            }

            if (Index + bank.ByteLength >= CurrentPcgMemory.Content.Length)
            {
                return true;
            }
            return false;
        }


        /// <summary>
        /// myoldpatches.LIB (MS2000?) 
        /// 0000 (   4)  MROF 
        /// 0004 (   4)  Size in IBM Format
        /// 0008 (   4)  BLSS
        /// 000C (   4)  RDHL
        /// 001E (   4)  Size in IBM Format (3A)
        /// ..   (  3A)
        /// 004E (   4)  QESW
        /// 0052 (   4)  Size in IBM Format (8C)
        /// b.. 8C
        /// 00E2 (   4)  TNEL (Global info)
        /// 00E6 (   4)  Size in IBM Format (EB)
        /// .. EB
        /// 01D5 (   4)  TNEL
        /// 01D9 (   4)  Size in IBM Format (114, later also 116, 113, ...)
        /// ..
        /// 02F1 (   4)  TNEL...
        /// offset (program name) starts from 14 (decimal) after size of TNEL
        /// Bank Name+ID contained in patch (at end), can be ignored
        /// 
        /// ???: Square Comp
        /// A01: AC/DC 1987
        /// A02: SynthARPEG
        /// ...
        /// A16: Surrounded
        /// B01: Lazy Pitch
        /// ...
        /// H16: INIT Program
        /// </summary>
        private void ReadLibData()
        {
            var content = CurrentPcgMemory.Content;
            Index = 4; // Skip MROF
            var mrofSize = ReadLength(); // Ignore MROF chunk size.

            if (Util.GetChars(content, Index, 4) != "BLSS")
            {
                throw new NotSupportedException("Unsupported BLSSRDHL chunk");
            }
            Index += 4;

            var bankIndex = 0;
            var bank = (IProgramBank) CurrentPcgMemory.ProgramBanks[bankIndex];
            bank.ByteOffset = Index;
            bank.ByteLength = 0xFE;
            bank.BankSynthesisType = ProgramBankSynthesisType.AnalogModeling;

            var programIndex = 0;
            const int numberOfProgramsInBank = 16;
            var skip = 1;
            var createBank = false;
            while (Index < mrofSize)
            {
                // Only handle TNEL chunks, containing one program each.
                var chunkName = Util.GetChars(content, Index, 4);
                Index += 4;
                var chunkLength = ReadLength();

                // Chunk length of 0xEB is global, some unknown is 0x28, others seem to be 0x112 - 0x118.
                if ((chunkName == "TNEL") && (chunkLength >= 0x100))
                {
                    if (createBank)
                    {
                        bank = CreateProgramBank(bankIndex);
                        programIndex = 0;
                        createBank = false;
                    }

                    if (skip > 0)
                    {
                        skip--;
                    }
                    else
                    {
                        programIndex = PlaceInPcgMemory(bank, programIndex);

                        if (programIndex >= numberOfProgramsInBank)
                        {
                            bankIndex++;
                            createBank = true;
                        }
                    }
                }

                Index += chunkLength;
            }
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="bank"></param>
        /// <param name="programIndex"></param>
        /// <returns></returns>
        private int PlaceInPcgMemory(IBank bank, int programIndex)
        {
            var program = (IProgram) (bank[programIndex]);
            program.ByteOffset = Index + 0x0E; // Program starts after 0x0E bytes from start of chunk
            program.ByteLength = bank.ByteLength;
            program.IsLoaded = true;

            programIndex++;
            return programIndex;
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="bankIndex"></param>
        /// <returns></returns>
        private IProgramBank CreateProgramBank(int bankIndex)
        {
            var bank = (IProgramBank) CurrentPcgMemory.ProgramBanks[bankIndex];
            bank.ByteOffset = Index;
            bank.ByteLength = 0xFE;
            bank.BankSynthesisType = ProgramBankSynthesisType.AnalogModeling;
            bank.IsWritable = true;
            bank.IsLoaded = true;

            return bank;
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