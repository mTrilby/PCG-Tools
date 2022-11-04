#region copyright

// (c) Copyright 2011-2022 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

using PcgTools.Model.Common.Synth.MemoryAndFactory;
using PcgTools.Model.Common.Synth.PatchSetLists;

namespace PcgTools.Model.KronosSpecific.Synth
{
    /// <summary>
    /// </summary>
    public class KronosSetLists : SetLists
    {
        /// <summary>
        /// </summary>
        /// <param name="pcgMemory"></param>
        public KronosSetLists(IPcgMemory pcgMemory)
            : base(pcgMemory)
        {
        }

        /// <summary>
        /// </summary>
        private static int NrOfSetLists => 128;


        /// <summary>
        /// </summary>
        protected override void CreateSetLists()
        {
            for (var n = 0; n < NrOfSetLists; n++)
            {
                Add(new KronosSetList(this, n));
            }
        }
    }
}