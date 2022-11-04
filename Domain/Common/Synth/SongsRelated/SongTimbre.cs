#region copyright

// (c) Copyright 2011-2022 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

using System;
using System.Diagnostics;
using Domain.Common.Synth.MemoryAndFactory;
using Domain.Common.Synth.OldParameters;
using Domain.Common.Synth.PatchCombis;
using Domain.Common.Synth.PatchInterfaces;
using Domain.Common.Synth.PatchPrograms;

namespace Domain.Common.Synth.SongsRelated
{
    /// <summary>
    /// </summary>
    public class SongTimbre : Timbre, ISongTimbre
    {
        /// <summary>
        /// </summary>
        private readonly ITimbres _timbres;


        /// <summary>
        /// </summary>
        /// <param name="timbres"></param>
        /// <param name="index"></param>
        /// <param name="timbresSize"></param>
        public SongTimbre(ITimbres timbres, int index, int timbresSize)
            : base(timbres, index, timbresSize)
        {
            Debug.Assert(timbresSize > 0);

            _timbres = timbres;
            Index = index;
            TimbresSize = timbresSize;
        }


        /// <summary>
        /// </summary>
        private ITimbres Timbres => _timbres;


        public override IMemory Root => (IMemory)Timbres.Parent.Parent;


        public override INavigable Parent => Timbres;


        public override bool IsLoaded
        {
            get => true;
            set => throw new NotImplementedException();
        }

        public override void Clear()
        {
            throw new NotImplementedException();
        }


        /// <summary>
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public override int GetFixedParameterValue(FixedParameter.EType type)
        {
            return -1;
        }


        /// <summary>
        /// </summary>
        public override IProgramBank UsedProgramBank => null;


        /// <summary>
        /// </summary>
        public override IProgram UsedProgram { get; set; }


        /// <summary>
        /// </summary>
        public override string ColumnProgramId => "ID";


        /// <summary>
        /// </summary>
        public override string ColumnProgramName => "TODO";

        //TODO
    }
}