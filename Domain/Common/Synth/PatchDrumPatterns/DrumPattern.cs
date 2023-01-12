#region copyright

// (c) Copyright 2011-2023 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

#region using

using System;
using System.Text;
using Common.Extensions;
using Common.PcgToolsResources;
using Domain.Common.Synth.Meta;

#endregion

namespace Domain.Common.Synth.PatchDrumPatterns
{
    /// <summary>
    /// </summary>
    public abstract class DrumPattern : Patch<DrumPattern>, IDrumPattern
    {
        /// <summary>
        /// </summary>
        /// <param name="drumPatternBank"></param>
        /// <param name="index"></param>
        protected DrumPattern(IBank drumPatternBank, int index)
        {
            Bank = drumPatternBank;
            Index = index;
            Id = $"{drumPatternBank.Id}{index.ToString("000")}";
        }

        /// <summary>
        /// </summary>
        // ReSharper disable once UnusedMember.Global
        public string PatchTypeAsString => Strings.DrumPattern;

        /// <summary>
        /// </summary>
        public override void Clear()
        {
            Name = string.Empty;
            RaisePropertyChanged(string.Empty, false);
        }

        /// <summary>
        /// </summary>
        public override void SetNotifications()
        {
            // No implementation needed for now.
        }

        /// <summary>
        /// </summary>
        /// <param name="name"></param>
        public override void Update(string name)
        {
            //  No implementation needed for now.
        }

        /// <summary>
        /// </summary>
        public override bool ToolTipEnabled => !IsEmptyOrInit;

        /// <summary>
        /// </summary>
        public override string ToolTip
        {
            get
            {
                var builder = new StringBuilder();
                if (IsEmptyOrInit)
                {
                    builder.Append(Strings.EmptyOrInitPatchName);
                }

                return builder.ToString().RemoveLastNewLine();
            }
        }

        /// <summary>
        ///     Change all references to the current patch, towards the specified patch.
        /// </summary>
        /// <param name="newPatch"></param>
        public override void ChangeReferences(IPatch newPatch)
        {
            throw new NotImplementedException();
        }
    }
}