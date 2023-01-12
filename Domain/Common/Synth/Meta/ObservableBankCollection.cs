#region copyright

// (c) Copyright 2011-2023 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

#region using

using Common.MVVM;

#endregion

namespace Domain.Common.Synth.Meta
{
    /// <summary>
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class ObservableBankCollection<T> : ObservableCollectionEx<T>, IObservableBankCollection<T> where T : IBank
    {
    }
}