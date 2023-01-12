#region copyright

// (c) Copyright 2011-2023 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

#region using

using Domain.Common.ClipBoard;
using Domain.Common.Synth.Global;
using Domain.Common.Synth.Meta;
using Domain.Common.Synth.PatchCombis;
using Domain.Common.Synth.PatchDrumKits;
using Domain.Common.Synth.PatchDrumPatterns;
using Domain.Common.Synth.PatchPrograms;
using Domain.Common.Synth.PatchSetLists;
using Domain.Common.Synth.PatchWaveSequences;

#endregion

namespace Domain.Common.Synth.MemoryAndFactory
{
    /// <summary>
    /// </summary>
    public interface IPcgMemory : IPcgMemoryInit
    {
        /// <summary>
        ///     Program banks.
        /// </summary>
        IProgramBanks ProgramBanks { get; set; }

        /// <summary>
        ///     Combi banks.
        /// </summary>
        ICombiBanks CombiBanks { get; set; }

        /// <summary>
        ///     Set lists.
        /// </summary>
        ISetLists SetLists { get; set; }

        /// <summary>
        ///     Wave Sequence banks.
        /// </summary>
        IWaveSequenceBanks WaveSequenceBanks { get; set; }

        /// <summary>
        ///     Drum kit banks.
        /// </summary>
        IDrumKitBanks DrumKitBanks { get; set; }

        /// <summary>
        /// </summary>
        IDrumPatternBanks DrumPatternBanks { get; set; }

        /// <summary>
        ///     Global (single).
        /// </summary>
        IGlobal Global { get; set; }

        /// <summary>
        /// </summary>
        bool HasOnlyOnePatch { get; }

        /// <summary>
        /// </summary>
        bool HasSubCategories { get; }

        /// <summary>
        /// </summary>
        bool HasProgramCategories { get; }

        /// <summary>
        /// </summary>
        bool HasCombiCategories { get; }

        /// <summary>
        /// </summary>
        bool AreCategoriesEditable { get; }

        /// <summary>
        /// </summary>
        bool UsesCategoriesAndSubCategories { get; }

        /// <summary>
        /// </summary>
        IProgram AssignedClearProgram { get; set; }

        /// <summary>
        /// </summary>
        string OriginalFileName { get; }

        /// <summary>
        /// </summary>
        string NameOfOnlyPatch { get; }

        /// <summary>
        /// </summary>
        bool CanContainOnlyOnePatch { get; }

        /// <summary>
        /// </summary>
        bool AreAllNeededProgramsCombisAndGlobalPresent { get; }

        /// <summary>
        /// </summary>
        string CategoryName { get; }

        /// <summary>
        /// </summary>
        string SubCategoryName { get; }

        /// <summary>
        /// </summary>
        /// <param name="patch1"></param>
        /// <param name="patch2"></param>
        void SwapPatch(IPatch patch1, IPatch patch2);

        /// <summary>
        /// </summary>
        /// <param name="patch1"></param>
        /// <param name="patch2"></param>
        void CopyPatch(IClipBoardPatch patch1, IPatch patch2);

        /// <summary>
        /// </summary>
        /// <param name="patch1"></param>
        /// <param name="patch2"></param>
        void CopyPatch(IPatch patch1, IPatch patch2);

        /// <summary>
        ///     Some single program files do not have their program name filled in at the start of the program
        ///     contents, but only as file name. This method copies the file name to the correct location.
        /// </summary>
        void SynchronizeProgramName();

        /// <summary>
        ///     Some single combi files do not have their combi name filled in at the start of the combi
        ///     contents, but only as file name. This method copies the file name to the correct location.
        /// </summary>
        void SynchronizeCombiName();

        /// <summary>
        ///     Select first bank of each type.
        /// </summary>
        void SelectFirstBanks();

        /// <summary>
        /// </summary>
        /// <param name="programRawBankIndex"></param>
        /// <param name="programRawIndex"></param>
        /// <returns></returns>
        IProgram GetPatchByRawIndices(
            int programRawBankIndex,
            int programRawIndex);
    }
}