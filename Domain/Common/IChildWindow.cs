#region copyright

// (c) Copyright 2011-2023 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

#region using

using Domain.Common.Synth.MemoryAndFactory;

#endregion

namespace Domain.Common
{
    /// <summary>
    /// </summary>
    public interface IChildWindow
    {
        /// <summary>
        /// </summary>
        IMemory Memory { get; }

        /// <summary>
        /// </summary>
        IViewModel ViewModel { get; }

        /// <summary>
        ///     When settings are changed, this is called.
        /// </summary>
        /// <param name="property"></param>
        void ActOnSettingsChanged(string property);
    }
}