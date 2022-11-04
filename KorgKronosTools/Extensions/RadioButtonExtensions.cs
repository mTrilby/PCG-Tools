#region copyright

// (c) Copyright 2011-2022 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

using System.Windows.Controls;

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