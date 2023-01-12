#region copyright

// (c) Copyright 2011-2023 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

#region using

using Domain.Common.Synth.Meta;
using Domain.Common.Synth.PatchDrumKits;

#endregion

namespace Domain.KronosOasysSpecific.Synth
{
    /// <summary>
    /// </summary>
    public abstract class KronosOasysDrumKit : DrumKit
    {
        /// <summary>
        /// </summary>
        /// <param name="drumKitBank"></param>
        /// <param name="index"></param>
        protected KronosOasysDrumKit(IBank drumKitBank, int index)
            : base(drumKitBank, index)
        {
        }

        /// <summary>
        /// </summary>
        public override string Name
        {
            get => GetChars(0, MaxNameLength);
            set
            {
                if (Name != value)
                {
                    SetChars(0, MaxNameLength, value);
                    OnPropertyChanged("Name");
                }
            }
        }

        /// <summary>
        /// </summary>
        public override int MaxNameLength => 24;

        /// <summary>
        /// </summary>
        public override bool IsEmptyOrInit => Name == string.Empty ||
                                              Name.StartsWith("Drumkit      0") ||
                                              (Name.Contains("Init") && Name.Contains("Drum") && Name.Contains("Kit"));
    }
}