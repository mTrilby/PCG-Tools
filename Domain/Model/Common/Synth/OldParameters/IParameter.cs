// (c) Copyright 2011-2019 MiKeSoft, Michel Keijzers, All rights reserved

using Domain.Model.Common.Synth.Meta;

namespace Domain.Model.Common.Synth.OldParameters
{
    /// <summary>
    /// 
    /// </summary>
    public interface IParameter
    {
        /// <summary>
        /// 
        /// </summary>
        dynamic Value { get; set; }


        /// <summary>
        /// 
        /// </summary>
        IPatch Patch { get; }
    }
}
