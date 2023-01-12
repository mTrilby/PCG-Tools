#region copyright

// (c) Copyright 2011-2023 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

#region using

using System.Collections.Generic;
using System.Linq;

#endregion

namespace PcgTools.Model.Common.Synth.PatchSorting
{
    /// <summary>
    ///     Class for comparing multiple keys.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class CompositeComparer<T> : Comparer<T>
    {
        /// <summary>
        /// </summary>
        public CompositeComparer()
        {
            Comparers = new List<IComparer<T>>();
        }

        /// <summary>
        /// </summary>
        public List<IComparer<T>> Comparers { get; }

        /// <summary>
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public override int Compare(T x, T y)
        {
            return Comparers.Select(comparer => comparer.Compare(x, y)).FirstOrDefault(result => result != 0);
        }
    }
}