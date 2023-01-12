#region copyright

// (c) Copyright 2011-2023 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

#region using

using Microsoft.VisualStudio.TestTools.UnitTesting;

#endregion

namespace PcgTools__UnitTests.Anti_Crash_Tests
{
    [TestClass]
    public class AntiCrashTestsKronos2 : AntiCrashTests
    {
        [TestMethod]
        public void Test_Kronos2_PRELOAD_V3_PCG()
        {
            TestAll(@"Workstations\Kronos2\PRELOAD_V3_2016-10-01-20-23-33.PCG");
        }
    }
}