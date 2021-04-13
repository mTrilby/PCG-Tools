using System.Collections.Generic;

namespace Domain.Model.Common.Synth.Meta
{
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IObservableBankCollection<T> : IList<T> where T:IBank
    {
    }
}
