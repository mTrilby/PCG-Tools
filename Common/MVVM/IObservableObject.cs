#region copyright

// (c) Copyright 2011-2023 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

#region using

using System.ComponentModel;

#endregion

namespace Common.MVVM
{
    /// <summary>
    /// </summary>
    public interface IObservableObject : INotifyPropertyChanged
    {
        /// <summary>
        /// </summary>
        /// <param name="propertyName"></param>
        /// <param name="verifyPropertyName"></param>
        void RaisePropertyChanged(string propertyName, bool verifyPropertyName = true);
    }
}