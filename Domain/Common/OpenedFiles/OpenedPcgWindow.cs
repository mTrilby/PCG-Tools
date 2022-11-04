#region copyright

// (c) Copyright 2011-2022 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

using Common.MVVM;
using Domain.Common.Synth.MemoryAndFactory;

namespace Domain.Common.OpenedFiles
{
    /// <summary>
    /// </summary>
    public class OpenedPcgWindow : ObservableObject
    {
        /// <summary>
        /// </summary>
        private PcgMemory _pcgMemory;


        /// <summary>
        /// </summary>
        public PcgMemory PcgMemory
        {
            get => _pcgMemory;

            set
            {
                if (_pcgMemory != value)
                {
                    _pcgMemory = value;
                    RaisePropertyChanged("PcgMemory");
                }
            }
        }
    }
}