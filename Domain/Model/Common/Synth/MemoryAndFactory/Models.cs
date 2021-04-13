using System.Collections.Generic;
using System.Linq;
using Common.Mvvm;
using Domain.PcgToolsResources;

namespace Domain.Model.Common.Synth.MemoryAndFactory
{
    /// <summary>
    ///
    /// </summary>
    public class Models : ObservableCollectionEx<Model>
    {

        /// <summary>
        /// Singleton.
        /// </summary>
        private Models()
        {
            Fill();
        }


        /// <summary>
        ///
        /// </summary>
        private static Models _instance;


        /// <summary>
        ///
        /// </summary>
        private static IEnumerable<Model> Instance => _instance ?? (_instance = new Models());


        /// <summary>
        ///
        /// </summary>
        private void Fill()
        {
            Add(new Model(ModelsEModelType.Kronos, ModelsEOsVersion.EOsVersionKronos10_11, Strings.Version1011));
            Add(new Model(ModelsEModelType.Kronos, ModelsEOsVersion.EOsVersionKronos15_16, Strings.Version1516));
            Add(new Model(ModelsEModelType.Kronos, ModelsEOsVersion.EOsVersionKronos2x, Strings.Version2x));
            Add(new Model(ModelsEModelType.Kronos, ModelsEOsVersion.EOsVersionKronos3x, Strings.Version3x));

            Add(new Model(ModelsEModelType.Oasys, ModelsEOsVersion.EOsVersionOasys, string.Empty));

            Add(new Model(ModelsEModelType.Krome, ModelsEOsVersion.EOsVersionKrome, string.Empty));
            Add(new Model(ModelsEModelType.KromeEx, ModelsEOsVersion.EOsVersionKromeEx, string.Empty));

            Add(new Model(ModelsEModelType.Kross, ModelsEOsVersion.EOsVersionKross, string.Empty));
            Add(new Model(ModelsEModelType.Kross2, ModelsEOsVersion.EOsVersionKross2, string.Empty));

            Add(new Model(ModelsEModelType.M1, ModelsEOsVersion.EOsVersionM1, string.Empty));
            Add(new Model(ModelsEModelType.M3, ModelsEOsVersion.EOsVersionM3_1X, Strings.Version1x));
            Add(new Model(ModelsEModelType.M3, ModelsEOsVersion.EOsVersionM3_20, Strings.Version1x));
            Add(new Model(ModelsEModelType.M3R, ModelsEOsVersion.EOsVersionM3R, string.Empty));

            Add(new Model(ModelsEModelType.M50, ModelsEOsVersion.EOsVersionM50, string.Empty));

            Add(new Model(ModelsEModelType.Ms2000, ModelsEOsVersion.EOsVersionMs2000, string.Empty));

            Add(new Model(ModelsEModelType.MicroKorgXl, ModelsEOsVersion.EOsVersionMicroKorgXl, string.Empty));
            Add(new Model(ModelsEModelType.MicroKorgXlPlus, ModelsEOsVersion.EOsVersionMicroKorgXlPlus, string.Empty));

            Add(new Model(ModelsEModelType.MicroStation, ModelsEOsVersion.EOsVersionMicroStation, string.Empty));

            Add(new Model(ModelsEModelType.TritonExtreme, ModelsEOsVersion.EOsVersionTritonExtreme, string.Empty));
            Add(new Model(ModelsEModelType.TritonTrClassicStudioRack, ModelsEOsVersion.EOsVersionTritonTrClassicStudioRack, string.Empty));
            Add(new Model(ModelsEModelType.TritonKarma, ModelsEOsVersion.EOsVersionTritonKarma, string.Empty));
            Add(new Model(ModelsEModelType.TritonLe, ModelsEOsVersion.EOsVersionTritonLe, string.Empty));
            Add(new Model(ModelsEModelType.Trinity, ModelsEOsVersion.EOsVersionTrinityV2, Strings.VersionV2));

            Add(new Model(ModelsEModelType.Trinity, ModelsEOsVersion.EOsVersionTrinityV3, Strings.VersionV3));

            Add(new Model(ModelsEModelType.TSeries, ModelsEOsVersion.EOsVersionTSeries, string.Empty));

            Add(new Model(ModelsEModelType.Z1, ModelsEOsVersion.EOsVersionZ1, string.Empty));

            Add(new Model(ModelsEModelType.ZeroSeries, ModelsEOsVersion.EOsVersionZeroSeries, string.Empty));
            Add(new Model(ModelsEModelType.Zero3Rw, ModelsEOsVersion.EosVersionZero3Rw, string.Empty));
        }


        /// <summary>
        ///
        /// </summary>
        /// <param name="osVersion"></param>
        /// <returns></returns>
        public static IModel Find(ModelsEOsVersion osVersion)
        {
            return Instance.First(model => model.OsVersion == osVersion);
        }
    }
}
