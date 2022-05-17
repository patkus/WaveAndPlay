using System;
using System.Collections.Generic;
using System.Text;
using WaveAndPlay.Domain.Interfaces;
using WaveAndPlay.Domain.Models;

namespace WaveAndPlay.Infrastructure.Repositories
{
    public class TeamPlayerRepository : ITeamPlayerRepository
    {
        private readonly Context _context;
        public TeamPlayerRepository(Context context)
        {
            _context = context;
        }
        public void AddTeamPlayer(TeamPlayer teamPlayer)
        {
            _context.TeamPlayer.Add(teamPlayer);
            _context.SaveChanges();
        }

        public void DeleteTeamPlayer(int teamId, int playerId)
        {
            var teamPlayer = _context.TeamPlayer.Find(new [] { teamId, playerId });
            if(teamPlayer != null)
            {
                _context.TeamPlayer.Remove(teamPlayer);
                _context.SaveChanges();
            }
        }
    }
}
