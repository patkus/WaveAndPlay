using System;
using System.Collections.Generic;
using System.Text;
using WaveAndPlay.Domain.Models;
using System.Linq;
using WaveAndPlay.Domain.Interfaces;

namespace WaveAndPlay.Infrastructure.Repositories
{
    public class MatchRepository : IMatchRepository
    {
        private readonly Context _context;
        public MatchRepository(Context context)
        {
            _context = context;
        }
        public int AddMatch(Match match)
        {
            _context.Matches.Add(match);
            _context.SaveChanges();

            return match.Id;
        }
        public void DeleteMatch(int matchId)
        {
            var match = _context.Matches.Find(matchId);
            if (match != null)
            {
                _context.Matches.Remove(match);
                _context.SaveChanges();
            }
        }
        public void EditMatch(int matchId)
        {
            var match = _context.Matches.Find(matchId);
            if (match != null)
            {
                _context.Matches.Update(match);
                _context.SaveChanges();
            }
        }
        public Match GetMatchById(int matchId)
        {
            return _context.Matches.Find(matchId);
        }
        public IQueryable<Match> GetAllActiveMatches()
        {
            return _context.Matches.Where(x => x.EndDateTime <= DateTimeOffset.UtcNow);
        }
        public IQueryable<MatchPlayer> GetMatchPlayers(int matchId)
        {
            return _context.MatchPlayer.Where(x => x.MatchId == matchId);
        }
    }
}
