#region copyright

// (c) Copyright 2011-2023 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

namespace PcgTools.Model.Common.Synth.PatchInterfaces
{
    /// <summary>
    /// </summary>
    public interface ILocatable
    {
        /// <summary>
        /// </summary>
        int ByteOffset { get; set; }

        /// <summary>
        /// </summary>
        int ByteLength { get; set; }
    }
}