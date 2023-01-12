#region copyright

// (c) Copyright 2011-2023 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

namespace PcgTools.Model.Common.Synth.PatchInterfaces
{
    /// <summary>
    /// </summary>
    public interface ILoadable
    {
        /// <summary>
        ///     Loaded and available in the file.
        /// </summary>
        bool IsLoaded { get; set; }
    }
}