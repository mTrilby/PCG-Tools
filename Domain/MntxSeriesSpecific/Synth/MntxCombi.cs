#region copyright

// (c) Copyright 2011-2022 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

using Domain.Common.Synth.Meta;
using Domain.Common.Synth.OldParameters;
using Domain.Common.Synth.PatchCombis;

namespace Domain.MntxSeriesSpecific.Synth
{
    /// <summary>
    /// </summary>
    public abstract class MntxCombi : Combi
    {
        /// <summary>
        /// </summary>
        /// <param name="combiBank"></param>
        /// <param name="index"></param>
        protected MntxCombi(IBank combiBank, int index)
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
                }
            }
        }


        /// <summary>
        /// </summary>
        public override int MaxNameLength => 10;


        /// <summary>
        ///     Use Comb instead of Combi, because of some Mntx EXB-H banks are initialized as InitCombEH....
        /// </summary>
        public override bool IsEmptyOrInit => Name == string.Empty || (Name.Contains("Init") && Name.Contains("Comb"));


        /// <summary>
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public override IParameter GetParam(ParameterNames.CombiParameterName name)
        {
            IParameter parameter;

            switch (name)
            {
                default:
                    parameter = base.GetParam(name);
                    break;
            }

            return parameter;
        }
    }
}