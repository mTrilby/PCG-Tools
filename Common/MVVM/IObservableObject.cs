#region copyright

// (c) Copyright 2011-2022 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

using System.ComponentModel;

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