﻿using System;
using Domain.Interfaces;
using Domain.Model.Common.Synth.SongsRelated;

namespace PcgTools.ViewModels
{
    public interface ISngTimbresViewModel : IViewModel
    {
        /// <summary>
        /// 
        /// </summary>
        ISong Song { get; }


        /// <summary>
        /// 
        /// </summary>
        Action UpdateUiContent { get; }
    }
}
