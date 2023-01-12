#region copyright

// (c) Copyright 2011-2023 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

#region using

using System.ComponentModel;
using Domain.Common.Synth.PatchInterfaces;

#endregion

namespace Domain.Common.Synth.Meta
{
    /// <summary>
    /// </summary>
    public interface IBanks : ILocatable, INavigable, ICountable, IFillable, INotifyPropertyChanged
    {
        /// <summary>
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        IBank this[int index] { get; }

        /// <summary>
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        IBank this[string id] { get; }

        /// <summary>
        /// </summary>
        IObservableBankCollection<IBank> BankCollection { get; }

        /// <summary>
        /// </summary>
        int CountFilledBanks { get; }

        /// <summary>
        /// </summary>
        /// <param name="pcgId"></param>
        /// <returns></returns>
        IBank GetBankWithPcgId(int pcgId);

        /// <summary>
        /// </summary>
        /// <param name="bank"></param>
        /// <returns></returns>
        int IndexOfBank(IBank bank);
    }
}