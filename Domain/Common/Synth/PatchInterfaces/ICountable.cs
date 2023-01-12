﻿#region copyright

// (c) Copyright 2011-2023 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

namespace Domain.Common.Synth.PatchInterfaces
{
    /// <summary>
    /// </summary>
    public interface ICountable
    {
        /// <summary>
        /// </summary>
        int CountPatches { get; }

        /// <summary>
        /// </summary>
        int CountFilledPatches { get; }

        /// <summary>
        /// </summary>
        int CountFilledAndNonEmptyPatches { get; }

        /// <summary>
        /// </summary>
        int CountWritablePatches { get; }
    }
}