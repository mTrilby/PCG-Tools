// (c) Copyright 2011-2019 MiKeSoft, Michel Keijzers, All rights reserved

using System.Collections.Generic;
using Domain.Model.Common.Synth.Meta;
using Domain.Model.Common.Synth.PatchInterfaces;

namespace Domain.Model.Common.Synth.Global
{
    /// <summary>
    /// 
    /// </summary>
    public interface IGlobal : ILocatable
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="patch"></param>
        /// <returns></returns>
        string GetCategoryName(IPatch patch);


        /// <summary>
        /// 
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        List<string> GetCategoryNames(GlobalECategoryType type);


        /// <summary>
        /// 
        /// </summary>
        /// <param name="patch"></param>
        /// <returns></returns>
        string GetSubCategoryName(IPatch patch);


        /// <summary>
        /// 
        /// </summary>
        /// <param name="type"></param>
        /// <param name="category"></param>
        /// <returns></returns>
        LinkedList<string> GetSubCategoryNames(GlobalECategoryType type, int category);

    }
}
