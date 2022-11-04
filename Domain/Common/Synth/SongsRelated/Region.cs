#region copyright

// (c) Copyright 2011-2022 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

using Common.MVVM;
using Common.Utils;

namespace Domain.Common.Synth.SongsRelated
{
    /// <summary>
    /// </summary>
    public class Region : ObservableObject, IRegion
    {
        /// <summary>
        ///     Used for UI control binding for selections.
        /// </summary>
        private bool _isSelected;


        /// <summary>
        /// </summary>
        /// <param name="index"></param>
        /// <param name="name"></param>
        /// <param name="sampleFileName"></param>
        public Region(int index, string name, string sampleFileName)
        {
            Index = index;
            Name = name;
            SampleFileName = sampleFileName;
        }

        /// <summary>
        /// </summary>
        [UsedImplicitly]
        // ReSharper disable once MemberCanBePrivate.Global
        public int Index { [global::Common.Properties.UsedImplicitly] get; }


        /// <summary>
        /// </summary>
        [UsedImplicitly]
        // ReSharper disable once MemberCanBePrivate.Global
        public string Name { [global::Common.Properties.UsedImplicitly] get; }


        /// <summary>
        /// </summary>
        [UsedImplicitly]
        // ReSharper disable once MemberCanBePrivate.Global
        public string SampleFileName { [global::Common.Properties.UsedImplicitly] get; }


        /// <summary>
        /// </summary>
        public bool IsSelected
        {
            get => _isSelected;
            set
            {
                if (_isSelected != value)
                {
                    _isSelected = value;
                    RaisePropertyChanged("IsSelected");
                }
            }
        }
    }
}