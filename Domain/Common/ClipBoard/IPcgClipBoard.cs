#region copyright

// (c) Copyright 2011-2023 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

#region using

using System.Collections.Generic;
using System.Collections.ObjectModel;
using Domain.Common.Synth.MemoryAndFactory;
using Domain.Common.Synth.Meta;
using Domain.Common.Synth.PatchCombis;
using Domain.Common.Synth.PatchDrumKits;
using Domain.Common.Synth.PatchDrumPatterns;
using Domain.Common.Synth.PatchPrograms;
using Domain.Common.Synth.PatchSetLists;
using Domain.Common.Synth.PatchWaveSequences;

#endregion

namespace Domain.Common.ClipBoard
{
    /// <summary>
    /// </summary>
    public interface IPcgClipBoard
    {
        /// <summary>
        /// </summary>
        bool CutPasteSelected { get; set; }

        /// <summary>
        /// </summary>
        string CopyFileName { get; set; }

        /// <summary>
        /// </summary>
        IModel Model { get; set; }

        /// <summary>
        /// </summary>
        bool PasteDuplicatesExecuted { get; set; }

        /// <summary>
        /// </summary>
        bool IsPastingFinished { get; }

        /// <summary>
        /// </summary>
        List<IClipBoardPatches> Programs { get; }

        /// <summary>
        /// </summary>
        IClipBoardPatches Combis { get; }

        /// <summary>
        /// </summary>
        IClipBoardPatches SetListSlots { get; }

        /// <summary>
        /// </summary>
        IClipBoardPatches DrumKits { get; }

        /// <summary>
        /// </summary>
        IClipBoardPatches DrumPatterns { get; }

        /// <summary>
        /// </summary>
        IClipBoardPatches WaveSequences { get; }

        /// <summary>
        /// </summary>
        PcgClipBoard.CopyType SelectedCopyType { get; }

        /// <summary>
        /// </summary>
        ObservableCollection<IPatch> ProtectedPatches { get; }

        /// <summary>
        /// </summary>
        IPcgMemory PastePcgMemory { get; }

        /// <summary>
        /// </summary>
        void Clear();

        /// <summary>
        /// </summary>
        /// <param name="program"></param>
        /// <param name="clearAfterCopy"></param>
        /// <returns></returns>
        IClipBoardProgram CopyProgramToClipBoard(IProgram program, bool clearAfterCopy);

        /// <summary>
        /// </summary>
        /// <param name="combi"></param>
        /// <param name="clearAfterCopy"></param>
        /// <returns></returns>
        IClipBoardCombi CopyCombiToClipBoard(ICombi combi, bool clearAfterCopy);

        /// <summary>
        /// </summary>
        /// <param name="setListSlot"></param>
        /// <param name="clearAfterCopy"></param>
        void CopySetListSlotToClipBoard(ISetListSlot setListSlot, bool clearAfterCopy);

        /// <summary>
        /// </summary>
        /// <param name="drumKit"></param>
        /// <param name="clearAfterCopy"></param>
        /// <returns></returns>
        IClipBoardDrumKit CopyDrumKitToClipBoard(IDrumKit drumKit, bool clearAfterCopy);

        /// <summary>
        /// </summary>
        /// <param name="drumPattern"></param>
        /// <param name="clearAfterCopy"></param>
        /// <returns></returns>
        IClipBoardDrumPattern CopyDrumPatternToClipBoard(IDrumPattern drumPattern, bool clearAfterCopy);

        /// <summary>
        /// </summary>
        /// <param name="waveSequence"></param>
        /// <param name="clearAfterCopy"></param>
        void CopyWaveSequenceToClipBoard(IWaveSequence waveSequence, bool clearAfterCopy);

        /// <summary>
        /// </summary>
        void Memorize();

        /// <summary>
        /// </summary>
        void FixPasteReferencesAfterCopyPaste();

        /// <summary>
        /// </summary>
        /// <param name="patches"></param>
        /// <returns></returns>
        IClipBoardPatch GetFirstPatchToPaste(IEnumerable<IClipBoardPatch> patches);

        /// <summary>
        /// </summary>
        /// <param name="patchToPaste"></param>
        /// <param name="patch"></param>
        void PastePatch(IClipBoardPatch patchToPaste, IPatch patch);
    }
}