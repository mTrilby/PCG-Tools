#region copyright

// (c) Copyright 2011-2023 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

#region using

using System.Collections.Generic;
using System.Linq;
using Common.PcgToolsResources;
using PcgTools.Mvvm;

#endregion

namespace PcgTools.Model.Common.Synth.MemoryAndFactory
{
    /// <summary>
    /// </summary>
    public class Models : ObservableCollectionEx<Model>
    {
        /// <summary>
        /// </summary>
        public enum EModelType
        {
            Kronos,
            Oasys,
            M1,
            M3,
            M3R,
            M50,
            MicroKorgXl, // (mkxl_all)
            MicroKorgXlPlus, // (mkxlp_prog, mkxlp_all)
            MicroStation,
            Ms2000, // (prg)
            Krome,
            KromeEx,
            Kross,
            Kross2,
            TritonExtreme,
            TritonTrClassicStudioRack,
            TritonLe,
            TritonKarma,
            Trinity,

            // ReSharper disable once InconsistentNaming
            TSeries,
            XSeries,
            Z1,
            ZeroSeries, // 01/W etc
            Zero3Rw // 03R/W
        }

        /// <summary>
        /// </summary>
        public enum EOsVersion
        {
            // ReSharper disable InconsistentNaming
            EOsVersionKronos10_11,
            EOsVersionKronos15_16,
            EOsVersionKronos2x,
            EOsVersionKronos3x,
            EOsVersionOasys,

            EOsVersionKrome,
            EOsVersionKromeEx,

            EOsVersionKross,
            EOsVersionKross2,

            EOsVersionM1,

            EOsVersionM3_1X,
            EOsVersionM3_20,

            EOsVersionM3R,

            EOsVersionM50,

            EOsVersionMicroStation,

            EOsVersionMicroKorgXl,
            EOsVersionMicroKorgXlPlus,

            EOsVersionMs2000,

            EOsVersionTritonExtreme,
            EOsVersionTritonTrClassicStudioRack,
            EOsVersionTritonKarma,
            EOsVersionTritonLe,

            EOsVersionTrinityV2, // Solo: S Bank
            EOsVersionTrinityV3, // Moss: M Bank

            EOsVersionTSeries,

            EOsVersionXSeries,

            EOsVersionZ1,

            EOsVersionZeroSeries, // 01W etc

            EosVersionZero3Rw // 03R/W
            // ReSharper restore InconsistentNaming
        }

        /// <summary>
        /// </summary>
        private static Models _instance;

        /// <summary>
        ///     Singleton.
        /// </summary>
        private Models()
        {
            Fill();
        }

        /// <summary>
        /// </summary>
        private static IEnumerable<Model> Instance => _instance ?? (_instance = new Models());

        /// <summary>
        /// </summary>
        private void Fill()
        {
            Add(new Model(EModelType.Kronos, EOsVersion.EOsVersionKronos10_11, Strings.Version1011));
            Add(new Model(EModelType.Kronos, EOsVersion.EOsVersionKronos15_16, Strings.Version1516));
            Add(new Model(EModelType.Kronos, EOsVersion.EOsVersionKronos2x, Strings.Version2x));
            Add(new Model(EModelType.Kronos, EOsVersion.EOsVersionKronos3x, Strings.Version3x));

            Add(new Model(EModelType.Oasys, EOsVersion.EOsVersionOasys, string.Empty));

            Add(new Model(EModelType.Krome, EOsVersion.EOsVersionKrome, string.Empty));
            Add(new Model(EModelType.KromeEx, EOsVersion.EOsVersionKromeEx, string.Empty));

            Add(new Model(EModelType.Kross, EOsVersion.EOsVersionKross, string.Empty));
            Add(new Model(EModelType.Kross2, EOsVersion.EOsVersionKross2, string.Empty));

            Add(new Model(EModelType.M1, EOsVersion.EOsVersionM1, string.Empty));
            Add(new Model(EModelType.M3, EOsVersion.EOsVersionM3_1X, Strings.Version1x));
            Add(new Model(EModelType.M3, EOsVersion.EOsVersionM3_20, Strings.Version1x));
            Add(new Model(EModelType.M3R, EOsVersion.EOsVersionM3R, string.Empty));

            Add(new Model(EModelType.M50, EOsVersion.EOsVersionM50, string.Empty));

            Add(new Model(EModelType.Ms2000, EOsVersion.EOsVersionMs2000, string.Empty));

            Add(new Model(EModelType.MicroKorgXl, EOsVersion.EOsVersionMicroKorgXl, string.Empty));
            Add(new Model(EModelType.MicroKorgXlPlus, EOsVersion.EOsVersionMicroKorgXlPlus, string.Empty));

            Add(new Model(EModelType.MicroStation, EOsVersion.EOsVersionMicroStation, string.Empty));

            Add(new Model(EModelType.TritonExtreme, EOsVersion.EOsVersionTritonExtreme, string.Empty));
            Add(new Model(EModelType.TritonTrClassicStudioRack, EOsVersion.EOsVersionTritonTrClassicStudioRack,
                string.Empty));
            Add(new Model(EModelType.TritonKarma, EOsVersion.EOsVersionTritonKarma, string.Empty));
            Add(new Model(EModelType.TritonLe, EOsVersion.EOsVersionTritonLe, string.Empty));
            Add(new Model(EModelType.Trinity, EOsVersion.EOsVersionTrinityV2, Strings.VersionV2));

            Add(new Model(EModelType.Trinity, EOsVersion.EOsVersionTrinityV3, Strings.VersionV3));

            Add(new Model(EModelType.TSeries, EOsVersion.EOsVersionTSeries, string.Empty));

            Add(new Model(EModelType.Z1, EOsVersion.EOsVersionZ1, string.Empty));

            Add(new Model(EModelType.ZeroSeries, EOsVersion.EOsVersionZeroSeries, string.Empty));
            Add(new Model(EModelType.Zero3Rw, EOsVersion.EosVersionZero3Rw, string.Empty));
        }

        /// <summary>
        /// </summary>
        /// <param name="osVersion"></param>
        /// <returns></returns>
        public static Model Find(EOsVersion osVersion)
        {
            return Instance.First(model => model.OsVersion == osVersion);
        }
    }
}