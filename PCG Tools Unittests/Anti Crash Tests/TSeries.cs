#region copyright

// (c) Copyright 2011-2023 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

#region using

using Microsoft.VisualStudio.TestTools.UnitTesting;

#endregion

namespace PcgTools__UnitTests.Anti_Crash_Tests
{
    [TestClass]
    public class AntiCrashTestsTSeries : AntiCrashTests
    {
        [TestMethod]
        public void Test_TSeries_1723_syx()
        {
            TestAll(@"Workstations\TSeries\1723.syx");
        }

        [TestMethod]
        public void Test_TSeries_1729_syx()
        {
            TestAll(@"Workstations\TSeries\1729.syx");
        }

        [TestMethod]
        public void Test_TSeries_t2t3pl_mid()
        {
            TestAll(@"Workstations\TSeries\t2t3pl.mid");
        }

        [TestMethod]
        public void Test_TSeries_t2t3pl_syx()
        {
            TestAll(@"Workstations\TSeries\t2t3pl.syx");
        }
    }
}