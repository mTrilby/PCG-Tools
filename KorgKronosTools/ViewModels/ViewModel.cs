#region copyright

// (c) Copyright 2011-2023 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

#region using

using System;
using Common.MVVM;
using Domain.Common;
using Domain.Common.Synth.MemoryAndFactory;
using PcgTools.Mvvm;

#endregion

namespace PcgTools.ViewModels
{
    /// <summary>
    /// </summary>
    public abstract class ViewModel : ObservableObject, IViewModel
    {
        /// <summary>
        /// </summary>
        private IMemory _selectedMemory;

        /// <summary>
        /// </summary>
        public Action CloseWindow { protected get; set; }

        /// <summary>
        /// </summary>
        public virtual IMemory SelectedMemory
        {
            get => _selectedMemory;
            set
            {
                if (_selectedMemory != value)
                {
                    _selectedMemory = value;
                    OnPropertyChanged("SelectedMemory");
                }
            }
        }

        /// <summary>
        ///     Returns true if close can continue.
        /// </summary>
        /// <returns></returns>
        public abstract bool Close(bool exitMode);

        /// <summary>
        /// </summary>
        /// <returns></returns>
        public virtual bool Revert()
        {
            return true;
        }
    }
}