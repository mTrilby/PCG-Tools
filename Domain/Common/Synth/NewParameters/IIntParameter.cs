#region copyright

// (c) Copyright 2011-2023 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

namespace PcgTools.Model.Common.Synth.NewParameters
{
    /// <summary>
    ///     /
    /// </summary>
    public interface IIntParameter
    {
        /// <summary>
        /// </summary>
        string Name { get; }

        /// <summary>
        /// </summary>
        int Value { get; set; }

        /// <summary>
        /// </summary>
        int MinRange { get; }

        /// <summary>
        /// </summary>
        int MaxRange { get; }
    }
}