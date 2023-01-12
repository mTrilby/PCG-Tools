#region copyright

// (c) Copyright 2011-2023 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

namespace PcgTools.Common.Utils
{
    public static class WindowUtil
    {
        /// <summary>
        /// </summary>
        public enum ECursor
        {
            Wait,
            Arrow
        }

        /// <summary>
        /// </summary>
        public enum EMessageBoxButton
        {
            Ok,
            YesNo,
            YesNoCancel
        }

        /// <summary>
        /// </summary>
        public enum EMessageBoxImage
        {
            Error,
            Warning,
            Exclamation,
            Information
        }

        /// <summary>
        /// </summary>
        public enum EMessageBoxResult
        {
            Ok,
            Yes,
            No,
            None,
            Cancel
        }
    }
}