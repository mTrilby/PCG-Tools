#region copyright

// (c) Copyright 2011-2023 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

#region using

using PcgTools.Model.Common.Synth.Meta;
using PcgTools.Model.Common.Synth.PatchCombis;

#endregion

namespace PcgTools.Model.MSpecific.Synth
{
    /// <summary>
    /// </summary>
    public abstract class MCombi : Combi
    {
        /// <summary>
        /// </summary>
        /// <param name="combiBank"></param>
        /// <param name="index"></param>
        protected MCombi(IBank combiBank, int index)
            : base(combiBank, index)
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
        public override bool IsEmptyOrInit => Name == string.Empty || (Name.Contains("Init") && Name.Contains("Combi"));
    }
}