﻿#region copyright

// (c) Copyright 2011-2023 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

namespace Domain.Common.Synth.PatchInterfaces
{
    /// <summary>
    /// </summary>
    public interface INamable
    {
        /// <summary>
        /// </summary>
        string Name { get; set; }

        /// <summary>
        /// </summary>
        int MaxNameLength { get; }

        /// <summary>
        /// </summary>
        /// <param name="strName"></param>
        /// <returns></returns>
        bool IsNameLike(string strName);

        /// <summary>
        ///     Changes the suffix of the name.
        /// </summary>
        /// <param name="suffix"></param>
        /// <returns></returns>
        void SetNameSuffix(string suffix);
    }
}