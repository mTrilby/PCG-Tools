#region copyright

// (c) Copyright 2011-2023 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

#region using

using System.Diagnostics;
using Common.Utils;
using Domain.Common.Synth.MemoryAndFactory;
using Domain.Common.Synth.Meta;

#endregion

namespace Domain.Common.Synth.OldParameters
{
    /// <summary>
    /// </summary>
    public class BoolParameter : Parameter
    {
        /// <summary>
        /// </summary>
        private static BoolParameter _instance;

        /// <summary>
        /// </summary>
        private int _bit;

        /// <summary>
        /// </summary>
        public static BoolParameter Instance => _instance ?? (_instance = new BoolParameter());

        /// <summary>
        /// </summary>
        public override dynamic Value
        {
            get => BitsUtil.GetBit(PcgData, PcgOffset, _bit);

            set
            {
                Debug.Assert(PcgData != null);
                PcgMemory.IsDirty |= BitsUtil.SetBit(PcgData, PcgOffset, _bit, value);
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
        /// <param name="bit"></param>
        /// <param name="patch"></param>
        /// <returns></returns>
        public BoolParameter Set(IMemory memory, byte[] pcgData, int pcgOffset, int bit, IPatch patch)
        {
            Set(memory, pcgData, pcgOffset, patch);
            _bit = bit;

            return this;
        }
    }
}