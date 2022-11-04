#region copyright

// (c) Copyright 2011-2022 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

using System.Windows.Controls;

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