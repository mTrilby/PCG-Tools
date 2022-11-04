#region copyright

// (c) Copyright 2011-2022 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using Common.Extensions;
using Common.MVVM;
using Common.Utils;
using Domain.Common.ClipBoard;
using Domain.Common.ListGenerators;
using Domain.Common.Synth.Global;
using Domain.Common.Synth.MemoryAndFactory;
using Domain.Common.Synth.OldParameters;
using Domain.Common.Synth.PatchCombis;
using Domain.Common.Synth.PatchInterfaces;
using Domain.Common.Synth.PatchPrograms;
using Domain.Common.Synth.PatchSorting;

namespace Domain.Common.Synth.Meta
{
    /// <summary>
    /// </summary>
    /// <typeparam name="T"></typeparam>
    // ReSharper disable once UnusedTypeParameter
    public abstract class Patch<T> : ObservableObject, IPatch where T : INotifyPropertyChanged
    {
        /// <summary>
        /// </summary>
        private string _id;


        /// <summary>
        /// </summary>
        private int _index;


        /// <summary>
        ///     Used for UI control binding for selections.
        /// </summary>
        private bool _isSelected;


        /// <summary>
        /// </summary>
        protected Patch()
        {
            PropertyChanged += OnPropertyChanged;
        }


        /// <summary>
        /// </summary>
        public IBank Bank { get; protected set; }


        /// <summary>
        ///     The user index is the same as index, except for GM programs which are named as GM001 instead of GM000 etc.
        /// </summary>
        // ReSharper disable once UnusedMemberInSuper.Global
        public virtual int UserIndex => _index;


        /// <summary>
        /// </summary>
        public string Title
        {
            get
            {
                Debug.Assert(!string.IsNullOrEmpty(SettingsDefault.Sort_SplitCharacter));

                return PatchSorter.GetTitle(this);
            }
        }


        /// <summary>
        /// </summary>
        public string Artist
        {
            get
            {
                Debug.Assert(!string.IsNullOrEmpty(SettingsDefault.Sort_SplitCharacter));

                return PatchSorter.GetArtist(this);
            }
        }

        /// <summary>
        /// </summary>
        public abstract void SetParameters();


        /// <summary>
        /// </summary>
        public bool IsSelected
        {
            get => _isSelected;
            set
            {
                if (_isSelected != value)
                {
                    _isSelected = value;
                    RaisePropertyChanged("IsSelected");
                }
            }
        }


        /// <summary>
        /// </summary>
        public abstract void SetNotifications();


        /// <summary>
        /// </summary>
        public int ByteOffset { get; set; }


        /// <summary>
        /// </summary>
        public int ByteLength { get; set; }


        /// <summary>
        /// </summary>
        public bool IsLoaded { get; set; }


        /// <summary>
        /// </summary>
        public INavigable Parent => Bank;


        /// <summary>
        /// </summary>
        public IMemory Root => Parent.Root;


        /// <summary>
        /// </summary>
        public IPcgMemory PcgRoot => (IPcgMemory)Root;


        /// <summary>
        /// </summary>
        public abstract bool IsEmptyOrInit { get; }


        /// <summary>
        /// </summary>
        public abstract void Clear();


        /// <summary>
        /// </summary>
        public abstract string Name { get; set; }


        /// <summary>
        ///     Changes the suffix of the name (right padded).
        /// </summary>
        /// <param name="suffix"></param>
        /// <returns></returns>
        public void SetNameSuffix(string suffix)
        {
            Debug.Assert(suffix.Length < MaxNameLength);
            Name = Name.Substring(0, Math.Min(Name.Length, MaxNameLength - suffix.Length)) +
                   new string(' ', Math.Max(0, MaxNameLength - Name.Length - suffix.Length)) +
                   suffix;
        }


        /// <summary>
        /// </summary>
        public abstract int MaxNameLength { get; }


        /// <summary>
        /// </summary>
        public int Index
        {
            get => _index;

            protected set
            {
                if (_index != value)
                {
                    _index = value;
                    OnPropertyChanged("Index");
                }
            }
        }


        /// <summary>
        /// </summary>
        public string Id
        {
            get => _id;
            protected set
            {
                if (_id != value)
                {
                    _id = value;
                    OnPropertyChanged("Id");
                }
            }
        }


        // ReSharper disable once UnusedMember.Global
        public int GetInt(int offset, int length)
        {
            return PcgRoot.Content == null ? 0 : Util.GetInt(PcgRoot.Content, ByteOffset + offset, length);
        }


        // ReSharper disable once UnusedMember.Global
        public void SetInt(int offset, int length, int value)
        {
            Util.SetInt(PcgRoot, PcgRoot.Content, ByteOffset + offset, length, value);
        }


        /// <summary>
        /// </summary>
        public abstract bool ToolTipEnabled { get; }


        /// <summary>
        /// </summary>
        public abstract string ToolTip { get; }


        /// <summary>
        /// </summary>
        /// <param name="ignoreInit"></param>
        /// <param name="filterOnText"></param>
        /// <param name="filterText"></param>
        /// <param name="caseSensitive"></param>
        /// <param name="useFavorites"></param>
        /// <param name="filterDescription"></param>
        /// <returns></returns>
        public bool UseInList(
            bool ignoreInit, bool filterOnText, string filterText, bool caseSensitive,
            ListGenerator.FilterOnFavorites useFavorites,
            bool filterDescription)
        {
            // Check ignore.
            var usePatch = !ignoreInit || !IsEmptyOrInit;

            // Check text filtering.
            usePatch &= FilterOnText(filterOnText, filterText, caseSensitive, filterDescription);

            usePatch &= CheckFavorite(useFavorites, usePatch);

            return usePatch;
        }


        /// <summary>
        ///     Returns the number of differences of the patch, taking into account the PBK2, CBK2 and SLS2 data and
        ///     stops when maxDiffs has been reached.
        /// </summary>
        /// <param name="otherPatch"></param>
        /// <param name="includingName"></param>
        /// <param name="maxDiffs"></param>
        /// <returns></returns>
        public virtual int CalcByteDifferences(IPatch otherPatch, bool includingName, int maxDiffs)
        {
            var patchSize = ByteLength;
            Debug.Assert(patchSize == otherPatch.ByteLength);
            Debug.Assert(otherPatch != null);

            var diffs = 0;
            var startIndex = includingName ? 0 : MaxNameLength;
            for (var index = startIndex; index < patchSize; index++)
            {
                if (UseIndexForDifferencing(index))
                {
                    if (PcgRoot.Content[ByteOffset + index] !=
                        otherPatch.PcgRoot.Content[otherPatch.ByteOffset + index])
                    {
                        diffs++;
                    }

                    if (diffs > maxDiffs)
                    {
                        break;
                    }
                }
            }

            return diffs;
        }


        /// <summary>
        /// </summary>
        /// <param name="otherPatch"></param>
        /// <param name="includingName"></param>
        /// <param name="maxDiffs"></param>
        /// <returns></returns>
        public virtual int CalcByteDifferences(IClipBoardPatch otherPatch, bool includingName, int maxDiffs)
        {
            var patchSize = ByteLength;
            Debug.Assert(patchSize == otherPatch.Data.Length);

            var diffs = 0;
            var startIndex = includingName ? 0 : MaxNameLength;
            for (var index = startIndex; index < patchSize; index++)
            {
                if (UseIndexForDifferencing(index))
                {
                    if (PcgRoot.Content[ByteOffset + index] != otherPatch.Data[index])
                    {
                        diffs++;
                    }

                    if (diffs > maxDiffs)
                    {
                        break;
                    }
                }
            }

            return diffs;
        }


        /// <summary>
        ///     Returns the number of differences within the name and description of two patches.
        /// </summary>
        /// <param name="otherPatch"></param>
        /// <returns></returns>
        public virtual int CalcByteDifferencesInNameAndDescription(IPatch otherPatch)
        {
            var patchSize = ByteLength;
            Debug.Assert(patchSize == ByteLength);
            Debug.Assert(otherPatch != null);
            Debug.Assert(MaxNameLength == otherPatch.MaxNameLength);

            // Add name differences.
            var diffs = 0;
            for (var index = 0; index < MaxNameLength; index++)
            {
                diffs += PcgRoot.Content[ByteOffset + index] != otherPatch.Root.Content[otherPatch.ByteOffset + index]
                    ? 1
                    : 0;
            }

            return diffs;
        }


        /// <summary>
        ///     Calculats a CRC value by adding all bytes, module by 2 bytes.
        /// </summary>
        /// <returns></returns>
        public int CalcCrc(bool includingName)
        {
            var value = 0; // Skip name (assuming name starts at byte 0)
            for (var index = includingName ? 0 : MaxNameLength; index < ByteLength; index++)
            {
                value += PcgRoot.Content[ByteOffset + index];
            }

            return value % (1 << 16);
        }


        /// <summary>
        ///     Returns true if the patch is present within the master file.
        /// </summary>
        public bool IsFromMasterFile
        {
            get
            {
                var masterPcgMemory = MasterFiles.MasterFiles.Instances.FindMasterPcg(Root.Model);
                return masterPcgMemory == PcgRoot;
            }
        }


        /// <summary>
        /// </summary>
        /// <param name="name"></param>
        public abstract void Update(string name);


        /// <summary>
        ///     Empty objects last, otherwise sort ordinally.
        ///     IMPR: Convert into Comparer, but take into account WPF/MVVM issues using IComparable instead of IComparer
        /// </summary>
        /// <param name="otherPatch"></param>
        /// <returns></returns>
        public int CompareTo(IPatch otherPatch)
        {
            if (otherPatch == null)
            {
                return -1;
            }

            if (IsEmptyOrInit)
            {
                return otherPatch.IsEmptyOrInit ? string.CompareOrdinal(Name, otherPatch.Name) : 1;
            }

            if (otherPatch.IsEmptyOrInit)
            {
                return -1;
            }

            return string.CompareOrdinal(Name, otherPatch.Name);
        }


        /// <summary>
        ///     Checks if the patch is like named.
        ///     Two patches are like named if:
        ///     - They are equal.
        ///     - When one of the characters/fragments to be ignored are stripped of and equal.
        /// </summary>
        /// <param name="otherName"></param>
        /// <returns></returns>
        public bool IsNameLike(string otherName)
        {
            if (Name.Trim() == otherName.Trim())
            {
                return true;
            }

            return (from fragment in SettingsDefault.CopyPaste_IgnoreCharactersForPatchDuplication.Split(',')
                let strippedName = Name.RemoveFromEnd(fragment).Trim()
                let strippedOtherName = otherName.RemoveFromEnd(fragment).Trim()
                where strippedName == strippedOtherName
                select strippedName).Any();
        }


        /// <summary>
        ///     Finds the first duplicate of the patch (excluding itself or an earlier cleared patch),
        ///     or None if not existing (so patch is unique).
        /// </summary>
        public IPatch FirstDuplicate
        {
            get
            {
                if (!IsLoaded)
                {
                    return null;
                }

                return (from bank in ((IBanks)Parent.Parent).BankCollection
                    where bank.Type != BankType.EType.Gm && bank.IsLoaded
                    from patch in bank.Patches
                    where patch != this && !patch.IsEmptyOrInit
                    select patch).FirstOrDefault(
                    patch => CalcByteDifferences(patch, false, 0) == 0);
            }
        }


        /// <summary>
        /// </summary>
        /// <param name="offset"></param>
        /// <param name="length"></param>
        /// <returns></returns>
        protected string GetChars(int offset, int length)
        {
            return PcgRoot.Content == null ? string.Empty : Util.GetChars(PcgRoot.Content, ByteOffset + offset, length);
        }


        /// <summary>
        /// </summary>
        /// <param name="offset"></param>
        /// <param name="maxLength"></param>
        /// <param name="text"></param>
        protected void SetChars(int offset, int maxLength, string text)
        {
            Util.SetChars(PcgRoot, PcgRoot.Content, ByteOffset + offset, maxLength, text);
        }


        /// <summary>
        /// </summary>
        /// <param name="filterOnText"></param>
        /// <param name="filterText"></param>
        /// <param name="caseSensitive"></param>
        /// <param name="filterDescription"></param>
        /// <returns></returns>
        protected virtual bool FilterOnText(
            bool filterOnText, string filterText, bool caseSensitive, bool filterDescription = true)
        {
            return !filterOnText ||
                   (caseSensitive && Name.Contains(filterText)) ||
                   (!caseSensitive && Name.ToUpper().Contains(filterText.ToUpper()));
        }


        /// <summary>
        /// </summary>
        /// <param name="useFavorites"></param>
        /// <param name="usePatch"></param>
        /// <returns></returns>
        private bool CheckFavorite(ListGenerator.FilterOnFavorites useFavorites, bool usePatch)
        {
            var areFavoritesSupported = PcgRoot.AreFavoritesSupported;
            if (areFavoritesSupported)
            {
                var favoriteParameter =
                    this is IProgram
                        ? ((IProgram)this).GetParam(ParameterNames.ProgramParameterName.Favorite)
                        : this is ICombi
                            ? ((ICombi)this).GetParam(ParameterNames.CombiParameterName.Favorite)
                            : null; // TODO: Fix this ugly code
                usePatch &= PcgRoot.AreFavoritesSupported &&
                            UseFavorite(useFavorites, favoriteParameter);
            }

            return usePatch;
        }


        /// <summary>
        /// </summary>
        /// <param name="useFavorites"></param>
        /// <param name="favoriteParameter"></param>
        /// <returns></returns>
        private static dynamic UseFavorite(ListGenerator.FilterOnFavorites useFavorites,
            IParameter favoriteParameter)
        {
            return useFavorites == ListGenerator.FilterOnFavorites.All ||
                   (favoriteParameter != null &&
                    useFavorites == ListGenerator.FilterOnFavorites.No &&
                    !favoriteParameter.Value) ||
                   (favoriteParameter != null &&
                    useFavorites == ListGenerator.FilterOnFavorites.Yes &&
                    favoriteParameter.Value);
        }


        /// <summary>
        ///     Sometimes some bytes do not need to be taken into account (such as references to drum kits).
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        protected virtual bool UseIndexForDifferencing(int index)
        {
            return true;
        }


        /// <summary>
        ///     Returns the global of this PCG or if no global present, the Master PCG file's global.
        ///     This is a copy from Timbre.cs
        /// </summary>
        /// <returns></returns>
        protected IGlobal FindGlobal()
        {
            var global = PcgRoot.Content == null ? null : PcgRoot.Global;
            if (global == null)
            {
                // Find master PCG memory (except when file is master file itself).
                var masterPcgMemory = MasterFiles.MasterFiles.Instances.FindMasterPcg(Root.Model);
                if (masterPcgMemory != null && masterPcgMemory.FileName != Root.FileName)
                {
                    global = masterPcgMemory.Global;
                }
            }

            return global;
        }


        /// <summary>
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"{Id}:{Name}";
        }


        /// <summary>
        ///     In case the name changes, check if it is a single patch file and if so, the name of the file might need to be
        ///     changed.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            switch (e.PropertyName)
            {
                case "Name":
                    var memory = PcgRoot;
                    if (memory.HasOnlyOnePatch && SettingsDefault.Edit_RenameFileWhenPatchNameChanges)
                    {
                        var directoryName = Path.GetDirectoryName(memory.OriginalFileName);
                        PcgRoot.FileName = directoryName + memory.NameOfOnlyPatch;
                    }

                    break;

                // default: Do nothing
            }
        }


        /// <summary>
        ///     Change all references to the current patch, towards the specified patch.
        /// </summary>
        /// <param name="newPatch"></param>
        public abstract void ChangeReferences(IPatch newPatch);
    }
}