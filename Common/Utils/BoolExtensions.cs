#region copyright

// (c) Copyright 2011-2022 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

using Common.PcgToolsResources;

namespace Common.Utils
{
    /// <summary>
    /// </summary>
    public static class BoolExtensions
    {
        /// <summary>
        ///     Should not be used because of internationalization.
        /// </summary>
        /// <param name="b"></param>
        /// <returns></returns>
        public static string ToYesNo(this bool b)
        {
            return b ? Strings.Yes : Strings.No;
        }
    }
}