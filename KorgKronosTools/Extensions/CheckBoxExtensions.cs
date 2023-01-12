#region copyright

// (c) Copyright 2011-2023 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

#region using

using System.Windows.Controls;

#endregion

namespace PcgTools.Extensions
{
    /// <summary>
    /// </summary>
    public static class CheckBoxExtensions
    {
        /// <summary>
        /// </summary>
        /// <param name="box"></param>
        /// <returns></returns>
        public static bool IsReallyChecked(this CheckBox box)
        {
            return box.IsChecked.HasValue && box.IsChecked.Value;
        }
    }
}