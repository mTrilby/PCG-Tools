#region copyright

// (c) Copyright 2011-2023 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

#region using

using System.Collections.Generic;
using System.Text;

#endregion

namespace PatchDbBackEnd
{
    /// <summary>
    /// </summary>
    public class PatchDataList
    {
        /// <summary>
        /// </summary>
        public PatchDataList()
        {
            PatchList = new List<PatchData>();
        }

        /// <summary>
        /// </summary>
        public List<PatchData> PatchList { get; set; }

        public override string ToString()
        {
            var builder = new StringBuilder();

            foreach (var patch in PatchList)
            {
                builder.AppendLine($"{patch.PatchName}: {patch.Author}, {patch.Description}");
            }

            return builder.ToString();
        }
    }
}