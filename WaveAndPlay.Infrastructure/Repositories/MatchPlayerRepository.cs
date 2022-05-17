using System;
using System.Collections.Generic;
using System.Text;
using WaveAndPlay.Domain.Interfaces;
using WaveAndPlay.Domain.Models;

namespace WaveAndPlay.Infrastructure.Repositories
{
    public class MatchPlayerRepository : IMatchPlayerRepository
    {
        private readonly Context _context;
        public MatchPlayerRepository(Context context)
        {
            _context = context;
        }
        public void AddMatchPlayer(MatchPlayer matchPlayer)
        {
            _context.MatchPlayer.Add(matchPlayer);
            _context.SaveChanges();
        }

        public void DeleteMatchPlayer(int matchId, int playerId)
        {
            var matchPlayer = _context.MatchPlayer.Find(new [] { matchId, playerId });
            if(matchPlayer != null)
            {
                _context.MatchPlayer.Remove(matchPlayer);
                _context.SaveChanges();
            }
        }
    }
}
