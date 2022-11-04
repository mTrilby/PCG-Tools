#region copyright

// (c) Copyright 2011-2022 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

namespace PcgTools.Model.Common.Synth.PatchInterfaces
{
    /// <summary>
    /// </summary>
    public interface ICategoriesNamable
    {
        /// <summary>
        /// </summary>
        string CategoryAsName { get; }


        /// <summary>
        /// </summary>
        string SubCategoryAsName { get; }
    }
}