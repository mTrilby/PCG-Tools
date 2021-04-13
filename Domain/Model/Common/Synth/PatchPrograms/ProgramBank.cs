// (c) Copyright 2011-2019 MiKeSoft, Michel Keijzers, All rights reserved

using System;
using System.Collections.Generic;
using System.Linq;
using Common.Utils;
using Domain.Model.Common.Synth.Meta;
using Domain.PcgToolsResources;

namespace Domain.Model.Common.Synth.PatchPrograms
{
    /// <summary>
    ///
    /// </summary>
    public abstract class ProgramBank : Bank<Program>, IProgramBank
    {

        /// <summary>
        ///
        /// </summary>
        public const ProgramBankSynthesisType FirstModeledSynthesisType = ProgramBankSynthesisType.AnalogModeling;


        /// <summary>
        ///
        /// </summary>
        /// <param name="programBankSynthesisType"></param>
        /// <returns></returns>
        public static string SynthesisTypeAsString(ProgramBankSynthesisType programBankSynthesisType)
        {
            var map = new Dictionary<ProgramBankSynthesisType, string>
            {
                {ProgramBankSynthesisType.Ai, Strings.ESynthesisTypeAi},
                {ProgramBankSynthesisType.Ai2, Strings.ESynthesisTypeAi2},
                {ProgramBankSynthesisType.Access, Strings.ESynthesisTypeAccess},
                {ProgramBankSynthesisType.Hi, Strings.ESynthesisTypeHi},
                {ProgramBankSynthesisType.Eds, Strings.ESynthesisTypeEds},
                {ProgramBankSynthesisType.Edsi, Strings.ESynthesisTypeEdsi},
                {ProgramBankSynthesisType.Edsx, Strings.ESynthesisTypeEdsx},
                {ProgramBankSynthesisType.Mmt, Strings.ESynthesisTypeMmt},
                {ProgramBankSynthesisType.AnalogModeling, Strings.ESynthesisTypeAnalogModeling},
                {ProgramBankSynthesisType.MossZ1, Strings.ESynthesisTypeMossZ1},
                {ProgramBankSynthesisType.Radias, Strings.ESynthesisTypeRadias},
                {ProgramBankSynthesisType.Hd1, Strings.ESynthesisTypeHd1},
                {ProgramBankSynthesisType.Exi, Strings.ESynthesisTypeExi}
            };

            if (map.ContainsKey(programBankSynthesisType))
            {
                return map[programBankSynthesisType];
            }

            throw new ApplicationException("Illegal case");
        }


        /// <summary>
        ///
        /// </summary>
        public ProgramBankSynthesisType BankSynthesisType
        {
            get;
            set;
        }


        /// <summary>
        /// Returns the default modeled synthesis type, e.g. EXI for Kronos.
        /// </summary>
        public abstract ProgramBankSynthesisType DefaultModeledProgramBankSynthesisType { get; }


        /// <summary>
        /// Returns the default sampled synthesis type, e.g. EDS for Kronos.
        /// </summary>
        public abstract ProgramBankSynthesisType DefaultSampledSynthesisType { get; }


        /// <summary>
        ///
        /// </summary>
        public bool IsModeled => Program.IsModeled(BankSynthesisType);


        /// <summary>
        /// Used in XAML PCG Window in list view column.
        /// </summary>
        [UsedImplicitly]
        // ReSharper disable once UnusedMember.Global
        public string Column2 => SynthesisTypeAsString(BankSynthesisType);


        /// <summary>
        ///
        /// </summary>
        /// // ReSharper disable once UnusedMember.Global
        [UsedImplicitly]
        // ReSharper disable once UnusedAutoPropertyAccessor.Local
        string Description { [UsedImplicitly] get; set; }


        /// <summary>
        ///
        /// </summary>
        /// <param name="programBanks"></param>
        /// <param name="type"></param>
        /// <param name="id"></param>
        /// <param name="pcgId"></param>
        /// <param name="programBankSynthesisType"></param>
        /// <param name="description"></param>
        protected ProgramBank(IBanks programBanks, BankTypeEType type, string id, int pcgId, ProgramBankSynthesisType programBankSynthesisType,
            string description)
            : base(programBanks, type, id, pcgId)
        {
            BankSynthesisType = programBankSynthesisType;
            Description = description;
        }


        /// <summary>
        /// CountPatches filled patches (except GM banks).
        /// </summary>
        public override int CountFilledPatches
        {
            get { return Patches.Count(patch => ((IBank) (patch.Parent)).IsLoaded && (Type != BankTypeEType.Gm)); }
        }


        /// <summary>
        ///
        /// </summary>
        public override string Name { get { return "n.a."; } set { throw new ApplicationException("Not yet implemented"); } }


        /// <summary>
        ///
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"{Strings.Bank_2str} {Id}";
        }
    }
}
