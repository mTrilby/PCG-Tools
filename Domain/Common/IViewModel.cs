﻿#region copyright

// (c) Copyright 2011-2022 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

using System.ComponentModel;
using Domain.Common.Synth.MemoryAndFactory;

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