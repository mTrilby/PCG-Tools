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
    public class Regions : IRegions
    {
        /// <summary>
        /// </summary>
        public Regions()
        {
            RegionsCollection = new List<IRegion>();
        }

        /// <summary>
        /// </summary>
        public List<IRegion> RegionsCollection { get; }
    }
}