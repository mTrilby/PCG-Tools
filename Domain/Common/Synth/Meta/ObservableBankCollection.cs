#region copyright

// (c) Copyright 2011-2022 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

using PcgTools.Mvvm;

namespace PcgTools.Model.Common.Synth.Meta
{
    /// <summary>
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class ObservableBankCollection<T> : ObservableCollectionEx<T>, IObservableBankCollection<T> where T : IBank
    {
    }
}