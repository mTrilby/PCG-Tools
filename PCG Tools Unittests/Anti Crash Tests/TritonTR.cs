#region copyright

// (c) Copyright 2011-2022 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PcgTools__UnitTests.Anti_Crash_Tests
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