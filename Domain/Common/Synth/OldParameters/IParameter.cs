#region copyright

// (c) Copyright 2011-2023 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

#region using

using PcgTools.Model.Common.Synth.Meta;

#endregion

namespace PcgTools.Model.Common.Synth.OldParameters
{
    /// <summary>
    /// </summary>
    public interface IParameter
    {
        /// <summary>
        /// </summary>
        dynamic Value { get; set; }

        /// <summary>
        /// </summary>
        IPatch Patch { get; }
    }
}