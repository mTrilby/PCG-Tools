using System.ComponentModel;

namespace PcgTools.Mvvm
{
    /// <summary>
    /// 
    /// </summary>
    public interface IObservableObject : INotifyPropertyChanged
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="propertyName"></param>
        /// <param name="verifyPropertyName"></param>
        void RaisePropertyChanged(string propertyName, bool verifyPropertyName = true);    
    }
}
