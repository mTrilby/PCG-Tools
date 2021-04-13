namespace Domain.Model.ChangeVolumeParameters
{
    public class ChangeVolumeParameters
    {
        /// <summary>
        ///
        /// </summary>
        public ChangeVolumeParametersEChangeType ChangeType { get; set; }


        /// <summary>
        ///
        /// </summary>
        public int Value { get; set; }

        /// <summary>
        /// Only used for mapped (to) value.
        /// </summary>
        public int ToValue { get; set; }
    }
}
