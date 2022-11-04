#region copyright

// (c) Copyright 2011-2022 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

using System.Collections.Generic;
using System.Diagnostics;
using Common.Utils;
using Domain.Common.Synth.MemoryAndFactory;
using Domain.Common.Synth.Meta;

namespace Domain.Common.Synth.OldParameters
{
    /// <summary>
    /// </summary>
    public class EnumParameter : Parameter
    {
        /// <summary>
        /// </summary>
        private static EnumParameter _instance;


        /// <summary>
        /// </summary>
        private List<string> _enumValues;

        /// <summary>
        /// </summary>
        private int _highBit;


        /// <summary>
        /// </summary>
        private int _lowBit;


        /// <summary>
        /// </summary>
        public static EnumParameter Instance => _instance ?? (_instance = new EnumParameter());


        /// <summary>
        /// </summary>
        public override dynamic Value
        {
            get => _enumValues[BitsUtil.GetBits(PcgData, PcgOffset, _highBit, _lowBit)];

            set
            {
                Debug.Assert(PcgData != null);
                PcgMemory.IsDirty |=
                    BitsUtil.SetBits(PcgData, PcgOffset, _highBit, _lowBit, _enumValues.IndexOf(value));
                if (Patch != null)
                {
                    Patch.RaisePropertyChanged(string.Empty, false);
                }
            }
        }


        /// <summary>
        /// </summary>
        /// <param name="memory"></param>
        /// <param name="pcgData"></param>
        /// <param name="pcgOffset"></param>
        /// <param name="highBit"></param>
        /// <param name="lowBit"></param>
        /// <param name="enumValues"></param>
        /// <param name="patch"></param>
        /// <returns></returns>
        public EnumParameter Set(IMemory memory, byte[] pcgData, int pcgOffset, int highBit, int lowBit,
            List<string> enumValues, IPatch patch)
        {
            Set(memory, pcgData, pcgOffset, patch);

            _highBit = highBit;
            _lowBit = lowBit;
            _enumValues = enumValues;

            return this;
        }
    }
}