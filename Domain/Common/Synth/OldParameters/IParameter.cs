#region copyright

// (c) Copyright 2011-2022 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

using Domain.Common.Synth.Meta;

namespace Domain.Common.Synth.OldParameters
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