#region copyright

// (c) Copyright 2011-2023 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

namespace PcgTools.ViewModels.ParameterChange
{
    public class ParameterChangeSettings
    {
        /// <summary>
        /// </summary>
        public enum EChangeType
        {
            AbsoluteValue,
            RelativeValue,
            Percentage
        }

        /// <summary>
        /// </summary>
        public EChangeType ChangeType { get; set; }
    }
}