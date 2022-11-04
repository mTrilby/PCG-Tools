#region copyright

// (c) Copyright 2011-2022 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

using System.Diagnostics;
using Domain.Common.Synth.MemoryAndFactory;
using Domain.Common.Synth.Meta;

namespace Domain.Common.Synth.OldParameters
{
    /// <summary>
    /// </summary>
    public class WordParameter : Parameter
    {
        /// <summary>
        /// </summary>
        private static WordParameter _instance;


        /// <summary>
        /// </summary>
        private int _multiplication;


        /// <summary>
        ///     True if Little endian, false if Big endian.
        /// </summary>
        private bool _reverseOrder;


        /// <summary>
        /// </summary>
        public static WordParameter Instance => _instance ?? (_instance = new WordParameter());


        /// <summary>
        ///     Order is low byte - high byte.
        /// </summary>
        public override dynamic Value
        {
            get
            {
                var value = _reverseOrder
                    ? PcgData[PcgOffset + 1] * 256 + PcgData[PcgOffset]
                    : PcgData[PcgOffset] * 256 + PcgData[PcgOffset + 1];

                return value / _multiplication;
            }

            set
            {
                Debug.Assert(PcgData != null);
                var val = (int)(value * _multiplication);

                if (_reverseOrder)
                {
                    PcgMemory.IsDirty |= val != PcgData[PcgOffset] + PcgData[PcgOffset + 1] * 256;
                    PcgData[PcgOffset] = (byte)(val % 256);
                    PcgData[PcgOffset + 1] = (byte)(val / 256);
                }
                else
                {
                    PcgMemory.IsDirty |= val != PcgData[PcgOffset] * 256 + PcgData[PcgOffset + 1];
                    PcgData[PcgOffset] = (byte)(val / 256);
                    PcgData[PcgOffset + 1] = (byte)(val % 256);
                }
            }
        }


        /// <summary>
        /// </summary>
        /// <param name="memory"></param>
        /// <param name="pcgData"></param>
        /// <param name="pcgOffset"></param>
        /// <param name="reverseOrder"></param>
        /// <param name="multiplication"></param>
        /// <param name="patch"></param>
        /// <returns></returns>
        public WordParameter Set(IMemory memory, byte[] pcgData, int pcgOffset, bool reverseOrder, int multiplication,
            IPatch patch)
        {
            Set(memory, pcgData, pcgOffset, patch);
            _multiplication = multiplication;
            _reverseOrder = reverseOrder;

            return this;
        }
    }
}