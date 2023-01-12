#region copyright

// (c) Copyright 2011-2023 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

#region using

using Common.MVVM;
using Domain.Common.Synth.MemoryAndFactory;

#endregion

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