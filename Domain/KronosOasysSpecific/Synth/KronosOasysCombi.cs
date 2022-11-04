#region copyright

// (c) Copyright 2011-2022 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

using Domain.Common.Synth.PatchCombis;

namespace Domain.KronosOasysSpecific.Synth
{
    /// <summary>
    /// </summary>
    public abstract class KronosOasysCombi : Combi
    {
        /// <summary>
        /// </summary>
        /// <param name="combiBank"></param>
        /// <param name="index"></param>
        protected KronosOasysCombi(ICombiBank combiBank, int index)
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