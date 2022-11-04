#region copyright

// (c) Copyright 2011-2022 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

using Common.PcgToolsResources;
using PcgTools.Annotations;
using PcgTools.Model.Common.Synth.MemoryAndFactory;
using PcgTools.Model.Common.Synth.Meta;
using PcgTools.Mvvm;

namespace PcgTools.ViewModels
{
    /// <summary>
    /// </summary>
    public class EditParameterViewModel : ViewModel
    {
        /// <summary>
        /// </summary>
        private string _errorText;

        /// <summary>
        /// </summary>
        private IPcgMemory _memory;


        /// <summary>
        /// </summary>
        private int _numberOfClippedPatches;


        /// <summary>
        /// </summary>
        private string _valueRangeAfterChange;


        /// <summary>
        /// </summary>
        private string _valueRangeBeforeChange;


        /// <summary>
        /// </summary>
        /// <param name="selectedPatches"></param>
        public EditParameterViewModel(ObservableCollectionEx<IPatch> selectedPatches)
        {
            Patches = selectedPatches;
            _memory = Patches.Count > 0 ? Patches[0].PcgRoot : null;
            ErrorText = Strings.EditParameterChangeEmpty;
        }


        /// <summary>
        ///     Selected patches.
        /// </summary>
        [UsedImplicitly]
        public ObservableCollectionEx<IPatch> Patches { get; set; }


        /// <summary>
        /// </summary>
        [global::Common.Utils.UsedImplicitly]
        public string ValueRangeBeforeChange
        {
            get => _valueRangeBeforeChange;
            set
            {
                if (_valueRangeBeforeChange != value)
                {
                    _valueRangeBeforeChange = value;
                    OnPropertyChanged("ValueRangeBeforeChange");
                }
            }
        }


        /// <summary>
        /// </summary>
        [global::Common.Utils.UsedImplicitly]
        public string ValueRangeAfterChange
        {
            get => _valueRangeAfterChange;
            set
            {
                if (_valueRangeAfterChange != value)
                {
                    _valueRangeAfterChange = value;
                    OnPropertyChanged("ValueRangeAfterChange");
                }
            }
        }


        /// <summary>
        /// </summary>
        public string ErrorText
        {
            get => _errorText;
            set
            {
                if (_errorText != value)
                {
                    _errorText = value;
                    OnPropertyChanged("ErrorText");
                }
            }
        }


        /// <summary>
        /// </summary>
        [global::Common.Utils.UsedImplicitly]
        public int NumberOfClippedPatches
        {
            get => _numberOfClippedPatches;
            set
            {
                if (_numberOfClippedPatches != value)
                {
                    _numberOfClippedPatches = value;
                    OnPropertyChanged("NumberOfClippedPatches");
                }
            }
        }


        /// <summary>
        /// </summary>
        /// <param name="exitMode"></param>
        /// <returns></returns>
        public override bool Close(bool exitMode)
        {
            return true;
        }
    }
}