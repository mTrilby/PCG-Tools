#region copyright

// (c) Copyright 2011-2023 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

#region using

using System.Collections.ObjectModel;
using System.Linq;
using PcgTools.Model.Common.Synth.MemoryAndFactory;
using PcgTools.Mvvm;
using PcgTools.OpenedFiles;

#endregion

namespace PcgTools.Songs
{
    /// <summary>
    /// </summary>
    public class OpenedPcgWindows : ObservableObject
    {
        /// <summary>
        /// </summary>
        private ObservableCollection<OpenedPcgWindow> _items;

        /// <summary>
        /// </summary>
        public OpenedPcgWindows()
        {
            Items = new ObservableCollection<OpenedPcgWindow>();
        }

        /// <summary>
        /// </summary>
        public ObservableCollection<OpenedPcgWindow> Items
        {
            get => _items;
            set
            {
                if (_items != value)
                {
                    _items = value;
                    RaisePropertyChanged("Items");
                }
            }
        }

        /// <summary>
        /// </summary>
        /// <param name="memory"></param>
        public void RemoveWindowWithPcgMemory(IMemory memory)
        {
            if (memory is IPcgMemory)
            {
                foreach (var item in Items.Where(item => item.PcgMemory == memory))
                {
                    Items.Remove(item);
                }
            }
        }
    }
}