#region copyright

// (c) Copyright 2011-2023 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

#region using

using System.Collections.Generic;

#endregion

namespace PcgTools.Model.Common.Synth.Meta
{
    /// <summary>
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IObservableBankCollection<T> : IList<T> where T : IBank
    {
    }
}