#region copyright

// (c) Copyright 2011-2023 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

#region using

using System.Collections.Generic;

#endregion

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