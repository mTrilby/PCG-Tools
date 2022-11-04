#region copyright

// (c) Copyright 2011-2022 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

using System.Windows.Controls;

namespace PcgTools.Controls
{
    /// <summary>
    /// </summary>
    public class ListBoxExtended : ListBox
    {
        /// <summary>
        /// </summary>
        public ListBoxExtended()
        {
            SelectionChanged += ListBoxExtended_SelectionChanged;
        }


        /// <summary>
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ListBoxExtended_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ScrollIntoView(SelectedItem);
        }
    }
}