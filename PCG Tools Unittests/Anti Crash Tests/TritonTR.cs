#region copyright

// (c) Copyright 2011-2023 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

#region using

using Microsoft.VisualStudio.TestTools.UnitTesting;

#endregion

namespace PCG_Tools_Unittests
{
    [TestClass]
    public class AntiCrashTestsTritonTr : AntiCrashTests
    {
        [TestMethod]
        public void Test_TritonTr_PRELOAD_PCG()
        {
            TestAll(@"Workstations\TritonTr\PRELOAD.PCG");
        }
    }
}