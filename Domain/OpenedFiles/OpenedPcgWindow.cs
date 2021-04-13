using Common.Mvvm;
using Domain.Interfaces;
using Domain.Model.Common.Synth.MemoryAndFactory;

namespace Domain.OpenedFiles
{
    /// <summary>
    /// 
    /// </summary>
    public class OpenedPcgWindow : ObservableObject, IOpenedPcgWindow
    {
        /// <summary>
        /// 
        /// </summary>
        private IPcgMemory _pcgMemory;


        /// <summary>
        /// 
        /// </summary>
        public IPcgMemory PcgMemory
        {
            get
            {
                return _pcgMemory;
            }

            set
            {
                if (_pcgMemory != value)
                {
                    _pcgMemory = value;
                    RaisePropertyChanged("PcgMemory");
                }
            }
        }
    }
}
