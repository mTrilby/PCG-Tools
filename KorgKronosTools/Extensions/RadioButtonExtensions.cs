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
    public static class RadioButtonExtensions
    {
        /// <summary>
        /// </summary>
        /// <param name="button"></param>
        /// <returns></returns>
        public static bool IsReallyChecked(this RadioButton button)
        {
            return button.IsChecked.HasValue && button.IsChecked.Value;
        }
    }
}