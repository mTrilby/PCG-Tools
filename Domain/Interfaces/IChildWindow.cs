// (c) Copyright 2011-2019 MiKeSoft, Michel Keijzers, All rights reserved


using Common.Windows;
using Domain.Model.Common.Synth.MemoryAndFactory;

namespace Domain.Interfaces
{
    /// <summary>
    /// 
    /// </summary>
    public interface IChildWindow
    {
        /// <summary>
        /// 
        /// </summary>
        IMdiChild MdiChild { set; }


        /// <summary>
        /// 
        /// </summary>
        IMemory Memory { get; }


        /// <summary>
        /// 
        /// </summary>
        IViewModel ViewModel { get; }


        /// <summary>
        /// When settings are changed, this is called.
        /// </summary>
        /// <param name="property"></param>
        void ActOnSettingsChanged(string property);
    }
}
