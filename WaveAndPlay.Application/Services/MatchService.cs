using AutoMapper;
using AutoMapper.QueryableExtensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WaveAndPlay.Application.Interfaces;
using WaveAndPlay.Application.ViewModels.Match;
using WaveAndPlay.Domain.Interfaces;

namespace WaveAndPlay.Application.Services
{
    public class MatchService : IMatchService
    {
        private readonly IMatchRepository _matchRepo;
        private readonly IMapper _mapper;

        public MatchService(IMatchRepository matchRepo, IMapper mapper)
        {
            _matchRepo = matchRepo;
            _mapper = mapper;
        }

        public ListMatchForListVm GetAllMatchesForList()
        {
            var matches = _matchRepo.GetAllActiveMatches().ProjectTo<MatchForListVm>(_mapper.ConfigurationProvider).ToList();

            var matchesList = new ListMatchForListVm()
            {
                Matches = matches,
                Count = matches.Count
            };

            return matchesList;
        }
    }
}
