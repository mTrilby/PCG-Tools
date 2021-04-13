using Domain.Model.Common.Synth.MemoryAndFactory;

namespace Domain.Tools
{
    public class ModelCompatibility
    {
        /// <summary>
        /// Returns true if two versions of workstation models are compatible.
        /// </summary>
        /// <param name="version1"></param>
        /// <param name="version2"></param>
        /// <returns></returns>
        public static bool AreOsVersionsCompatible(ModelsEOsVersion version1, ModelsEOsVersion version2)
        {
            return (version1 == version2) ||
                   IsTrinityVersionCompatible(version1, version2) ||
                   IsMicroKorgVersionCompatible(version1, version2) ||
                   IsKronosVersionCompatible(version1, version2);
                   // IsKrossVersionCompatible(version1, version2); // Samples are different
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="version1"></param>
        /// <param name="version2"></param>
        /// <returns></returns>
        private static bool IsTrinityVersionCompatible(ModelsEOsVersion version1, ModelsEOsVersion version2)
        {
            return ((version1 == ModelsEOsVersion.EOsVersionTrinityV2) ||
                    (version1 == ModelsEOsVersion.EOsVersionTrinityV3)) &&
                   ((version2 == ModelsEOsVersion.EOsVersionTrinityV2) ||
                    (version2 == ModelsEOsVersion.EOsVersionTrinityV3));
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="version1"></param>
        /// <param name="version2"></param>
        /// <returns></returns>
        private static bool IsMicroKorgVersionCompatible(ModelsEOsVersion version1, ModelsEOsVersion version2)
        {
            return ((version1 == ModelsEOsVersion.EOsVersionMicroKorgXl) ||
                    (version1 == ModelsEOsVersion.EOsVersionMicroKorgXlPlus)) &&
                   ((version2 == ModelsEOsVersion.EOsVersionMicroKorgXl) ||
                    (version2 == ModelsEOsVersion.EOsVersionMicroKorgXlPlus));
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="version1"></param>
        /// <param name="version2"></param>
        /// <returns></returns>
        private static bool IsKronosVersionCompatible(ModelsEOsVersion version1, ModelsEOsVersion version2)
        {
            return ((version1 == ModelsEOsVersion.EOsVersionKronos2x) ||
                    (version1 == ModelsEOsVersion.EOsVersionKronos3x)) &&
                   ((version2 == ModelsEOsVersion.EOsVersionKronos2x) ||
                    (version2 == ModelsEOsVersion.EOsVersionKronos3x));
        }
        

        /// <summary>
        /// 
        /// </summary>
        /// <param name="version1"></param>
        /// <param name="version2"></param>
        /// <returns></returns>
        private static bool IsKrossVersionCompatible(ModelsEOsVersion version1, ModelsEOsVersion version2)
        {
            return ((version1 == ModelsEOsVersion.EOsVersionKross) ||
                    (version1 == ModelsEOsVersion.EOsVersionKross2)) &&
                   ((version2 == ModelsEOsVersion.EOsVersionKross) ||
                    (version2 == ModelsEOsVersion.EOsVersionKross2));
        }


        /// <summary>
        /// Returns true if the two workstation models are compatible.
        /// </summary>
        /// <returns></returns>
        public static bool AreModelsCompatible(IModel model1, IModel model2)
        {
            // Models are compatible if they are equal or if both are either Triton Classic/Studio/Rack or Triton Extreme.
            return (model1.ModelType == model2.ModelType) ||
                   IsTritonModelCompatible(model1, model2) ||
                   IsMicroKorgModelCompatible(model1, model2);
                   // IsKrossModelCompatible(model1, model2);
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="model1"></param>
        /// <param name="model2"></param>
        /// <returns></returns>
        private static bool IsMicroKorgModelCompatible(IModel model1, IModel model2)
        {
            return ((model1.ModelType == ModelsEModelType.MicroKorgXl) ||
                    (model1.ModelType == ModelsEModelType.MicroKorgXlPlus)) &&
                   ((model2.ModelType == ModelsEModelType.MicroKorgXl) ||
                    (model2.ModelType == ModelsEModelType.MicroKorgXlPlus));
        }


        /// <summary>
        /// Triton V2 and V3 are equal (i.e. program S and M program banks contain equal types of patches.
        /// </summary>
        /// <param name="model1"></param>
        /// <param name="model2"></param>
        /// <returns></returns>
        private static bool IsTritonModelCompatible(IModel model1, IModel model2)
        {
            return ((model1.ModelType == ModelsEModelType.TritonTrClassicStudioRack) ||
                    (model1.ModelType == ModelsEModelType.TritonExtreme)) &&
                   ((model2.ModelType == ModelsEModelType.TritonTrClassicStudioRack) ||
                    (model2.ModelType == ModelsEModelType.TritonExtreme));
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="model1"></param>
        /// <param name="model2"></param>
        /// <returns></returns>
        private static bool IsKrossModelCompatible(IModel model1, IModel model2)
        {
            return ((model1.ModelType == ModelsEModelType.Kross) ||
                    (model1.ModelType == ModelsEModelType.Kross2)) &&
                   ((model2.ModelType == ModelsEModelType.Kross) ||
                    (model2.ModelType == ModelsEModelType.Kross2));
        }
    }
}
