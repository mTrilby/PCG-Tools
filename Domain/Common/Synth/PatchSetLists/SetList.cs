#region copyright

// (c) Copyright 2011-2023 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

#region using

using System.Linq;
using System.Text.RegularExpressions;
using Common.PcgToolsResources;
using Common.Utils;
using Domain.Common.Synth.Meta;

#endregion

namespace Domain.Common.Synth.PatchSetLists
{
    /// <summary>
    /// </summary>
    public abstract class SetList : Bank<SetListSlot>, ISetList
    {
        /// <summary>
        /// </summary>
        /// <param name="setLists"></param>
        /// <param name="type"></param>
        /// <param name="index"></param>
        /// <param name="pcgId"></param>
        protected SetList(IBanks setLists, BankType.EType type, int index, int pcgId)
            : base(setLists, type, index.ToString("000"), pcgId)
        {
        }

        /// <summary>
        ///     Used in XAML PCG Window in list view column.
        /// </summary>
        // ReSharper disable once UnusedMember.Global
        [UsedImplicitly]
        public string Column2 => Name;

        /// <summary>
        /// </summary>
        public override int MaxNameLength => 24;

        /// <summary>
        /// </summary>
        public override bool IsFilled
        {
            get
            {
                return (Name != null && !Regex.IsMatch(Name, @"^Set List [0-9]{3}$")) ||
                       (IsLoaded && Patches.Any(setListSlot => !setListSlot.IsEmptyOrInit));
            }
        }

        /// <summary>
        ///     Clear the name.
        /// </summary>
        public override void Clear()
        {
            Name = string.Empty;
        }

        /// <summary>
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"{Strings.SetList_2str} {Id}";
        }
    }
}