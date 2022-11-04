#region copyright

// (c) Copyright 2011-2022 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

using System;
using System.Collections.Generic;
using Domain.Common.Synth.Meta;
using Domain.Common.Synth.PatchInterfaces;

namespace Domain.Common.Synth.PatchSorting
{
    /// <summary>
    ///     Class for comparing titles (i.e. the part before or after the split character.)
    /// </summary>
    internal sealed class TitleComparer : Comparer<IPatch>
    {
        /// <summary>
        /// </summary>
        // ReSharper disable once FieldCanBeMadeReadOnly.Local
        private static TitleComparer _instance = new();


        /// <summary>
        /// </summary>
        private TitleComparer()
        {
        }


        /// <summary>
        /// </summary>
        public static TitleComparer Instance => _instance;


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

            return string.Compare(patch1.Title, patch2.Title, StringComparison.Ordinal);
        }
    }
}