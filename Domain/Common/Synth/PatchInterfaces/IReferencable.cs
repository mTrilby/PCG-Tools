#region copyright

// (c) Copyright 2011-2023 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

#region using

using PcgTools.Model.Common.Synth.Meta;

#endregion

namespace PcgTools.Model.Common.Synth.PatchInterfaces
{
    /// <summary>
    /// </summary>
    public interface IReferencable
    {
        /// <summary>
        /// </summary>
        int NumberOfReferences { get; }

        /// <summary>
        ///     Change references from combis/set list slots to patch, towards newPatch.
        /// </summary>
        /// <param name="newPatch"></param>
        void ChangeReferences(IPatch newPatch);
    }
}