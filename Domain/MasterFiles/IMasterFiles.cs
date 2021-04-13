using Domain.Model.Common.Synth.MemoryAndFactory;

namespace Domain.MasterFiles
{
    public interface IMasterFiles
    {
        IPcgMemory FindMasterPcg(IModel model);

        IMasterFile FindMasterFile(IModel model);
    }
}