using System.Text.RegularExpressions;
using Domain.MasterFiles;
using Domain.Model.Common.Synth.PatchDrumKits; // (c) 2011 Michel Keijzers

namespace Domain.Model.TrinitySpecific.Synth
{
    /// <summary>
    /// 
    /// </summary>
    public class TrinityDrumKit : DrumKit
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="drumKitBank"></param>
        /// <param name="index"></param>
        public TrinityDrumKit(IDrumKitBank drumKitBank, int index)
            : base(drumKitBank, index)
        {
        }


        /// <summary>
        /// 
        /// </summary>
        public override string Name
        {
            get
            {
                return GetChars(0, MaxNameLength);
            }
            set
            {
                if (Name != value)
                {
                    SetChars(0, MaxNameLength, value);
                    OnPropertyChanged("Name");
                }
            }
        }


        /// <summary>
        /// 
        /// </summary>
        public override int MaxNameLength => 16;


        /// <summary>
        /// 
        /// </summary>
        public override bool IsEmptyOrInit => ((Name == string.Empty) || (Name.Contains("Init") && Name.Contains("Drum") && Name.Contains("Kit")) || 
                                               (new Regex("Drumkit[0-9]*").IsMatch(Name)));


        /// <summary>
        /// Sets parameters after initialization.
        /// </summary>
        public override void SetParameters()
        {
        }
    }
}