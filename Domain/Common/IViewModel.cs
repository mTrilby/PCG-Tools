#region copyright

// (c) Copyright 2011-2023 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

#region using

using System.ComponentModel;
using Domain.Common.Synth.MemoryAndFactory;

#endregion

namespace Domain.Common
{
    /// <summary>
    /// </summary>
    public interface IViewModel : INotifyPropertyChanged
    {
        /// <summary>
        /// </summary>
        IMemory SelectedMemory { get; set; }

        /// <summary>
        /// </summary>
        /// <param name="exitMode"></param>
        /// <returns></returns>
        bool Close(bool exitMode);

        /// <summary>
        ///     Returns true if revert can continue.
        /// </summary>
        /// <returns></returns>
        bool Revert();
    }
}