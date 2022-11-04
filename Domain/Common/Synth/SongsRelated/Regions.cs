#region copyright

// (c) Copyright 2011-2022 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

using System.Collections.Generic;

namespace Domain.Common.Synth.SongsRelated
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