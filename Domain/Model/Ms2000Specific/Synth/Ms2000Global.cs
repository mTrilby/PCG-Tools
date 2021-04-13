// (c) Copyright 2011-2019 MiKeSoft, Michel Keijzers, All rights reserved

using System;
using Domain.Model.Common.Synth.Global;
using Domain.Model.Common.Synth.MemoryAndFactory;
using Domain.Model.Common.Synth.Meta;
using Domain.Model.Common.Synth.OldParameters;
using Domain.Model.Common.Synth.PatchPrograms;

namespace Domain.Model.Ms2000Specific.Synth
{
    /// <summary>
    /// 
    /// </summary>
    public class Ms2000Global : Global
    {
        /// <summary>
        /// Category names are not in PCG.
        /// </summary>
        protected override int CategoryNameLength => 16;


        /// <summary>
        /// Hardcoded.
        /// </summary>
        protected override int PcgOffsetCategories => -1;


        /// <summary>
        /// Categories are taken from Mode.
        /// </summary>
        protected override int NrOfCategories => 4;


        /// <summary>
        /// </summary>
        protected override int NrOfSubCategories
        {
            get { throw new NotSupportedException("No sub categories available"); }
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="pcgMemory"></param>
        public Ms2000Global(PcgMemory pcgMemory)
            : base(pcgMemory)
        {
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="patch"></param>
        /// <returns></returns>
        public override string GetCategoryName(IPatch patch)
        {
            string name;

            var mode = (Ms2000Program.EMode) (((IProgram) patch).GetParam(ParameterNames.ProgramParameterName.Mode).Value);

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
