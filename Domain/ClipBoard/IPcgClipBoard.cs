// (c) Copyright 2011-2019 MiKeSoft, Michel Keijzers, All rights reserved

using System.Collections.Generic;
using System.Collections.ObjectModel;
using Domain.Model.Common.Synth.MemoryAndFactory;
using Domain.Model.Common.Synth.Meta;
using Domain.Model.Common.Synth.PatchCombis;
using Domain.Model.Common.Synth.PatchDrumKits;
using Domain.Model.Common.Synth.PatchDrumPatterns;
using Domain.Model.Common.Synth.PatchPrograms;
using Domain.Model.Common.Synth.PatchSetLists;
using Domain.Model.Common.Synth.PatchWaveSequences;

namespace Domain.ClipBoard
{
    /// <summary>
    /// 
    /// </summary>
    public interface IPcgClipBoard
    {
        /// <summary>
        /// 
        /// </summary>
        void Clear();


        /// <summary>
        /// 
        /// </summary>
        bool CutPasteSelected { get; set; }


        /// <summary>
        /// 
        /// </summary>
        string CopyFileName { get; set; }


        /// <summary>
        /// 
        /// </summary>
        IModel Model { get; set; }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="program"></param>
        /// <param name="clearAfterCopy"></param>
        /// <returns></returns>
        IClipBoardProgram CopyProgramToClipBoard(IProgram program, bool clearAfterCopy);


        /// <summary>
        /// 
        /// </summary>
        /// <param name="combi"></param>
        /// <param name="clearAfterCopy"></param>
        /// <returns></returns>
        IClipBoardCombi CopyCombiToClipBoard(ICombi combi, bool clearAfterCopy);


        /// <summary>
        /// 
        /// </summary>
        /// <param name="setListSlot"></param>
        /// <param name="clearAfterCopy"></param>
        void CopySetListSlotToClipBoard(ISetListSlot setListSlot, bool clearAfterCopy);


        /// <summary>
        /// 
        /// </summary>
        /// <param name="drumKit"></param>
        /// <param name="clearAfterCopy"></param>
        /// <returns></returns>
        IClipBoardDrumKit CopyDrumKitToClipBoard(IDrumKit drumKit, bool clearAfterCopy);


        /// <summary>
        /// 
        /// </summary>
        /// <param name="drumPattern"></param>
        /// <param name="clearAfterCopy"></param>
        /// <returns></returns>
        IClipBoardDrumPattern CopyDrumPatternToClipBoard(IDrumPattern drumPattern, bool clearAfterCopy);


        /// <summary>
        /// 
        /// </summary>
        /// <param name="waveSequence"></param>
        /// <param name="clearAfterCopy"></param>
        void CopyWaveSequenceToClipBoard(IWaveSequence waveSequence, bool clearAfterCopy);


        /// <summary>
        /// 
        /// </summary>
        void Memorize();


        /// <summary>
        /// 
        /// </summary>
        bool PasteDuplicatesExecuted { get; set; }


        /// <summary>
        /// 
        /// </summary>
        void FixPasteReferencesAfterCopyPaste();


        /// <summary>
        /// 
        /// </summary>
        bool IsPastingFinished { get; }


        /// <summary>
        /// 
        /// </summary>
        List<IClipBoardPatches> Programs { get; }
        

        /// <summary>
        /// 
        /// </summary>
        IClipBoardPatches Combis { get; }


        /// <summary>
        /// 
        /// </summary>
        IClipBoardPatches SetListSlots { get; }


        /// <summary>
        /// 
        /// </summary>
        IClipBoardPatches DrumKits { get; }


        /// <summary>
        /// 
        /// </summary>
        IClipBoardPatches DrumPatterns { get; }


        /// <summary>
        /// 
        /// </summary>
        IClipBoardPatches WaveSequences { get; }
        

        /// <summary>
        /// 
        /// </summary>
        ClipBoardCopyType SelectedCopyType { get; }


        /// <summary>
        /// 
        /// </summary>
        ObservableCollection<IPatch> ProtectedPatches { get; }


        /// <summary>
        /// 
        /// </summary>
        IPcgMemory PastePcgMemory { get;  }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="patches"></param>
        /// <returns></returns>
        IClipBoardPatch GetFirstPatchToPaste(IEnumerable<IClipBoardPatch> patches);


        /// <summary>
        /// 
        /// </summary>
        /// <param name="patchToPaste"></param>
        /// <param name="patch"></param>
        void PastePatch(IClipBoardPatch patchToPaste, IPatch patch);
    }
}
