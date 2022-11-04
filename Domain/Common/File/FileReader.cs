#region copyright

// (c) Copyright 2011-2022 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

namespace PcgTools.Model.Common.File
{
    /// <summary>
    /// </summary>
    public abstract class FileReader
    {
        /// <summary>
        ///     Byte offset where timbres start.
        /// </summary>
        protected virtual int TimbresByteOffset => -1;
    }
}