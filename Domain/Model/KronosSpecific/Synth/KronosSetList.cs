// (c) Copyright 2011-2019 MiKeSoft, Michel Keijzers, All rights reserved

using Domain.MasterFiles;
using Domain.Model.Common;
using Domain.Model.Common.Synth.Meta;
using Domain.Model.Common.Synth.PatchSetLists;

namespace Domain.Model.KronosSpecific.Synth
{
    /// <summary>
    /// 
    /// </summary>
    public class KronosSetList : SetList
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="setLists"></param>
        /// <param name="index"></param>
        public KronosSetList(SetLists setLists, int index)
            : base(setLists, BankTypeEType.Int, index, -1)
        {
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="index"></param>
        public override void CreatePatch(int index)
        {
            Add(new KronosSetListSlot(this, index));
        }

        
        // Name

        /// <summary>
        /// 
        /// </summary>
        public override string Name
        {
            get { return Util.GetChars(Root.Content, ByteOffset, MaxNameLength); }

            set
            {
                if (Name != value)
                {
                    Util.SetChars(PcgRoot, Root.Content, ByteOffset, MaxNameLength, value);
                    OnPropertyChanged("", false);
                }
            }
        }
    }
}
