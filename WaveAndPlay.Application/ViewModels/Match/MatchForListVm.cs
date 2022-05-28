using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using WaveAndPlay.Application.Mapping;

namespace WaveAndPlay.Application.ViewModels.Match
{
    public class MatchForListVm : IMapFrom<WaveAndPlay.Domain.Models.Match>
    {
        public int Id { get; set; }
        public DateTimeOffset StartDateTime { get; set; }
        public DateTimeOffset EndDateTime { get; set; }
        public int MinNumberOfPlayers { get; set; }
        public int MaxNumberOfPlayers { get; set; }
        public int NumberOfTeams { get; set; }
        public float FullAmount { get; set; }
        public void Mapping(Profile profile)
        {
            profile.CreateMap<WaveAndPlay.Domain.Models.Match, MatchForListVm>();
        }
    }
}
