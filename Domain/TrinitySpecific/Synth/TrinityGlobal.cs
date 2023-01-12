#region copyright

// (c) Copyright 2011-2023 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

#region using

using System;
using Common.Utils;
using Domain.Common.Synth.Global;
using Domain.Common.Synth.MemoryAndFactory;

#endregion

namespace Domain.TrinitySpecific.Synth
{
    /// <summary>
    /// </summary>
    public class TrinityGlobal : Global
    {
        /// <summary>
        /// </summary>
        /// <param name="pcgMemory"></param>
        public TrinityGlobal(IPcgMemory pcgMemory)
            : base(pcgMemory)
        {
        }

        /// <summary>
        /// </summary>
        protected override int PcgOffsetCategories => 146;

        /// <summary>
        /// </summary>
        protected override int SizeOfProgramsCategoriesAndSubCategories => NrOfCategories * 2 * CategoryNameLength;

        /// <summary>
        /// </summary>
        protected override int CategoryNameLength => 16;

        /// <summary>
        /// </summary>
        protected override int NrOfCategories => 16;

// 16 for A and 16 for B.

/// <summary>
/// </summary>
protected override int NrOfSubCategories => throw new NotSupportedException("No sub categories supported");

/// <summary>
///     Returns offset from global.
/// </summary>
/// <param name="type"></param>
/// <param name="index"></param>
/// <returns></returns>
protected override int CalcCategoryNameOffset(ECategoryType type, int index)
        {
            var offset = ByteOffset + PcgOffsetCategories;
            if (!SettingsDefault.TrinityCategorySetA)
            {
                offset += CategoryNameLength * NrOfCategories;
            }

            offset += type == ECategoryType.Program ? 0 : SizeOfProgramsCategoriesAndSubCategories;
            offset += index * CategoryNameLength;
            return offset;
        }
    }
}