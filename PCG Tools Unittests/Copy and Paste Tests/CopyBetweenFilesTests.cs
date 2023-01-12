#region copyright

// (c) Copyright 2011-2023 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

#region using

using Common.MVVM;
using Common.Utils;
using Domain.Common.ClipBoard;
using Domain.Common.Commands;
using Domain.Common.File;
using Domain.Common.Synth.MemoryAndFactory;
using Domain.Common.Synth.Meta;
using Domain.Common.Synth.PatchPrograms;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PcgTools.Properties;

#endregion

// (c) 2011 Michel Keijzers

namespace PcgTools__UnitTests.Copy_and_Paste_Tests
{
    [TestClass]
    public class CopyBetweenFilesTests
    {
        private const string PcgDirectory = @"C:\PCG Tools Test Files\TestFiles\Workstations\";

        private PcgMemory _pcgOs2;
        private PcgMemory _pcgOs3;

        private void SetUp()
        {
            var korgFileReader = new KorgFileReader();
            _pcgOs2 = (PcgMemory)korgFileReader.Read(PcgDirectory + @"\Kronos\all.PCG");
            _pcgOs3 = (PcgMemory)korgFileReader.Read(PcgDirectory + @"\Kronos2\PRELOAD_V3_2016-10-01-20-23-33.PCG");

            // Set settings.
            Settings.Default.CopyPaste_AutoExtendedSinglePatchSelectionPaste = false;

            Settings.Default.CopyPaste_CopyIncompleteCombis = false;
            Settings.Default.CopyPaste_CopyIncompleteSetListSlots = false;

            Settings.Default.CopyPaste_CopyPatchesFromMasterFile = false;

            Settings.Default.CopyPaste_OverwriteFilledCombis = false;
            Settings.Default.CopyPaste_OverwriteFilledPrograms = false;
            Settings.Default.CopyPaste_OverwriteFilledSetListSlots = false;

            Settings.Default.CopyPaste_PasteDuplicateCombis = false;
            Settings.Default.CopyPaste_PasteDuplicatePrograms = false;
            Settings.Default.CopyPaste_PasteDuplicateSetListSlots = false;

            Settings.Default.CopyPaste_PatchDuplicationName = (int)CopyPaste.PatchDuplication.DoNotUsePatchNames;
            Settings.Default.CopyPaste_IgnoreCharactersForPatchDuplication = "V2";
        }

        [TestMethod]
        public void CopyProgramDefault()
        {
            SetUp();

            var program2 = ((ProgramBank)_pcgOs2.ProgramBanks[0])[0];
            var commands2 = new CopyPasteCommands();
            var banks = new ObservableCollectionEx<IBank>();
            var patches = new ObservableCollectionEx<IPatch> { program2 };

            var clipBoard = new PcgClipBoard();
            program2.IsSelected = true;
            commands2.CopyPasteCopy(clipBoard, _pcgOs2, ScopeSet.Patches, true,
                false, false, false, false, false, false,
                null, patches, false);

            var commands3 = new CopyPasteCommands();
            var program3 = _pcgOs3.ProgramBanks[0][0];
            var patches3 = new ObservableCollectionEx<IPatch> { program3 };
            banks.Add(program3.Parent as IBank);

            program3.Clear();
            program3.IsSelected = true;
            Assert.AreNotEqual(program2.Name, program3.Name);

            commands3.CopyPastePaste(clipBoard, _pcgOs3, ScopeSet.Patches, true,
                false, false, false, false, false, false,
                banks, patches3);
            Assert.AreEqual(program2.Name, program3.Name);
        }
    }
}