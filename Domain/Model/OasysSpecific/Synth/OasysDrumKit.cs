using Domain.MasterFiles;
using Domain.Model.Common.Synth.PatchDrumKits;
using Domain.Model.KronosOasysSpecific.Synth;

// (c) 2011 Michel Keijzers

namespace Domain.Model.OasysSpecific.Synth
{
    /// <summary>
    /// 
    /// </summary>
    public class OasysDrumKit : KronosOasysDrumKit
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="drumKitBank"></param>
        /// <param name="index"></param>
        public OasysDrumKit(IDrumKitBank drumKitBank, int index)
            : base(drumKitBank, index)
        {
        }


        /// <summary>
        /// Sets parameters after initialization.
        /// </summary>
        public override void SetParameters()
        {
        }
    }
}