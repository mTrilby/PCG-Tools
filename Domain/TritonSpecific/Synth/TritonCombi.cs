#region copyright

// (c) Copyright 2011-2022 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

using Domain.Common.Synth.OldParameters;
using Domain.Common.Synth.PatchCombis;

namespace Domain.TritonSpecific.Synth
{
    /// <summary>
    /// </summary>
    public abstract class TritonCombi : Combi
    {
        /// <summary>
        /// </summary>
        /// <param name="combiBank"></param>
        /// <param name="index"></param>
        protected TritonCombi(ICombiBank combiBank, int index)
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
        public override int MaxNameLength => 16;


        /// <summary>
        ///     Use Comb instead of Combi, because of some Triton EXB-H banks are initialized as InitCombEH....
        /// </summary>
        public override bool IsEmptyOrInit => Name == string.Empty || (Name.Contains("Init") &&
                                                                       Name.Contains("Comb"));


        /// <summary>
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public override IParameter GetParam(ParameterNames.CombiParameterName name)
        {
            IParameter parameter;

            switch (name)
            {
                case ParameterNames.CombiParameterName.Tempo:
                    // Tempo on a Triton is only 1 byte (int) iso 2 for M series, Oasys/Kronos and is a float.
                    parameter = IntParameter.Instance.Set(PcgRoot, PcgRoot.Content, ByteOffset + 192, 7, 0, false,
                        this);
                    break;

                default:
                    parameter = base.GetParam(name);
                    break;
            }

            return parameter;
        }
    }
}