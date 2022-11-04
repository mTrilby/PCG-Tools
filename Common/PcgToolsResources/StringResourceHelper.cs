#region copyright

// (c) Copyright 2011-2022 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

using Common.PcgToolsResources;

namespace PcgTools.PcgToolsResources
{
    /// <summary>
    /// </summary>
    public static class StringResourceHelper
    {
        /// <summary>
        ///     Do not remove, although 0 references are mentioned, this method takes care of the
        ///     resource regeneration problem, making a default public instead of internal constructor.
        ///     There is also another method copied in the App.xaml.cs.
        /// </summary>
        /// <returns></returns>
        // ReSharper disable once UnusedMember.Global
        public static Strings GetStringResources()
        {
            return new Strings();
        }
    }
}