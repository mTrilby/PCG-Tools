#region copyright

// (c) Copyright 2011-2022 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

using System;
using System.Text;
using Common.Extensions;
using Common.PcgToolsResources;
using PcgTools.Model.Common.Synth.Meta;

namespace PcgTools.Model.Common.Synth.PatchDrumKits
{
    /// <summary>
    /// </summary>
    public abstract class DrumKit : Patch<DrumKit>, IDrumKit
    {
        /// <summary>
        /// </summary>
        /// <param name="drumKitBank"></param>
        /// <param name="index"></param>
        protected DrumKit(IBank drumKitBank, int index)
        {
            Bank = drumKitBank;
            Index = index;
            Id = $"{drumKitBank.Id}{index.ToString("000")}";
        }


        /// <summary>
        /// </summary>
        // ReSharper disable once UnusedMember.Global
        public string PatchTypeAsString => Strings.DrumKit;


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
        /// </summary>
        public override void SetParameters()
        {
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