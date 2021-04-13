// (c) 2011 Michel Keijzers

using Domain.Model.Common.Synth.PatchWaveSequences;

namespace Domain.Model.KronosOasysSpecific.Synth
{
    /// <summary>
    /// 
    /// </summary>
    public abstract class KronosOasysWaveSequence : WaveSequence
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="waveSeqBank"></param>
        /// <param name="index"></param>
        protected KronosOasysWaveSequence(IWaveSequenceBank waveSeqBank, int index)
            : base(waveSeqBank, index) 
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
        public override int MaxNameLength => 24;


        /// <summary>
        /// 
        /// </summary>
        public override bool IsEmptyOrInit => ((Name == string.Empty) ||
                                               (Name == "WaveSequence")) ||
                                              ((Name.Contains("Init") && Name.Contains("Wave") && Name.Contains("Sequence")));
    }
}
