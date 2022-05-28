using System;
using System.Collections.Generic;
using System.Text;
using WaveAndPlay.Application.ViewModels.Match;

namespace WaveAndPlay.Application.Interfaces
{
    public interface IMatchService
    {
        public ListMatchForListVm GetAllMatchesForList();
    }
}
