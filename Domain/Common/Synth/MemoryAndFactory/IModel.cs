#region copyright

// (c) Copyright 2011-2023 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

namespace Domain.Common.Synth.MemoryAndFactory
{
    /// <summary>
    /// </summary>
    public interface IModel
    {
        /// <summary>
        /// </summary>
        Models.EOsVersion OsVersion { get; }

        /// <summary>
        /// </summary>
        Models.EModelType ModelType { get; }

        /// <summary>
        /// </summary>
        string OsVersionString { get; }

        /// <summary>
        /// </summary>
        string ModelAsString { get; }

        string ModelAndVersionAsString { get; }
    }
}