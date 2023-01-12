#region copyright

// (c) Copyright 2011-2023 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

#region using

using System;
using Domain.Common.Synth.Global;
using Domain.Common.Synth.MemoryAndFactory;
using Domain.Common.Synth.Meta;
using Domain.Common.Synth.OldParameters;
using Domain.Common.Synth.PatchPrograms;

#endregion

namespace Domain.Ms2000Specific.Synth
{
    /// <summary>
    /// </summary>
    public class Ms2000Global : Global
    {
        /// <summary>
        /// </summary>
        /// <param name="pcgMemory"></param>
        public Ms2000Global(PcgMemory pcgMemory)
            : base(pcgMemory)
        {
        }

        /// <summary>
        ///     Category names are not in PCG.
        /// </summary>
        protected override int CategoryNameLength => 16;

        /// <summary>
        ///     Hardcoded.
        /// </summary>
        protected override int PcgOffsetCategories => -1;

        /// <summary>
        ///     Categories are taken from Mode.
        /// </summary>
        protected override int NrOfCategories => 4;

        /// <summary>
        /// </summary>
        protected override int NrOfSubCategories => throw new NotSupportedException("No sub categories available");

        /// <summary>
        /// </summary>
        /// <param name="patch"></param>
        /// <returns></returns>
        public override string GetCategoryName(IPatch patch)
        {
            string name;

            var mode = (Ms2000Program.EMode)((IProgram)patch).GetParam(ParameterNames.ProgramParameterName.Mode).Value;

            switch (mode)
            {
                case Ms2000Program.EMode.Single:
                    name = "Single";
                    break;

                case Ms2000Program.EMode.Layer:
                    name = "Layer";
                    break;

                case Ms2000Program.EMode.Split:
                    name = "Split";
                    break;

                case Ms2000Program.EMode.Vocoder:
                    name = "Vocoder";
                    break;

                default:
                    throw new ApplicationException("Illegal case");
            }

            return name;
        }
    }
}