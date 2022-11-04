#region copyright

// (c) Copyright 2011-2022 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

namespace PcgTools.ViewModels.Commands.PcgCommands
{
    public class ChangeVolumeParameters
    {
        /// <summary>
        /// </summary>
        public enum EChangeType
        {
            Fixed,
            Relative,
            Percentage,
            Mapped,
            SmartMapped
        }


        /// <summary>
        /// </summary>
        public EChangeType ChangeType { get; set; }


        /// <summary>
        /// </summary>
        public int Value { get; set; }

        /// <summary>
        ///     Only used for mapped (to) value.
        /// </summary>
        public int ToValue { get; set; }
    }
}