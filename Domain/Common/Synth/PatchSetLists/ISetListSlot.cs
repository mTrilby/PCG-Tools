#region copyright

// (c) Copyright 2011-2023 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

#region using

using Domain.Common.Commands;
using Domain.Common.Synth.Meta;
using Domain.Common.Synth.NewParameters;
using Domain.Common.Synth.OldParameters;
using Domain.Common.Synth.PatchInterfaces;

#endregion

namespace Domain.Common.Synth.PatchSetLists
{
    /// <summary>
    /// </summary>
    public interface ISetListSlot : IPatch, IArtistable, ICompleteInPcgable, IReferencable
    {
        /// <summary>
        /// </summary>
        IPatch UsedPatch { get; set; }

        /// <summary>
        /// </summary>
        SetListSlot.PatchType SelectedPatchType { get; set; }

        /// <summary>
        /// </summary>
        string Description { get; set; }

        /// <summary>
        /// </summary>
        string DescriptionInList { get; }

        /// <summary>
        /// </summary>
        int Volume { get; set; }

        /// <summary>
        /// </summary>
        int MaxDescriptionLength { get; }

        /// <summary>
        /// </summary>
        SetListSlot.TextSize SelectedTextSize { get; set; }

        /// <summary>
        /// </summary>
        IIntParameter Color { get; }

        /// <summary>
        /// </summary>
        int Transpose { get; set; }

        /// <summary>
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        IParameter GetParam(ParameterNames.SetListSlotParameterName name);

        /// <summary>
        /// </summary>
        /// <param name="parameters"></param>
        /// <param name="minimumVolume"></param>
        /// <param name="maximumVolume"></param>
        void ChangeVolume(ChangeVolumeParameters parameters, int minimumValue, int maximumValue);
    }
}