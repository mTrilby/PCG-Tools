using System;
using System.Linq;
using Domain.Model.Common.File;
using Domain.Model.Common.Synth.MemoryAndFactory;
using Domain.Model.Common.Synth.Meta;
using Domain.Model.Common.Synth.PatchCombis;
using Domain.Model.Common.Synth.PatchDrumKits;
using Domain.Model.Common.Synth.PatchPrograms;

namespace Domain.Model.KrossSpecific.Pcg
{
    /// <summary>
    /// 
    /// </summary>
    public class KrossTrFileReader : PatchesFileReader
    {
        /// <summary>
        /// 
        /// </summary>
        private readonly PcgMemoryContentType _contentType;


        /// <summary>
        /// 
        /// </summary>
        private int _bank;


        /// <summary>
        /// 
        /// </summary>
        private int _patchIndex;


        /// <summary>
        /// 
        /// </summary>
        /// <param name="currentPcgMemory"></param>
        /// <param name="content"></param>
        /// <param name="contentType"></param>
        public KrossTrFileReader(IPcgMemory currentPcgMemory, byte[] content, 
            PcgMemoryContentType contentType)
            : base(currentPcgMemory, content)
        {
            _contentType = contentType;
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="filetype"></param>
        /// <param name="modelType"></param>
        public override void ReadContent(MemoryFileType filetype, ModelsEModelType modelType)
            // Continue parsing.
        {
            var memory = (KrossPcgMemory) CurrentPcgMemory;

            const int headerSize = 32; // bytes
            switch (_contentType)
            {
                case PcgMemoryContentType.All:
                {
                    ReadAllCombis(memory, 0x20);
                    ReadAllPrograms(memory, 0xf7a20);
                    ReadAllDrumKits(memory, 0x246020);
                }
                    break;

                case PcgMemoryContentType.CurrentProgram:
                    ReadSingleProgram(headerSize); // Is starting index
                    memory.SynchronizeProgramName();
                    break;

                case PcgMemoryContentType.ProgramBank:
                {
                    var firstBank = (ProgramBank) (memory.ProgramBanks[0]);
                    var offset = headerSize;
                    foreach (var program in firstBank.Patches)
                    {
                        ReadSingleProgram(offset);
                        offset += firstBank.PatchSize;
                    }
                }
                    break;
                    
                case PcgMemoryContentType.AllPrograms:
                    ReadAllPrograms(memory, headerSize);
                    break;

                case PcgMemoryContentType.CurrentCombi:
                    ReadSingleCombi(headerSize); // Is starting index
                    memory.SynchronizeCombiName();
                    break;

                case PcgMemoryContentType.CombiBank:
                {
                    var firstBank = memory.CombiBanks[0];
                    var offset = headerSize;
                    foreach (var combi in firstBank.Patches)
                    {
                        ReadSingleCombi(offset);
                        offset += firstBank.ByteLength;
                    }
                }
                    break;

                case PcgMemoryContentType.AllCombis:
                    ReadAllCombis(memory, headerSize);
                    break;
                    
                case PcgMemoryContentType.AllDrumSound:
                case PcgMemoryContentType.Drums:
                case PcgMemoryContentType.ArpeggioPattern:
                case PcgMemoryContentType.CurrentArpeggioPattern:
                case PcgMemoryContentType.MultiSound:
                case PcgMemoryContentType.Global:
                case PcgMemoryContentType.AllSequence:
                case PcgMemoryContentType.CurrentSequence:
                    // Do not read anything.
                    break;

                default:
                    throw new NotSupportedException("Unsupported SysEx function");
            }

            // Read global.
            if (_contentType == PcgMemoryContentType.All)
            {
                memory.Global.ByteOffset = 0x338680 - 334; // 334 bytes before categories start.
            }
            else
            {
                memory.Global = null;
            }
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="memory"></param>
        /// <param name="offset"></param>
        private void ReadAllPrograms(IPcgMemory memory, int offset)
        {
            _bank = 0;
            _patchIndex = 0;

            foreach (var bank in memory.ProgramBanks.BankCollection.Where(
                                     bank => bank.Type != BankTypeEType.Gm))
            {
                ReadSingleProgram(offset);
                offset += bank.ByteLength;
            }
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="memory"></param>
        /// <param name="offset"></param>
        private void ReadAllCombis(IPcgMemory memory, int offset)
        {
            _bank = 0;
            _patchIndex = 0;

            foreach (var bank in memory.CombiBanks.BankCollection)
            {
                ReadSingleCombi(offset);
                offset += bank.ByteLength;
            }
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="memory"></param>
        /// <param name="offset"></param>
        private void ReadAllDrumKits(IPcgMemory memory, int offset)
        {
            _bank = 0;
            _patchIndex = 0;

            const int drumKitsInAllFile = 48; // Only this many drum kits in a .KRSall file.

            var drumKits = 0;
            foreach (var bank in memory.DrumKitBanks.BankCollection)
            {
                ReadSingleDrumKit(offset);
                offset += bank.ByteLength;
                
                // Stop at max. number of drum kits.
                drumKits++;
                if (drumKits >= drumKitsInAllFile)
                {
                    break;
                }
            }
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="offset"></param>
        private void ReadSingleProgram(int offset)
        {
            var bank = (IProgramBank) (CurrentPcgMemory.ProgramBanks[_bank]);
            bank.ByteOffset = 0;
            bank.BankSynthesisType = ProgramBankSynthesisType.Edsx;
            bank.ByteLength = 0x85c;
            bank.IsWritable = true;
            bank.IsLoaded = true;

            var program = (IProgram) bank[_patchIndex];
            program.ByteOffset = offset;
            program.ByteLength = bank.ByteLength;
            program.IsLoaded = true;
            
            IncreaseProgram();
        }


        /// <summary>
        /// 
        /// </summary>
        private void IncreaseProgram()
        {
            // Go to next program.
            _patchIndex++;
            if (_patchIndex >= CurrentPcgMemory.ProgramBanks[_bank].Patches.Count)
            {
                _bank++;
                _patchIndex = 0;
            }
        }


        private void ReadSingleCombi(int offset)
        {
            var bank = (ICombiBank)(CurrentPcgMemory.CombiBanks[_bank]);
            bank.ByteOffset = 0;
            bank.ByteLength = 0x7bc;
            bank.IsWritable = true;
            bank.IsLoaded = true;

            var combi = (ICombi)bank[_patchIndex];
            combi.ByteOffset = offset;
            combi.ByteLength = bank.ByteLength;
            combi.IsLoaded = true;
            
            IncreaseCombi();
        }


        /// <summary>
        /// 
        /// </summary>
        private void IncreaseCombi()
        {
            // Go to next combi.
            _patchIndex++;
            if (_patchIndex >= CurrentPcgMemory.CombiBanks[_bank].Patches.Count)
            {
                _bank++;
                _patchIndex = 0;
            }
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="offset"></param>
        private void ReadSingleDrumKit(int offset)
        {
            var bank = (DrumKitBank)(CurrentPcgMemory.DrumKitBanks[_bank]);
            bank.ByteOffset = 0;
            bank.PatchSize = 0x2218;
            bank.IsWritable = true;
            bank.IsLoaded = true;

            var drumKit = (DrumKit)bank[_patchIndex];
            drumKit.ByteOffset = offset;
            drumKit.ByteLength = bank.PatchSize;
            drumKit.IsLoaded = true;
            
            IncreaseDrumKit();
        }


        /// <summary>
        /// 
        /// </summary>
        private void IncreaseDrumKit()
        {
            // Go to next drumKit.
            _patchIndex++;
            if (_patchIndex >= ((DrumKitBank)(CurrentPcgMemory.DrumKitBanks[_bank])).Patches.Count)
            {
                _bank++;
                _patchIndex = 0;
            }
        }
    }
}