#region copyright

// (c) Copyright 2011-2022 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

using System.Collections.Generic;

namespace Domain.Common.Synth.Meta
{
    /// <summary>
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IObservableBankCollection<T> : IList<T> where T : IBank
    {
    }
}