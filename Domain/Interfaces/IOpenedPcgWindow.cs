using Domain.Model.Common.Synth.MemoryAndFactory;

namespace Domain.Interfaces
{
    public interface IOpenedPcgWindow
    {
        IPcgMemory PcgMemory { get; set; }
    }
}