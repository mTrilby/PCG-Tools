// (c) Copyright 2011-2019 MiKeSoft, Michel Keijzers, All rights reserved

using Common.Mvvm;
using Domain.Model.Common.Synth.PatchInterfaces;

namespace Domain.Model.Common.Synth.PatchCombis
{
    /// <summary>
    /// 
    /// </summary>
    public interface ITimbres : INavigable
    {
        /// <summary>
        /// 
        /// </summary>
        ObservableCollectionEx<ITimbre> TimbresCollection { get; }



        /// <summary>
        /// 
        /// </summary>
        int ByteOffset { get; set; }
    }
}
