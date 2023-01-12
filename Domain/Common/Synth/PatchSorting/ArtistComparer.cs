#region copyright

// (c) Copyright 2011-2023 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

#region using

using System;
using System.Collections.Generic;
using Domain.Common.Synth.Meta;
using Domain.Common.Synth.PatchInterfaces;

#endregion

namespace Domain.Common.Synth.PatchSorting
{
    /// <summary>
    ///     Class for comparing artists (i.e. the part before or after the split character.)
    /// </summary>
    internal sealed class ArtistComparer : Comparer<IPatch>
    {
        /// <summary>
        /// </summary>
        private static readonly ArtistComparer _instance = new();

        /// <summary>
        /// </summary>
        private ArtistComparer()
        {
        }

        /// <summary>
        /// </summary>
        public static ArtistComparer Instance => _instance;

        /// <summary>
        /// </summary>
        /// <param name="p1"></param>
        /// <param name="p2"></param>
        /// <returns></returns>
        public override int Compare(IPatch p1, IPatch p2)
        {
            var patch1 = p1 as IArtistable;
            var patch2 = p2 as IArtistable;

            if (patch1 == null || patch2 == null)
            {
                return 0;
            }

            return string.Compare(patch1.Artist, patch2.Artist, StringComparison.Ordinal);
        }
    }
}