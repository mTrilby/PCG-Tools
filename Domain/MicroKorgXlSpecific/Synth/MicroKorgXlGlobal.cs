#region copyright

// (c) Copyright 2011-2022 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

using System.Collections.Generic;
using Domain.Common.Synth.Global;
using Domain.Common.Synth.MemoryAndFactory;
using Domain.Common.Synth.Meta;
using Domain.Common.Synth.OldParameters;
using Domain.Common.Synth.PatchCombis;
using Domain.Common.Synth.PatchPrograms;

namespace Domain.MicroKorgXlSpecific.Synth
{
    /// <summary>
    /// </summary>
    public class MicroKorgXlGlobal : Global
    {
        /// <summary>
        /// </summary>
        /// <param name="pcgMemory"></param>
        public MicroKorgXlGlobal(IPcgMemory pcgMemory)
            : base(pcgMemory)
        {
        }

        /// <summary>
        /// </summary>
        protected override int CategoryNameLength => 16;


        /// <summary>
        ///     Hardcoded.
        /// </summary>
        protected override int PcgOffsetCategories => -1;


        /// <summary>
        ///     Called genres.
        /// </summary>
        protected override int NrOfCategories => 8;


        /// <summary>
        ///     Called Categories.
        /// </summary>
        protected override int NrOfSubCategories => 8;


        /// <summary>
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

            var genres = new List<string>
            {
                "Vintage",
                "Rock/Pop",
                "R&B/Hip Hop",
                "Jazz/Fusion",
                "Techno/Trance",
                "House/Disco",
                "D'N'B/Break",
                "Favorite"
            };
            var name = genres[category];

            return name;
        }


        /// <summary>
        /// </summary>
        /// <param name="patch"></param>
        /// <returns></returns>
        public override string GetSubCategoryName(IPatch patch)
        {
            var subCategory = -1;
            if (patch is IProgram)
            {
                subCategory = ((IProgram)patch).GetParam(ParameterNames.ProgramParameterName.Category).Value;
            }
            else if (patch is ICombi)
            {
                subCategory = ((ICombi)patch).GetParam(ParameterNames.CombiParameterName.Category).Value;
            }

            var categories = new List<string>
            {
                "Poly Synth",
                "Bass",
                "Lead",
                "Arp/Motion",
                "Pad/Strings",
                "Keyboard/Bell",
                "S.E./Hit",
                "Vocoder"
            };
            var name = categories[subCategory];
            return name;
        }
    }
}