#region copyright

// (c) Copyright 2011-2023 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

#region using

using Microsoft.VisualStudio.TestTools.UnitTesting;

#endregion

namespace PcgTools__UnitTests.Anti_Crash_Tests
{
    [TestClass]
    public class AntiCrashTestsKross2 : AntiCrashTests
    {
        [TestMethod]
        public void Test_Kross2_newfile_pcg()
        {
            TestAll(@"Workstations\Kross2\NEWFILE.PCG");
        }
    }
}