#region copyright

// (c) Copyright 2011-2022 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

using Domain.Common.Synth.Meta;
using Domain.Common.Synth.PatchDrumPatterns;

namespace Domain.KronosOasysSpecific.Synth
{
    /// <summary>
    /// </summary>
    public abstract class KronosOasysDrumPattern : DrumPattern
    {
        /// <summary>
        /// </summary>
        /// <param name="drumPatternBank"></param>
        /// <param name="index"></param>
        protected KronosOasysDrumPattern(IBank drumPatternBank, int index)
            : base(drumPatternBank, index)
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
                                              Name.StartsWith("DrumPattern      0") ||
                                              (Name.Contains("Init") && Name.Contains("Drum") &&
                                               Name.Contains("Pattern"));
    }
}