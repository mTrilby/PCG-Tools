#region copyright

// (c) Copyright 2011-2022 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

using Domain.Common;
using Domain.Common.Synth.Meta;
using Domain.Common.Synth.PatchSetLists;

namespace Domain.KronosSpecific.Synth
{
    /// <summary>
    /// </summary>
    public class KronosSetList : SetList
    {
        /// <summary>
        /// </summary>
        /// <param name="setLists"></param>
        /// <param name="index"></param>
        public KronosSetList(SetLists setLists, int index)
            : base(setLists, BankType.EType.Int, index, -1)
        {
        }


        // Name

        /// <summary>
        /// </summary>
        public override string Name
        {
            get => Util.GetChars(Root.Content, ByteOffset, MaxNameLength);

            set
            {
                if (Name != value)
                {
                    Util.SetChars(PcgRoot, Root.Content, ByteOffset, MaxNameLength, value);
                    OnPropertyChanged("", false);
                }
            }
        }


        /// <summary>
        /// </summary>
        /// <param name="index"></param>
        public override void CreatePatch(int index)
        {
            Add(new KronosSetListSlot(this, index));
        }
    }
}