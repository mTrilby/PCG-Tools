﻿#region copyright

// (c) Copyright 2011-2023 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

#region using

using Microsoft.VisualStudio.TestTools.UnitTesting;

#endregion

namespace PcgTools__UnitTests.Anti_Crash_Tests
{
    [TestClass]
    public class AntiCrashTestsKromeEx : AntiCrashTests
    {
        [TestMethod]
        public void Test_KromeEx_EX08AGO_PCG()
        {
            TestAll(@"Workstations\KromeEx\EX08AGO.PCG");
        }

        [TestMethod]
        public void Test_KromeEx_MSIZ_PCG()
        {
            TestAll(@"Workstations\KromeEx\MSIZ.PCG");
        }
    }
}