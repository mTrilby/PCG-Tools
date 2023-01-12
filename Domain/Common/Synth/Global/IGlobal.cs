#region copyright

// (c) Copyright 2011-2023 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

#region using

using System.Collections.Generic;
using PcgTools.Model.Common.Synth.Meta;
using PcgTools.Model.Common.Synth.PatchInterfaces;

#endregion

namespace PcgTools.Model.Common.Synth.Global
{
    /// <summary>
    /// </summary>
    public interface IGlobal : ILocatable
    {
        /// <summary>
        /// </summary>
        /// <param name="patch"></param>
        /// <returns></returns>
        string GetCategoryName(IPatch patch);

        /// <summary>
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        List<string> GetCategoryNames(Global.ECategoryType type);

        /// <summary>
        /// </summary>
        /// <param name="patch"></param>
        /// <returns></returns>
        string GetSubCategoryName(IPatch patch);

        /// <summary>
        /// </summary>
        /// <param name="type"></param>
        /// <param name="category"></param>
        /// <returns></returns>
        LinkedList<string> GetSubCategoryNames(Global.ECategoryType type, int category);
    }
}