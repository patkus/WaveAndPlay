using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WaveAndPlay.Domain.Interfaces;
using WaveAndPlay.Domain.Models;

namespace WaveAndPlay.Infrastructure.Repositories
{
    public class TeamRepository : ITeamRepository
    {
        private readonly Context _context;
        public TeamRepository(Context context)
        {
            _context = context;
        }
        public int AddTeam(Team team)
        {
            _context.Teams.Add(team);
            _context.SaveChanges();

            return team.Id;
        }

        public void DeleteTeam(int teamId)
        {
            var team = _context.Teams.Find(teamId);
            if(team != null)
            {
                _context.Teams.Remove(team);
                _context.SaveChanges();
            }
        }

        public void EditTeam(int teamId)
        {
            var team = _context.Teams.Find(teamId);
            if (team != null)
            {
                _context.Teams.Update(team);
                _context.SaveChanges();
            }
        }
        public Team GetTeamById(int teamId)
        {
            return _context.Teams.Find(teamId);
        }
        public IQueryable<TeamPlayer> GetAllTeamPlayers(int teamId)
        {
            return _context.TeamPlayer.Where(x => x.TeamId == teamId);
        }
    }
}
