// (c) Copyright 2011-2019 MiKeSoft, Michel Keijzers, All rights reserved

using System.Text;
using Domain.MasterFiles;
using Domain.Model.Common.Synth.Meta;
using Domain.Model.Common.Synth.OldParameters;
using Domain.Model.MntxSeriesSpecific.Synth;

namespace Domain.Model.XSeries.Synth
{
    /// <summary>
    /// 
    /// </summary>
    public class XSeriesCombi : MntxCombi
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="combiBank"></param>
        /// <param name="index"></param>
        public XSeriesCombi(IBank combiBank, int index)
            : base(combiBank, index)
        {
            Id = $"{combiBank.Id}{(index).ToString("00")}";
            Timbres = new XSeriesTimbres(this);
        }


        /// <summary>
        /// Substibute chars.
        /// </summary>
        public override string Name
        {
            get
            {
                if (PcgRoot.Content == null)
                {
                    return string.Empty;
                }

                var name = new StringBuilder();

                for (var index = 0; index < MaxNameLength; index++)
                {
                    var character = PcgRoot.Content[ByteOffset + index];

                    if (character == 0x00)
                    {
                        name.Append(' ');
                    }
                    else
                    {
                        name.Append((char) (character));
                    }
                }

                return name.ToString().Trim();
            }

            set
            {
                if (value != Name)
                {
                    SetChars(0, MaxNameLength, value);

                    // Add spaces.
                    for (var index = value.Length; index < MaxNameLength; index++)
                    {
                        PcgRoot.Content[ByteOffset + index] = (byte)' ';
                    }

                    OnPropertyChanged("Name");
                }

            }
        }


        /// <summary>
        /// Sets parameters after initialization.
        /// </summary>
        public override void SetParameters()
        {
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public override IParameter GetParam(ParameterNames.CombiParameterName name)
        {
            IParameter parameter;

            switch (name)
            {

            default:
                parameter = base.GetParam(name);
                break;
            }
            return parameter;
        }
    }
}