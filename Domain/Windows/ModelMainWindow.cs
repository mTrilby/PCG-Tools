using Domain.Model.Common.File;
using Domain.Model.Common.Synth.MemoryAndFactory;
using Domain.PcgToolsResources;

namespace Domain.Windows
{
    public class ModelMainWindow
    {
        public string Title => $"{Strings.PcgTools} {Version}  {Copyright}";

        public string Version => "3.1.0";

        public string Copyright => $"©2011 - {CurrentYear} {Author}";

        public string Author => "Michel Keijzers";

        public int CurrentYear => 2021;

        public string OpenFileName { get; set; }
        
        public IMemory SelectedMemory { get; set; }
        
        public void SaveFile()
        {
            // TODO: Save file
        }

        public void SaveFileAs()
        {
            // TODO: Save file as
        }
    }
}