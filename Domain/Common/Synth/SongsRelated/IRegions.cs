#region copyright

// (c) Copyright 2011-2022 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

using System.Collections.Generic;

namespace PcgTools.Model.Common.Synth.SongsRelated
{
    /// <summary>
    /// </summary>
    public interface IRegions
    {
        /// <summary>
        /// </summary>
        List<IRegion> RegionsCollection { get; }
    }
}