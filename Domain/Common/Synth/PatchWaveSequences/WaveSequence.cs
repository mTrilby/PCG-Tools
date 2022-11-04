﻿#region copyright

// (c) Copyright 2011-2022 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

using System;
using System.Text;
using Common.Extensions;
using Common.PcgToolsResources;
using Domain.Common.Synth.Meta;

namespace Domain.Common.Synth.PatchWaveSequences
{
    /// <summary>
    /// </summary>
    public abstract class WaveSequence : Patch<WaveSequence>, IWaveSequence
    {
        /// <summary>
        /// </summary>
        /// <param name="waveSeqBank"></param>
        /// <param name="index"></param>
        protected WaveSequence(IBank waveSeqBank, int index)
        {
            Bank = waveSeqBank;
            Index = index;
            Id = $"{waveSeqBank.Id}{index.ToString("000")}";
        }


        /// <summary>
        /// </summary>
        // ReSharper disable once UnusedMember.Global
        public string PatchTypeAsString => Strings.WaveSequence;


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

        public override void SetParameters()
        {
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