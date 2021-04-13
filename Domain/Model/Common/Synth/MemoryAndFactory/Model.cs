using System;
using System.Collections.Generic;
using Common.Mvvm;
using Domain.PcgToolsResources;

namespace Domain.Model.Common.Synth.MemoryAndFactory
{
    /// <summary>
    /// 
    /// </summary>
    public class Model : ObservableObject, IModel
    {
        /// <summary>
        /// 
        /// </summary>
        public ModelsEModelType ModelType { get; private set; }


        /// <summary>
        /// 
        /// </summary>
        public ModelsEOsVersion OsVersion { get; private set; }


        /// <summary>
        /// 
        /// </summary>
        public string OsVersionString { get; private set; }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="modelType"></param>
        /// <param name="osVersion"></param>
        /// <param name="osVersionString"></param>
        public Model(ModelsEModelType modelType, ModelsEOsVersion osVersion, string osVersionString)
        {
            ModelType = modelType;
            OsVersion = osVersion;
            OsVersionString = osVersionString;
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="modelType"></param>
        /// <returns></returns>
        public static string ModelTypeAsString(ModelsEModelType modelType)
        {
            var map = new Dictionary<ModelsEModelType, string>
            {
                {ModelsEModelType.Kronos, Strings.EModelTypeKronos},
                {ModelsEModelType.Oasys, Strings.EModelTypeOasys},
                {ModelsEModelType.Krome, Strings.EModelTypeKrome},
                {ModelsEModelType.KromeEx, Strings.EModelTypeKromeEx},
                {ModelsEModelType.Kross, Strings.EModelTypeKross},
                {ModelsEModelType.Kross2, Strings.EModelTypeKross2},
                {ModelsEModelType.M1, Strings.EModelTypeM1},
                {ModelsEModelType.M3, Strings.EModelTypeM3},
                {ModelsEModelType.M3R, Strings.EModelTypeM3R},
                {ModelsEModelType.M50, Strings.EModelTypeM50},
                {ModelsEModelType.Ms2000, Strings.EModelTypeMs2000},
                {ModelsEModelType.MicroKorgXl, Strings.EModelTypeMicroKorgXl},
                {ModelsEModelType.MicroKorgXlPlus, Strings.EModelTypeMicroKorgXlPlus},
                {ModelsEModelType.MicroStation, Strings.EModelTypeMicroStation},
                {ModelsEModelType.Trinity, Strings.EModelTypeTrinity},
                {ModelsEModelType.TritonExtreme, Strings.EModelTypeTritonExtreme},
                {ModelsEModelType.TritonTrClassicStudioRack, Strings.EModelTypeTritonTrClassicStudioRack},
                {ModelsEModelType.TritonLe, Strings.EModelTypeTritonLE},
                {ModelsEModelType.TritonKarma, Strings.EModelTypeKarma},
                {ModelsEModelType.TSeries, Strings.EModelTypeTSeries},
                {ModelsEModelType.XSeries, Strings.EModelTypeXSeries},
                {ModelsEModelType.Z1, Strings.EModelTypeZ1},
                {ModelsEModelType.ZeroSeries, Strings.EModelTypeZeroSeries},
                {ModelsEModelType.Zero3Rw, Strings.EModelTypeZero3Rw}
            };

            if (map.ContainsKey(modelType))
            {
                return map[modelType];
            }

            throw new ApplicationException("Illegal type");
        }


        /// <summary>
        /// 
        /// </summary>
        public string ModelAsString => ModelTypeAsString(ModelType);


        /// <summary>
        /// 
        /// </summary>
        public string ModelAndVersionAsString => ModelAsString + (string.IsNullOrEmpty(OsVersionString) ? string.Empty : (" " + OsVersionString));
    }
}
