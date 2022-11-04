﻿#region copyright

// (c) Copyright 2011-2022 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

using System.Collections.Generic;
using System.Diagnostics;
using Domain.Common.Synth.PatchSorting;

namespace Domain.Common.Synth.PatchCombis
{
    /// <summary>
    ///     Utility class.
    /// </summary>
    public abstract class TimbreSorting
    {
        /// <summary>
        /// </summary>
        public enum ESortKey
        {
            ESortKeyStatus,
            ESortKeyMute,
            ESortKeyMidiChannel,
            ESortKeyKeyVelocity,
            ESortKeyKeyKeyZone,
            Last
        }

        /// <summary>
        /// </summary>
        private TimbreSorting()
        {
            // Not implemented.
        }


        /// <summary>
        /// </summary>
        /// <param name="timbres"></param>
        /// <param name="sortKeys"></param>
        public static void SortBy(List<Timbre> timbres, IEnumerable<ESortKey> sortKeys)
        {
            var comparers = new CompositeComparer<Timbre>();

            foreach (var key in sortKeys)
            {
                comparers.Comparers.Add(new TimbreComparer(key));
            }

            Debug.Assert(comparers.Comparers.Count == (int)ESortKey.Last);

            timbres.Sort(comparers);
        }
    }
}