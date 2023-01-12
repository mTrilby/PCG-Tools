﻿#region copyright

// (c) Copyright 2011-2023 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

#region using

using System;
using Domain.Common.Synth.Global;
using Domain.Common.Synth.MemoryAndFactory;
using Domain.Common.Synth.Meta;
using Domain.Common.Synth.OldParameters;
using Domain.Common.Synth.PatchCombis;
using Domain.Common.Synth.PatchPrograms;

#endregion

namespace Domain.MicroStationSpecific.Synth
{
    /// <summary>
    /// </summary>
    public class MicroStationGlobal : Global
    {
        /// <summary>
        /// </summary>
        /// <param name="pcgMemory"></param>
        public MicroStationGlobal(IPcgMemory pcgMemory)
            : base(pcgMemory)
        {
        }

        /// <summary>
        /// </summary>
        protected override int CategoryNameLength => 24;

        /// <summary>
        /// </summary>
        protected override int PcgOffsetCategories => 5312;

        /// <summary>
        ///     Despite the system exclusive information which allow for 18 values, only 8 are
        ///     shown in the manual (and are hardcoded).
        /// </summary>
        protected override int NrOfCategories => 8;

        /// <summary>
        /// </summary>
        protected override int NrOfSubCategories => 8;

        /// <summary>
        ///     Hardcoded prog/combi.
        /// </summary>
        /// <param name="patch"></param>
        /// <returns></returns>
        public override string GetCategoryName(IPatch patch)
        {
            var category = -1;
            if (patch is IProgram)
            {
                category = ((IProgram)patch).GetParam(ParameterNames.ProgramParameterName.Category).Value;
            }
            else if (patch is ICombi)
            {
                category = ((ICombi)patch).GetParam(ParameterNames.CombiParameterName.Category).Value;
            }

            //var list = new List<String>();
            var categories = new[]
            {
                "All", "Keyboard", "Strings/Brass/Woodwind", "Guitar", "Bass&Bass Split", "Synth", "Lead&Solo Split",
                "Drum/Mallet/Hits", "User"
            };

            return categories[category];
        }

        /// <summary>
        /// </summary>
        /// <param name="type"></param>
        /// <param name="index"></param>
        /// <param name="name"></param>
        public override void SetCategoryName(ECategoryType type, int index, string name)
        {
            throw new NotSupportedException("Unsupported categories");
            //Util.SetChars(_pcgMemory, _pcgMemory.Content, CalcCategoryNameOffset(type, index), CategoryNameLength, name);
        }

        /// <summary>
        ///     Returns offset from global.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="index"></param>
        /// <param name="subIndex"></param>
        /// <returns></returns>
        protected override int CalcSubCategoryNameOffset(ECategoryType type, int index, int subIndex)
        {
            var offset = ByteOffset + PcgOffsetCategories;
            var typeSize = PcgMemory.HasSubCategories ? NrOfCategories * NrOfSubCategories * CategoryNameLength : 0;

            offset += type == ECategoryType.Program ? 0 : typeSize;
            //offset += NrOfCategories*CategoryNameLength; // Categories size
            offset += index * NrOfSubCategories * CategoryNameLength;
            offset += subIndex * CategoryNameLength;

            return offset;
        }
    }
}