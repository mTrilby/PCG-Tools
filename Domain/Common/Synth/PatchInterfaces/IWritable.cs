#region copyright

// (c) Copyright 2011-2023 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

namespace Domain.Common.Synth.PatchInterfaces
{
    /// <summary>
    /// </summary>
    public interface IWritable
    {
        /// <summary>
        ///     Writable, means it is present in the PCG file (to be overwritten).
        /// </summary>
        bool IsWritable { get; set; }
    }
}