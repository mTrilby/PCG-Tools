#region copyright

// (c) Copyright 2011-2022 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

using Common.Properties;

namespace PcgTools.Help
{
    public class ExternalItem
    {
        /// <summary>
        /// </summary>
        private string _bitmapPath;

        /// <summary>
        /// </summary>
        public string Name { get; set; }


        /// <summary>
        /// </summary>
        public string Description { get; set; }


        /// <summary>
        /// </summary>
        public string Url { get; set; }

        /// <summary>
        /// </summary>
        public string BitmapPath
        {
            [UsedImplicitly] get => _bitmapPath;
            set => _bitmapPath = "/PcgTools;component/Help/External Links/" + value;
        }
    }
}