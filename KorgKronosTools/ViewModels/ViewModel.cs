#region copyright

// (c) Copyright 2011-2022 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

using System;
using PcgTools.Model.Common.Synth.MemoryAndFactory;
using PcgTools.Mvvm;

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