using Domain.Interfaces;

namespace Domain.Windows
{
    /// <summary>
    /// 
    /// </summary>
    public interface IPcgWindow : IWindow
    {
        /// <summary>
        /// 
        /// </summary>
        IViewModel ViewModel { get; }
    }
}
