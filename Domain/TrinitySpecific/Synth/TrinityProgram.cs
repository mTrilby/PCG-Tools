#region copyright

// (c) Copyright 2011-2022 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

using System.Collections.Generic;
using Common.Utils;
using PcgTools.Model.Common.Synth.Meta;
using PcgTools.Model.Common.Synth.OldParameters;
using PcgTools.Model.Common.Synth.PatchPrograms;

namespace PcgTools.Model.TrinitySpecific.Synth
{
    /// <summary>
    /// </summary>
    public class TrinityProgram : Program
    {
        /// <summary>
        /// </summary>
        /// <param name="programBank"></param>
        /// <param name="index"></param>
        public TrinityProgram(IBank programBank, int index)
            : base(programBank, index)
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
        public override int MaxNameLength => 16;


        /// <summary>
        /// </summary>
        public override bool IsEmptyOrInit => Name == string.Empty || (Name.Contains("Init") && Name.Contains("Prog"));


        /// <summary>
        ///     Sets parameters after initialization.
        /// </summary>
        public override void SetParameters()
        {
        }


        /// <summary>
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public override IParameter GetParam(ParameterNames.ProgramParameterName name)
        {
            IParameter parameter;

            switch (name)
            {
                case ParameterNames.ProgramParameterName.OscMode:
                    parameter = EnumParameter.Instance.Set(Root, Root.Content, ByteOffset + 17, 1, 0,
                        new List<string> { "Single", "Double", "Drums" }, this);
                    break;

                case ParameterNames.ProgramParameterName.Category:
                    parameter = IntParameter.Instance.Set(PcgRoot, PcgRoot.Content, ByteOffset + 16,
                        SettingsDefault.TrinityCategorySetA ? 3 : 7,
                        SettingsDefault.TrinityCategorySetA ? 0 : 4,
                        false, this);
                    break;

                default:
                    parameter = base.GetParam(name);
                    break;
            }

            return parameter;
        }
    }
}