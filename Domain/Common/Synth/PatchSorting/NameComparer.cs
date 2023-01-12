﻿#region copyright

// (c) Copyright 2011-2023 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

#region using

using System;
using System.Collections.Generic;
using System.Diagnostics;
using Domain.Common.Synth.Meta;

#endregion

namespace Domain.Common.Synth.PatchSorting
{
    /// <summary>
    ///     Class for comparing names in an ordinal manner.
    /// </summary>
    internal sealed class NameComparer : Comparer<IPatch>
    {
        /// <summary>
        /// </summary>
        // ReSharper disable once FieldCanBeMadeReadOnly.Local
        private static NameComparer _instance = new();

        /// <summary>
        /// </summary>
        private NameComparer()
        {
        }

        /// <summary>
        /// </summary>
        public static NameComparer Instance => _instance;

        /// <summary>
        /// </summary>
        /// <param name="p1"></param>
        /// <param name="p2"></param>
        /// <returns></returns>
        public override int Compare(IPatch p1, IPatch p2)
        {
            Debug.Assert(p1 != null);
            Debug.Assert(p2 != null);

            return string.Compare(p1.Name, p2.Name, StringComparison.Ordinal);
        }
    }
}