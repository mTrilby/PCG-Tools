#region copyright

// (c) Copyright 2011-2022 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

using Domain.Common.Synth.Meta;

namespace Domain.Common.Synth.PatchInterfaces
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