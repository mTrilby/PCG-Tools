using Domain.Model.Common.Synth.Meta;

namespace Domain.Model.Common.Synth.PatchInterfaces
{
    /// <summary>
    /// 
    /// </summary>
    public interface IReferencable
    {
        /// <summary>
        /// 
        /// </summary>
        int NumberOfReferences { get; }


        /// <summary>
        /// Change references from combis/set list slots to patch, towards newPatch.
        /// </summary>
        /// <param name="newPatch"></param>
        void ChangeReferences(IPatch newPatch);
    }
}
