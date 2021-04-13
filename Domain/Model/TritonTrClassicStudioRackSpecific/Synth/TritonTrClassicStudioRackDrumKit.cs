using Domain.MasterFiles;
using Domain.Model.Common.Synth.PatchDrumKits;
using Domain.Model.TritonSpecific.Synth;

// (c) 2011 Michel Keijzers

namespace Domain.Model.TritonTrClassicStudioRackSpecific.Synth
{
    /// <summary>
    /// 
    /// </summary>
    public class TritonTrClassicStudioRackDrumKit : TritonDrumKit
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="drumKitBank"></param>
        /// <param name="index"></param>
        public TritonTrClassicStudioRackDrumKit(IDrumKitBank drumKitBank, int index)
            : base(drumKitBank, index)
        {
        }


        /// <summary>
        /// 
        /// </summary>
        public override void SetParameters()
        {
        }

    }
}
