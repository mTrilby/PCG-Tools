#region copyright

// (c) Copyright 2011-2023 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

#region using

using Domain.Common.Commands;
using Domain.Common.Synth.DrumTrack;
using Domain.Common.Synth.Meta;
using Domain.Common.Synth.OldParameters;
using Domain.Common.Synth.PatchInterfaces;

#endregion

namespace Domain.Common.Synth.PatchCombis
{
    /// <summary>
    /// </summary>
    public interface ICombi : IPatch, ICategoriesNamable, IArtistable, ICompleteInPcgable, IReferencable,
        IDrumTrackReference
    {
        /// <summary>
        /// </summary>
        Timbres Timbres { get; }

        /// <summary>
        ///     Switches two MIDI channels (of all timbres if they are enabled).
        /// </summary>
        /// <param name="mainMidiChannel"></param>
        /// <param name="secondaryMidiChannel"></param>
        void SwitchMidiChannels(int mainMidiChannel, int secondaryMidiChannel);

        /// <summary>
        ///     Returns true if at least one timbre uses the specified MIDI channel and is used.
        /// </summary>
        /// <param name="secondaryMidiChannel"></param>
        /// <returns></returns>
        bool UsesMidiChannel(int secondaryMidiChannel);

        /// <summary>
        ///     Init as MIDI MPE command.
        /// </summary>
        void InitAsMpe();

        /// <summary>
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        IParameter GetParam(ParameterNames.CombiParameterName name);

        /// <summary>
        ///     Minimum volume of all (used) timbres
        /// </summary>
        /// <returns></returns>
        int GetMinimumVolume();

        /// <summary>
        ///     Maximum volume of all (used) timbres
        /// </summary>
        /// <returns></returns>
        int GetMaximumVolume();

        /// <summary>
        /// </summary>
        /// <param name="parameters"></param>
        /// <param name="minimumVolume"></param>
        /// <param name="maximumVolume"></param>
        void ChangeVolume(ChangeVolumeParameters parameters, int minimumVolume, int maximumVolume);
    }
}