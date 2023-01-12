#region copyright

// (c) Copyright 2011-2023 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

#region using

using Microsoft.VisualStudio.TestTools.UnitTesting;

#endregion

namespace PCG_Tools_Unittests
{
    [TestClass]
    public class AntiCrashTestsMicroKorgXlPlus : AntiCrashTests
    {
        [TestMethod]
        public void Test_MicroKorgXlPlus_KorgUSA_MicroKORGXL_bank_mkxl_all()
        {
            TestAll(@"Synths Racks and Modules\MicroKorgXlPlus\KorgUSA_MicroKORGXL_bank.mkxl_all");
        }
    }
}