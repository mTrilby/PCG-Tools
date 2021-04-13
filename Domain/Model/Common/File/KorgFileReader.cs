// (c) Copyright 2011-2019 MiKeSoft, Michel Keijzers, All rights reserved

using System;
using System.Linq;
using Domain.Model.Common.Synth.MemoryAndFactory;
using Domain.Model.Common.Synth.Meta;
using Domain.Model.KromeExSpecific.Synth;
using Domain.Model.KromeSpecific.Synth;
using Domain.Model.KronosSpecific.Synth;
using Domain.Model.Kross2Specific.Synth;
using Domain.Model.KrossSpecific.Synth;
using Domain.Model.M1Specific.Synth;
using Domain.Model.M3rSpecific.Synth;
using Domain.Model.M3Specific.Synth;
using Domain.Model.M50Specific.Synth;
using Domain.Model.MicroKorgXlSpecific.Synth;
using Domain.Model.MicroStationSpecific.Synth;
using Domain.Model.Ms2000Specific.Synth;
using Domain.Model.OasysSpecific.Synth;
using Domain.Model.TrinitySpecific.Synth;
using Domain.Model.TritonExtremeSpecific.Synth;
using Domain.Model.TritonKarmaSpecific.Synth;
using Domain.Model.TritonLeSpecific.Synth;
using Domain.Model.TritonTrClassicStudioRackSpecific.Synth;
using Domain.Model.TSeries.Synth;
using Domain.Model.XSeries.Synth;
using Domain.Model.Z1Specific.Synth;
using Domain.Model.Zero3Rw.Synth;
using Domain.Model.ZeroSeries.Synth;

namespace Domain.Model.Common.File
{
    /// <summary>
    /// 
    /// </summary>
    public class KorgFileReader
    {
        /// <summary>
        /// 
        /// </summary>
        private byte[] Content { get; set; }


        /// <summary>
        /// 
        /// </summary>
        public ModelsEModelType ModelType { get; private set; }


        /// <summary>
        /// 
        /// </summary>
        public MemoryFileType FileType { get; private set; }


        /// <summary>
        /// 
        /// </summary>
        private PcgMemoryContentType ContentType { get; set; }


        /// <summary>
        /// 
        /// </summary>
        private int SysExStartOffset { get; set; }


        /// <summary>
        /// 
        /// </summary>
        private int SysExEndOffset { get; set; }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        public IMemory Read(string fileName)
        {
            ReadFile(fileName);

            IMemory memory = null;
            if (Content != null)
            {
                var factory = Factory;

                memory = ReadContent(fileName, factory);
            }

            return memory;
        }


        /// <summary>
        /// 
        /// </summary>
        private Factory Factory
        {
            get
            {
                Factory factory;
                switch (ModelType)
                {
                    case ModelsEModelType.Kronos:
                        factory = new KronosFactory();
                        break;

                    case ModelsEModelType.Oasys:
                        factory = new OasysFactory();
                        break;

                    case ModelsEModelType.M1:
                        factory = new M1Factory(FileType, ContentType, SysExStartOffset, SysExEndOffset);
                        break;

                    case ModelsEModelType.M3:
                        factory = new M3Factory();
                        break;

                    case ModelsEModelType.M3R:
                        factory = new M3RFactory(FileType, ContentType, SysExStartOffset, SysExEndOffset);
                        break;

                    case ModelsEModelType.M50:
                        factory = new M50Factory();
                        break;

                    case ModelsEModelType.Ms2000:
                        factory = new Ms2000Factory(FileType, ContentType, SysExStartOffset, SysExEndOffset);
                        break;

                    case ModelsEModelType.MicroKorgXl:
                        factory = new MicroKorgXlFactory();
                        break;

                    case ModelsEModelType.MicroKorgXlPlus:
                        factory = new MicroKorgXlPlusFactory(FileType);
                        break;

                    case ModelsEModelType.MicroStation:
                        factory = new MicroStationFactory();
                        break;

                    case ModelsEModelType.Krome:
                        factory = new KromeFactory();
                        break;

                    case ModelsEModelType.KromeEx:
                        factory = new KromeExFactory();
                        break;

                    case ModelsEModelType.Kross:
                        factory = new KrossFactory(ContentType);
                        break;

                    case ModelsEModelType.Kross2:
                        factory = new Kross2Factory(ContentType);
                        break;

                    case ModelsEModelType.Trinity:
                        factory = new TrinityFactory();
                        break;

                    case ModelsEModelType.TritonExtreme:
                        factory = new TritonExtremeFactory();
                        break;

                    case ModelsEModelType.TritonTrClassicStudioRack:
                        factory = new TritonTrClassicStudioRackFactory();
                        break;

                    case ModelsEModelType.TritonLe:
                        factory = new TritonLeFactory();
                        break;

                    case ModelsEModelType.TritonKarma:
                        factory = new TritonKarmaFactory();
                        break;

                    case ModelsEModelType.TSeries:
                        factory = new TSeriesFactory(FileType, ContentType, SysExStartOffset, SysExEndOffset);
                        break;

                    case ModelsEModelType.XSeries:
                        factory = new XSeriesFactory(FileType, ContentType, SysExStartOffset, SysExEndOffset);
                        break;

                    case ModelsEModelType.Z1:
                        factory = new Z1Factory(FileType, ContentType, SysExStartOffset, SysExEndOffset);
                        break;

                    case ModelsEModelType.ZeroSeries:
                        factory = new ZeroSeriesFactory(FileType, ContentType, SysExStartOffset, SysExEndOffset);
                        break;

                    case ModelsEModelType.Zero3Rw:
                        factory = new Zero3RwFactory(FileType, ContentType, SysExStartOffset, SysExEndOffset);
                        break;

                    default:
                        throw new NotSupportedException("Unsupported Korg ModelType");
                }
                return factory;
            }
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="fileName"></param>
        /// <param name="factory"></param>
        /// <returns></returns>
        private IMemory ReadContent(string fileName, IFactory factory)
        {
            var memory = ReadFileContent(fileName, factory);
            RemoveExcessivePatches(memory);
            SetParameters(memory);

            return memory;
        }

        

         
        /// <summary>
        /// 
        /// </summary>
        /// <param name="fileName"></param>
        /// <param name="factory"></param>
        /// <returns></returns>
        private IMemory ReadFileContent(string fileName, IFactory factory)
        {
            IMemory memory;
            switch (FileType)
            {
                case MemoryFileType.Pcg:
                    memory = ReadPcgContent(fileName, factory);
                    break;

                case MemoryFileType.Raw: // Fall through
                case MemoryFileType.Bnk: // Fall through
                case MemoryFileType.Exl: // Fall through
                case MemoryFileType.Lib: // Fall through
                case MemoryFileType.Mid: // Fall through
                case MemoryFileType.MkP0: // Fall through
                case MemoryFileType.MkxlAll: // Fall through
                case MemoryFileType.MkxlPAll: // Fall through
                case MemoryFileType.MkxlPProg: // Fall through
                case MemoryFileType.Syx: // Fall through
                case MemoryFileType.Tr:
                    memory = ReadSysexLikeContent(fileName, factory);
                    break;

                case MemoryFileType.Sng:
                    memory = ReadSngContent(fileName, factory);
                    break;

                default:
                    throw new NotSupportedException("Unsupported Korg MemoryFileType");
            }

            return memory;
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="fileName"></param>
        /// <param name="factory"></param>
        /// <returns></returns>
        private IMemory ReadSysexLikeContent(string fileName, IFactory factory)
        {
            var client = new Client(factory, fileName);
            var fileReader = factory.CreateFileReader(client.PcgMemory, Content);
            fileReader.ReadContent(FileType, ModelType);

            return client.PcgMemory;
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="fileName"></param>
        /// <param name="factory"></param>
        /// <returns></returns>
        private IMemory ReadSngContent(string fileName, IFactory factory)
        {
            IMemory memory = null;
            var client = new Client(factory, fileName);
            var sngFileReader = factory.CreateSongFileReader(client.SongMemory, Content);
            if (sngFileReader != null)
            {
                sngFileReader.ReadChunks();
                memory = client.SongMemory;
            }
            return memory;
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="fileName"></param>
        /// <param name="factory"></param>
        /// <returns></returns>
        private IMemory ReadPcgContent(string fileName, IFactory factory)
        {
            var client = new Client(factory, fileName);
            var fileReader = factory.CreateFileReader(client.PcgMemory, Content);
            fileReader.ReadContent(FileType, ModelType);

            // If global is not read, set it to null.
            if ((client.PcgMemory.Global != null) && (client.PcgMemory.Global.ByteOffset == 0))
            {
                client.PcgMemory.Global = null;
            }

            return client.PcgMemory;
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="memory"></param>
        private void RemoveExcessivePatches(IMemory memory)
        {
            if (memory != null)
            {
                memory.MemoryFileType = FileType;

                var pcgMemory = memory as PcgMemory;
                if (pcgMemory != null)
                {
                    RemoveExcessivePatches(pcgMemory);
                }
            }
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="memory"></param>
        private static void SetParameters(IMemory memory)
        {
            if (memory != null)
            {
                var pcgMemory = memory as PcgMemory;
                if (pcgMemory != null)
                {
                    pcgMemory.SetParameters();
                }
            }
        }


        /// <summary>
        /// Remove all programs and combis which are not part of the PCG file OR not from a GM or virtual bank.
        /// Only remove it for banks which contains at least one patch (to prevent problems with combi/program relations/ references).
        /// </summary>
        private static void RemoveExcessivePatches(IPcgMemory memory)
        {
            RemoveExcessivePrograms(memory);
            RemoveExcessiveCombis(memory);
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="memory"></param>
        private static void RemoveExcessivePrograms(IPcgMemory memory)
        {
            if (memory.ProgramBanks != null)
            {
                foreach (var bank in memory.ProgramBanks.BankCollection.Where(
                    bank =>
                        (bank.Type != BankTypeEType.Gm) &&
                        (bank.Type != BankTypeEType.Virtual) &&
                        (bank.CountWritablePatches > 0)))
                {
                    for (var patchIndex = bank.Patches.Count - 1; patchIndex >= 0; patchIndex--)
                    {
                        if (!bank[patchIndex].IsLoaded)
                        {
                            bank.Patches.Remove(bank[patchIndex]);
                        }
                    }
                }
            }
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="memory"></param>
        private static void RemoveExcessiveCombis(IPcgMemory memory)
        {
            if (memory.CombiBanks != null)
            {
                foreach (var bank in memory.CombiBanks.BankCollection.Where(bank => (
                    bank.Type != BankTypeEType.Virtual &&
                    bank.CountWritablePatches > 0)))
                {
                    for (var patchIndex = bank.Patches.Count - 1; patchIndex >= 0; patchIndex--)
                    {
                        if (!bank[patchIndex].IsLoaded)
                        {
                            bank.Patches.Remove(bank[patchIndex]);
                        }
                    }
                }
            }
        }


        /// <summary>
        /// Bytes:   0   1   2   3      4          5      6     7    8
        ///         "K" "O" "R" "G" ProductId  MemoryFileType Major Minor Product
        ///                                                         SubId
        ///                            19                                       M1/M1EX/M1R/M1R-EX
        ///                            24                                       M3R
        ///                            3B                                       Trinity
        ///                            46                                       Z1
        ///                            50                            00         Triton / Triton Studio
        ///                            50                                       Triton TR Rack
        ///                            50                            01         Triton Extreme
        ///                            58                                       MS2000
        ///                            5D                                       Karma
        ///                            63                                       Triton LE
        ///                            68                                       Kronos
        ///                            70                                       Oasys
        ///                            75       0x00     0x02 0x00              M3 pcm_version checksum_flag, see x4100pcg.txt
        ///                            7A                                       X50/microX
        ///                            85                                       M50
        ///                            8D                                       microSTATION
        ///                            95                                       Krome
        ///                            96                                       Kross
        ///                            C9                                       Kross2
        ///                            D2                                       Krome Ex                            
        /// 
        /// MemoryFileType: 00 = PCG 01=SNG 02=EXL
        /// </summary>
        private void ReadFile(string fileName)
        {
            ReadAllBytes(fileName);

            switch ((char) Content[0])
            {
                case (char) 0x00:
                    ReadFileStartingWith00();
                    break;

                case '6':
                    ReadMkxlFile();
                    break;

                case 'm':
                    ReadMkP0File();
                    break;

                case 'F':
                    ReadBnkFile();
                    break;

                case 'K':
                    ReadFileStartingWithK();
                    break;

                case 'M':
                    ReadFileStartingWithM();
                    break;

                case 'S':
                    ReadFileStartingWithS();
                    break;

                case 't': // 'tr file from Kross
                    ReadFileStartingWith_t();
                    break;

                case (char) 0xF0:
                    ReadSysExFile();
                    break;
                     
                default:
                    throw new NotSupportedException("Unsupported format");
            }
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="fileName"></param>
        private void ReadAllBytes(string fileName)
        {
            try
            {
                Content = System.IO.File.ReadAllBytes(fileName);
            }
            catch (Exception exception)
            {
                throw new ApplicationException("File cannot be read " + exception.InnerException);
            }
        }


        /// <summary>
        /// 
        /// </summary>
        private void ReadFileStartingWith_t()
        {
            if (Util.GetChars(Content, 0, 2) == "tr")
            {
                ReadTrFile();
            }
            else
            {
                throw new NotSupportedException("Unsupported format");
            }
        }


        /// <summary>
        /// 
        /// </summary>
        private void ReadFileStartingWithS()
        {
            if (Util.GetChars(Content, 0, 14) == "Sysex Manager-")
            {
                ReadSysexManagerFile();
            }
            else
            {
                throw new NotSupportedException("Unsupported format");
            }
        }


        /// <summary>
        /// 
        /// </summary>
        private void ReadFileStartingWithM()
        {
            switch ((char) Content[1])
            {
                case 'T':
                    ReadMidiFile();
                    break;

                case 'R':
                    ReadLibFile();
                    break;

                default:
                    throw new NotSupportedException("Unsupported format");
            }
        }


        /// <summary>
        /// 
        /// </summary>
        private void ReadFileStartingWithK()
        {
            if ((Util.GetChars(Content, 1, 3) == "ORG") && (Content[4] == ';') &&
                (Util.GetInt(Content, 5, 2) == 2))
            {
                ReadExlFile();
            }
            else
            {
                ReadPcgFile();
            }
        }


        /// <summary>
        /// 
        /// </summary>
        private void ReadFileStartingWith00()
        {
            if (Util.GetChars(Content, 2, 8) == "OrigKorg")
            {
                ReadOrigKorgFile();
            }
            else if (Util.GetInt(Content, 0, 4) == 0x42)
            {
                ReadRawDiskImageFile();
            }
            else
            {
                throw new ApplicationException("Invalid file");
            }
        }


        /// <summary>
        /// 
        /// </summary>
        private void ReadBnkFile()
        {
            var index = 0;
            if (Util.GetChars(Content, index, 4) != "FORM")
            {
                throw new NotSupportedException("Unsupported format");
            }

            index += 12; // Skip FORM and chunk size (complete file) and 'BANK'.

            while (true)
            {
                var chunkName = Util.GetChars(Content, index, 4);
                if (chunkName == "BODY")
                {
                    index += 8; // Skip BODY and chunk size
                    break;
                }

                index += 4 + Util.GetInt(Content, index + 4, 4) + 4; // two times 4, for chunk name + length
            }

            ModelType = ModelsEModelType.Ms2000;

            SysExStartOffset = index + 5; // Skip Korg ID etc.
            ContentType = (PcgMemoryContentType)Content[index + 4];
            SysExEndOffset = Content.Length - 2;

            FileType = MemoryFileType.Bnk;
        }


        /// <summary>
        /// 
        /// </summary>
        private void ReadPcgFile()
        {
            if (Util.GetChars(Content, 0, 4) != "KORG")
            {
                throw new NotSupportedException("Unsupported format");
            }

            GetModelType();
            GetFileType();
        }


        /// <summary>
        /// 
        /// </summary>
        private void GetModelType()
        {
            switch (Content[0x4]) // # ModelType
            {
                case 0x3B:
                    ModelType = ModelsEModelType.Trinity;
                    break;

                case 0x50:
                    GetModelTypeOf50();
                    break;

                case 0x5D:
                    ModelType = ModelsEModelType.TritonKarma;
                    break;

                case 0x63:
                    ModelType = ModelsEModelType.TritonLe;
                    break;

                case 0x68:
                    ModelType = ModelsEModelType.Kronos;
                    break;

                case 0x70:
                    ModelType = ModelsEModelType.Oasys;
                    break;

                case 0x75:
                    ModelType = ModelsEModelType.M3;
                    break;

                case 0x85:
                    ModelType = ModelsEModelType.M50;
                    break;

                case 0x8D:
                    ModelType = ModelsEModelType.MicroStation;
                    break;

                case 0x95:
                    ModelType = ModelsEModelType.Krome;
                    break;

                case 0x96:
                    ModelType = ModelsEModelType.Kross;
                    break;

                case 0xC9:
                    ModelType = ModelsEModelType.Kross2;
                    break;

                case 0xD2:
                    ModelType = ModelsEModelType.KromeEx;
                    break;

                default:
                    throw new NotSupportedException("Unsupported Korg ModelAndVersionAsString");
            }
        }


        /// <summary>
        /// 
        /// </summary>
        private void GetModelTypeOf50()
        {
            switch (Content[0x8])
            {
                case 0x00: // Triton / Triton Rack / Triton Studio
                    ModelType = ModelsEModelType.TritonTrClassicStudioRack;
                    break;

                case 0x01: // Triton Extreme
                    ModelType = ModelsEModelType.TritonExtreme;
                    break;

                default:
                    throw new NotSupportedException("Unsupported Korg Triton ModelAndVersionAsString");
            }
        }


        /// <summary>
        /// 
        /// </summary>
        private void GetFileType()
        {
            switch (Content[0x5]) // # MemoryFileType
            {
                case 0x00:
                    FileType = MemoryFileType.Pcg;
                    break;

                case 0x01:
                    FileType = MemoryFileType.Sng;
                    break;

                default:
                    throw new NotSupportedException("Unknown file type.");
            }
        }


        /// <summary>
        /// Reads OrigKorg file (see: M1: ORIGPROG.syx).
        /// </summary>
        private void ReadOrigKorgFile()
        {
            if (Util.GetChars(Content, 11, 2) == "M1")
            {
                ModelType = ModelsEModelType.M1;
            }
            else
            {
                throw new NotSupportedException("Unsupported OrigKorg file");
            }

            ContentType = (PcgMemoryContentType)Content[0x84]; // Fixed
            SysExStartOffset = 0x86; // Fixed
            SysExEndOffset = Content.Length - 1;
            FileType = MemoryFileType.Syx;
        }
        

        /// <summary>
        /// Read Sysex Manager file (see Korg M1 file: Haupt-Bank_B.syx).
        /// </summary>
        private void ReadSysexManagerFile()
        {
            if (Util.GetChars(Content, 14, 2) == "M1")
            {
                ModelType = ModelsEModelType.M1;
            }
            else
            {
                throw new NotSupportedException("Unsupported Sysex Manager file");
            }

            ContentType = (PcgMemoryContentType)Content[0x7c]; // Fixed
            SysExStartOffset = 0x7e; // Fixed
            SysExEndOffset = Content.Length - 1;
            FileType = MemoryFileType.Syx;
        }


        /// <summary>
        /// Read Kross TR (editor) file. Use Sysexfunction also.
        /// </summary>
        private void ReadTrFile()
        {
            ModelType = ModelsEModelType.Kross;
            FileType = MemoryFileType.Tr;

            switch (Util.GetChars(Content, 0, 4))
            {
                    // Add cases with spaces later, because these are stripped from GetChars.

                case "tra":
                    ContentType = PcgMemoryContentType.All;
                    break;

                case "trpb":
                    ContentType = PcgMemoryContentType.ProgramBank;
                    break;

                case "trpa":
                    ContentType = PcgMemoryContentType.AllPrograms;
                    break;

                case "trp":
                    ContentType = PcgMemoryContentType.CurrentProgram; // 1 program
                    break;

                case "trcb":
                    ContentType = PcgMemoryContentType.CombiBank;
                    break;

                case "trca":
                    ContentType = PcgMemoryContentType.AllCombis;
                    break;

                case "trc":
                    ContentType = PcgMemoryContentType.CurrentCombi; // 1 combi
                    break;

                case "trma":
                    ContentType = PcgMemoryContentType.AllSequence;
                    break;

                case "trm":
                    ContentType = PcgMemoryContentType.CurrentSequence; // Not read
                    break;

                default:
                    throw new NotSupportedException("Unsupported file");
            }
        }


        /// <summary>
        /// Read 01/W disk image file.
        /// </summary>
        private void ReadRawDiskImageFile()
        {
            if (Util.GetInt(Content, 4, 1) == 0x2B)
            {
                ModelType = ModelsEModelType.ZeroSeries;
            }
            else
            {
                throw new NotSupportedException("Unsupported RAW disk image file");
            }

            FileType = MemoryFileType.Raw;
        }


        /// <summary>
        /// Reads MIDI files (MThd chunk). 
        /// See https://hostr.co/download/LJUEw0K/midiformat.pdf for more info.
        /// 
        /// Read MS2000 format.
        /// </summary>
        private void ReadMidiFile()
        {
            if ((Util.GetChars(Content, 0, 4) != "MThd") ||
                (Util.GetInt(Content, 4, 4) != 6)) // Length: always 6, see website link above
                //(Util.GetInt(Content, 8, 2) != 0)) // Format: 0=Single Multi Track Channel, 
                //         1=One or more simultanious tracks of a sequence
                //         2=One or more sequentially independant single-track patterns
                //(Util.GetInt(Content, 10, 2) != 1)) // Number of tracks, for Format 0 always 1
                // bytes 12/13: Division: bit15=0: b14..0  =ticks per quarter note, 
                //                        bit15=1: bit14..8=negative SMPTE format, bit7..0=ticks per frame
            {
                throw new NotSupportedException("Unsupported MIDI format");
            }

            var index = 14;
            do
            {
                index = ReadMidiFileContent(index);
            } while (Content[SysExEndOffset + 1] != 0xF7);

            FileType = MemoryFileType.Mid;
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        private int ReadMidiFileContent(int index)
        {
            if (Util.GetChars(Content, index, 4) != "MTrk")
            {
                throw new NotSupportedException("Unsupported MThd MIDI chunk");
            }

            index += 4;

            // MS2000 data of MTrk chunk is:
            // MTRK Offset  : 00 01 02 03 04 05    06 07 08      09           10     11
            // Data         : 00 00 01 30 00 F0    82 28 42      30           58     40 ...
            // Meaning      : <-Length--> ?? SysEx ?? ?? Korg ID MIDI Channel MS2000 CurrentProgram

            var trackLength = Util.GetInt(Content, index, 4); // Track length, not used
            index += 4;

            var length = 0;
            if (trackLength < 0x100) // Just some random number lower than a patch size
            {
                index += trackLength;
            }
            else
            {
                index = GotoNextMidiContent(index, ref length);

                ReadMidiContentBytes(index, length);

                ContentType = (PcgMemoryContentType) Content[index + 3];
            }
            return index;
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="index"></param>
        /// <param name="length"></param>
        private void ReadMidiContentBytes(int index, int length)
        {
            ContentType = (PcgMemoryContentType)Content[index + 3];

            switch (Content[index + 2])
            {
                case 0x19:
                    ReadM1MidiContent(index, length);
                    break;

                case 0x24:
                    ModelType = ModelsEModelType.M3R;
                    SysExStartOffset = index + 5; // Skip Korg header + 1 byte: Bank (Internal or Card)
                    SysExEndOffset = index + length - 2;
                    break;

                case 0x26:
                    ReadTSeriesMidiContent(index);
                    break;

                case 0x2B:
                    ReadZeroSeriesMidiContent(index);
                    break;

                case 0x30:
                    ModelType = ModelsEModelType.Zero3Rw;
                    SysExStartOffset = index + 5; // Skip Korg header + 1 00-byte
                    SysExEndOffset = WalkUntilJustBeforeLastF7(Content.Length - 16);
                    break;

                case 0x35:
                    ReadXSeriesMidiContent(index);
                    break;

                case 0x46:
                    ReadZ1MidiContent(index, length);
                    break;

                case 0x58:
                    ModelType = ModelsEModelType.Ms2000;
                    SysExStartOffset = index + 4; // Skip Korg header
                    SysExEndOffset = index + length - 2;
                    break;

                default:
                    throw new NotSupportedException("Illegal model");
            }
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="index"></param>
        /// <param name="length"></param>
        /// <returns></returns>
        private int GotoNextMidiContent(int index, ref int length)
        {
            SkipMetaMessages(ref index);

            ReadVariableLengthQuality(ref index); // Read delta time (unused return parameter)
            if (Content[index] == 0x90) // Unknown 
            {
                // Very dirty: Might be a T series chunk.
                index += 0x1F;
            }
            else
            {
                if ((Content[index] != 0xF0))
                {
                    throw new NotSupportedException("No sysex part found.");
                }

                // Assuming sysex follows.
                index++;
                length = ReadVariableLengthQuality(ref index); // Read delta time (unused return parameter)
                if ((Content[index] != 0x42)) // KORG ID)
                {
                    throw new NotSupportedException("Not a Korg sysex file");
                }
            }
            return index;
        }



        /// <summary>
        /// 
        /// </summary>
        /// <param name="index"></param>
        /// <param name="length"></param>
        private void ReadM1MidiContent(int index, int length)
        {
            ModelType = ModelsEModelType.M1;
            switch (ContentType)
            {
                case PcgMemoryContentType.AllCombis: // Fall through
                case PcgMemoryContentType.AllPrograms:
                    SysExStartOffset = index + 5; // Memory Allocation Bank: 1 byte
                    break;

                case PcgMemoryContentType.All:
                    SysExStartOffset = index + 7; // Memory Allocation Bank: 1 byte + Seq Data Size 2 bytes
                    break;

                    //default:
                    // Do nothing
                    //break;
            }

            // Skip Korg header + 2 bytes more for Memory Allocation Bank and Sequencer Data Size
            SysExEndOffset = index + length - 2;
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="index"></param>
        private void ReadTSeriesMidiContent(int index)
        {
            ModelType = ModelsEModelType.TSeries;
            SysExStartOffset = index + 4;

            switch (ContentType)
            {
                case PcgMemoryContentType.AllCombis: // Fall through
                case PcgMemoryContentType.AllPrograms:
                    break;

                case PcgMemoryContentType.All:
                    SysExStartOffset += 3; // Zero byte + Seq Data Size 2 bytes
                    break;

                    //default:
                    // Do nothing
                    //break;
            }

            SysExEndOffset = Content.Length - 18; // Unknown why (last F7 found)
        }



        /// <summary>
        /// 
        /// </summary>
        /// <param name="index"></param>
        private void ReadZeroSeriesMidiContent(int index)
        {
            ModelType = ModelsEModelType.ZeroSeries;
            SysExStartOffset = index + 5;

            switch (ContentType)
            {
                case PcgMemoryContentType.AllCombis: // Fall through
                case PcgMemoryContentType.AllPrograms:
                    break;

                case PcgMemoryContentType.All:
                    SysExStartOffset += 3; // Zero byte + Seq Data Size 2 bytes
                    break;

                    //default:
                    // Do nothing
                    //break;
            }

            SysExEndOffset = WalkUntilJustBeforeLastF7(Content.Length - 16);
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="index"></param>
        private void ReadXSeriesMidiContent(int index)
        {
            ModelType = ModelsEModelType.XSeries;
            SysExStartOffset = index + 4;

            switch (ContentType)
            {
                case PcgMemoryContentType.AllCombis: // Fall through
                case PcgMemoryContentType.AllPrograms:
                    break;

                case PcgMemoryContentType.All:
                    SysExStartOffset += 3; // Zero byte + Seq Data Size 2 bytes
                    break;

                    //default:
                    // Do nothing
                    //break;
            }

            SysExEndOffset = Content.Length - 18; // Unknown why (last F7 found)
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="index"></param>
        /// <param name="length"></param>
        private void ReadZ1MidiContent(int index, int length)
        {
            ModelType = ModelsEModelType.Z1;
            SysExStartOffset = index + 4; // Skip Korg header
            SysExEndOffset = index + length - 2;


            ContentType = (PcgMemoryContentType) Content[index + 3];
            switch (ContentType)
            {
                case PcgMemoryContentType.CurrentProgram: // Fall through
                case PcgMemoryContentType.CurrentCombi: // Multi
                    SysExStartOffset += 1; // 00 byte
                    break;

                case PcgMemoryContentType.AllPrograms: // Fall through
                case PcgMemoryContentType.AllCombis: // Multi
                    SysExStartOffset += 3;
                    // Unit, Program No. (Ignored when bank or all dump) and 0 byte
                    break;

                case PcgMemoryContentType.All: // Fall through
                    SysExStartOffset += 2; // 2 Extra 00-bytes
                    break;

                //default: No action needed
            }
        }


        /// <summary>
        /// Walks from the index to the byte before F7.
        /// Only use if it is uncertain what the end location of a MIDI / MTrk Chunk is.
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        private int WalkUntilJustBeforeLastF7(int index)
        {
            while (Content[index] != 0xF7)
            {
                index++;
                if (index >= Content.Length)
                {
                    throw new ApplicationException("No end of MIDI F7 code found");
                }
            }

            return index - 1; // Byte before F7.
        }


        /// <summary>
        /// Returns index after last meta message.
        /// </summary>
        /// <param name="index"></param>
        private void SkipMetaMessages(ref int index)
        {
            var continueParsing = true;

            while (continueParsing)
            {
                var savedOffset = index;
                ReadVariableLengthQuality(ref index); // Ignore return variable: delta time
                if (Content[index] == 0xFF)
                {
                    // Meta event, containing: FF <type> <length> <bytes>
                    index += 2;  // Ignore type (2 bytes)
                    var length = ReadVariableLengthQuality(ref index);
                    index += length;
                }
                else
                {
                    index = savedOffset;
                    continueParsing = false;
                }
            }
        }


        /// <summary>
        /// Reads MIDI variable length quality value.
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        private int ReadVariableLengthQuality(ref int index)
        {
            int length = Content[index];
            index++;

            if ((length & 0x80) > 0)
            {
                length &= 0x7f;
                do
                {
                    length = length << 7;
                    length += Content[index] & 0x7f;
                    index++;

                } while ((Content[index - 1] & 0x80) > 0);

            }

            return length;
        }


        /// <summary>
        /// Reads Syx file.
        /// Read MS2000 format.
        /// </summary>
        private void ReadSysExFile()
        {
            if (((Content[1] != 0x42) || // Korg ID
                ((Content[2] & 0xF0) != 0x30))) // MIDI Channel 3x
            {
                throw new NotSupportedException("Unsupported Syx format");
            }

            ReadSyxContent();

            SysExEndOffset = Content.Length - 1;

            // Sometimes a file ends with F7 0A instead of F7 only.
            if ((Content[SysExEndOffset] != 0xF7) &&
                ((Content[SysExEndOffset - 1] != 0xF7) && (Content[SysExEndOffset] != 0x0A)))
            {
                throw new ApplicationException("No end of SYSEX command found");
            }

            FileType = MemoryFileType.Syx;
        }


        /// <summary>
        /// 
        /// </summary>
        private void ReadSyxContent()
        {
            switch (Content[3])
            {
                case 0x19: // M1
                    ReadSyxM1Content();
                    break;

                case 0x24: // M3R
                    ReadSyxM3RContent();
                    break;

                case 0x26: // T Series
                    ReadSyxTSeriesContent();
                    break;

                case 0x2B: // 0 Series
                    ReadSyxZeroSeriesContent();
                    break;

                case 0x30: // 03R/W
                    ReadSyxZero3RwContent();
                    break;

                case 0x35: // X Series
                    ReadSyxXSeriesContent();
                    break;

                case 0x46: // Z1
                    ReadSyxZ1Content();
                    break;

                case 0x58: // MS2000 (compatible with microKorg)
                    ModelType = ModelsEModelType.Ms2000;
                    ContentType = (PcgMemoryContentType) Content[4]; // Fixed
                    SysExStartOffset = 5; // Fixed
                    break;

                default:
                    throw new NotSupportedException("Illegal workstation/model type");
            }
        }


        /// <summary>
        /// 
        /// </summary>
        private void ReadSyxM1Content()
        {
            ModelType = ModelsEModelType.M1;
            ContentType = (PcgMemoryContentType) Content[4]; // Fixed
            SysExStartOffset = 5;

            switch (ContentType)
            {
                case PcgMemoryContentType.AllCombis: // Fall through
                case PcgMemoryContentType.AllPrograms:
                    SysExStartOffset += 1; // Memory Allocation Bank: 1 byte
                    break;

                case PcgMemoryContentType.All:
                    SysExStartOffset += 3; // Memory Allocation Bank: 1 byte + Seq Data Size 2 bytes
                    break;

                    //default:
                    // Do nothing
                    //break;
            }
        }


        /// <summary>
        /// 
        /// </summary>
        private void ReadSyxM3RContent()
        {
            ModelType = ModelsEModelType.M3R;
            ContentType = (PcgMemoryContentType) Content[4]; // Fixed

            SysExStartOffset = 5;

            switch (ContentType)
            {
                case PcgMemoryContentType.All: // Fall through
                case PcgMemoryContentType.AllPrograms: // Fall through
                case PcgMemoryContentType.AllCombis:
                    SysExStartOffset += 1;
                    break;

                    // default: no action needed//default:
            }
        }


        /// <summary>
        /// 
        /// </summary>
        private void ReadSyxTSeriesContent()
        {
            ModelType = ModelsEModelType.TSeries;
            ContentType = (PcgMemoryContentType) Content[4]; // Fixed
            SysExStartOffset = 5;

            switch (ContentType)
            {
                case PcgMemoryContentType.AllCombis: // Fall through
                case PcgMemoryContentType.AllPrograms:
                    break;

                case PcgMemoryContentType.All:
                    SysExStartOffset += 3; // Zero byte + Seq Data Size 2 bytes
                    break;

                    //default:
                    // Do nothing
                    //break;
            }
        }

        
        /// <summary>
        /// 
        /// </summary>
        private void ReadSyxZeroSeriesContent()
        {
            ModelType = ModelsEModelType.ZeroSeries;
            ContentType = (PcgMemoryContentType) Content[4]; // Fixed
            SysExStartOffset = 5;

            switch (ContentType)
            {
                case PcgMemoryContentType.AllCombis: // Fall through
                case PcgMemoryContentType.AllPrograms:
                    break;

                case PcgMemoryContentType.All:
                    SysExStartOffset += 3; // Zero byte + Seq Data Size 2 bytes
                    break;

                    //default:
                    // Do nothing
                    //break;
            }
        }


        /// <summary>
        /// 
        /// </summary>
        private void ReadSyxZero3RwContent()
        {
            ModelType = ModelsEModelType.Zero3Rw;
            ContentType = (PcgMemoryContentType) Content[4]; // Fixed
            SysExStartOffset = 6; // Korg file header + 1 byte

            switch (ContentType)
            {
                case PcgMemoryContentType.AllCombis: // Fall through
                case PcgMemoryContentType.AllPrograms:
                    break;

                case PcgMemoryContentType.All:
                    break;

                    //default:
                    // Do nothing
                    //break;
            }
        }


        /// <summary>
        /// 
        /// </summary>
        private void ReadSyxXSeriesContent()
        {
            ModelType = ModelsEModelType.XSeries;
            ContentType = (PcgMemoryContentType) Content[4]; // Fixed
            SysExStartOffset = 5;

            switch (ContentType)
            {
                case PcgMemoryContentType.AllCombis: // Fall through
                case PcgMemoryContentType.AllPrograms:
                    break;

                case PcgMemoryContentType.All:
                    SysExStartOffset += 3; // Zero byte + Seq Data Size 2 bytes
                    break;

                    //default:
                    // Do nothing
                    //break;
            }
        }


        /// <summary>
        /// 
        /// </summary>
        private void ReadSyxZ1Content()
        {
            ModelType = ModelsEModelType.Z1;
            ContentType = (PcgMemoryContentType) Content[4]; // Fixed

            SysExStartOffset = 5; // Korg header

            switch (ContentType)
            {
                case PcgMemoryContentType.CurrentProgram: // Fall through
                case PcgMemoryContentType.CurrentCombi: // Multi
                    SysExStartOffset += 1; // 00 byte
                    break;

                case PcgMemoryContentType.AllPrograms: // Fall through
                case PcgMemoryContentType.AllCombis: // Multi
                    SysExStartOffset += 3; // Unit, Program No. (Ignored when bank or all dump) and 0 byte
                    break;

                case PcgMemoryContentType.All: // Fall through
                    SysExStartOffset += 2; // 2 Extra 00-bytes
                    break;

                    //default:
                    // Do nothing
                    //break;
            }
        }


        /// <summary>
        /// Reads EXL format (Korg MS2000). Looks like MIDI, but with KORG; as first bytes, 
        /// like a regular PCG file.
        /// </summary>
        private void ReadExlFile()
        {
            if ((Content[0x18] != 0xF0) &&
                (Content[0x19] != 0x42))
            {
                throw new NotSupportedException("Unsupported MIDI format");
            }

            switch (Content[0x1B])
            {
                case 0x58:
                    ModelType = ModelsEModelType.Ms2000;
                    break;

                default:
                    throw new NotSupportedException("Unsupported model");
            }

            ContentType = (PcgMemoryContentType) Content[0x1C];
            SysExStartOffset = 0x1D;
            SysExEndOffset = Content.Length - 2;

            if (Content[SysExEndOffset + 1] != 0xF7)
            {
                throw new ApplicationException("Illegal last character");
            }

            FileType = MemoryFileType.Exl;
        }


        /// <summary>
        /// Reads Mkxl files:
        /// 
        /// Header Sub      Content | Workstation Model File Type   Supported
        /// ------ -------- ------- + ----------------- ----------- ----------
        /// 614    0        AllD    | MicroKorg XL      mkxl_all    Yes
        /// 614    1        AllD    | MicroKorg XL Plus mkxlp_all   Yes
        /// 614    1        PrgD    | MicroKorg XL Plus mkxlp_prog  Yes
        /// 614    1        CmbD?   | MicroKorg XL Plus mkxlp_combi No
        /// 614    1        GlbD?   | MicroKorg XL Plus mkxlp_glob  No
        ///  </summary>
        void ReadMkxlFile()
        {
            if (Util.GetChars(Content, 1, 2) != "14")
            {
                throw new NotSupportedException("Unsupported format");
            }

            switch ((char)Content[3])
            {
                case '0':
                    if (Util.GetChars(Content, 4, 4) != "AllD")
                    {
                        throw new NotSupportedException("Unsupported format");
                    }

                    ModelType = ModelsEModelType.MicroKorgXl;
                    FileType = MemoryFileType.MkxlAll;
                    break;

                case '1':
                    ModelType = ModelsEModelType.MicroKorgXlPlus;

                    switch (Util.GetChars(Content, 4, 4))
                    {
                        case "AllD":
                            FileType = MemoryFileType.MkxlPAll;
                            break;

                        case "PrgD":
                            FileType = MemoryFileType.MkxlPProg;
                            break;

                        default:
                            throw new NotSupportedException("Unsupported format");
                    }
                    break;

                default:
                    throw new NotSupportedException("Unknown file type.");
            }
        }


        /// <summary>
        /// Reads a file, with no extension or syx extension, starting with "mkP0".
        /// For MS2000.
        /// </summary>
        private void ReadMkP0File()
        {
            if (Util.GetChars(Content, 0x0, 4) != "mkP0")
            {
                throw new NotSupportedException("Unsupported mkP0 format file");
            }

            ModelType = ModelsEModelType.Ms2000;
            FileType = MemoryFileType.MkP0;
        }


        /// <summary>
        /// Reads a file, with .LIB extension
        /// For MS2000.
        /// </summary>
        private void ReadLibFile()
        {
            if (Util.GetChars(Content, 0x0, 4) != "MROF")
            {
                throw new NotSupportedException("Unsupported .LIB format file");
            }

            ModelType = ModelsEModelType.Ms2000;
            FileType = MemoryFileType.Lib;
        }
    }
}
