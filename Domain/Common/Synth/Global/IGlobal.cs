#region copyright

// (c) Copyright 2011-2022 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

using System.Collections.Generic;
using Domain.Common.Synth.Meta;
using Domain.Common.Synth.PatchInterfaces;

namespace Domain.Common.Synth.Global
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