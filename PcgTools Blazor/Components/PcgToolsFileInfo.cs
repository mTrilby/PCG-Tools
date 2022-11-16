#region copyright
// (c) Copyright 2011-2022 MiKeSoft, Michel Keijzers, All rights reserved
#endregion

namespace PcgTools_Blazor.Components;

public class PcgToolsFileInfo
{
    public string Name { get; set; }
    public long Size { get; set; }
    public byte[] Content { get; set; }
    public string LastModified { get; set; }
    public string Info { get; set; }
}