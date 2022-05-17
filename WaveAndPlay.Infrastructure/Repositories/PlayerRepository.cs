using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WaveAndPlay.Domain.Interfaces;
using WaveAndPlay.Domain.Models;

namespace WaveAndPlay.Infrastructure.Repositories
{
    public class PlayerRepository : IPlayerRepository
    {
        private readonly Context _context;
        public PlayerRepository(Context context)
        {
            _context = context;
        }
        public int AddPlayer(Player player)
        {
            _context.Players.Add(player);
            _context.SaveChanges();

            return player.Id;
        }
        public void DeletePlayer(int playerId)
        {
            var player = _context.Players.Find(playerId);
            if (player != null)
            {
                _context.Players.Remove(player);
                _context.SaveChanges();
            }
        }
        public void EditPlayer(int playerId)
        {
            var player = _context.Players.Find(playerId);
            if (player != null)
            {
                _context.Players.Update(player);
                _context.SaveChanges();
            }
        }
        public Player GetPlayerById(int playerId)
        {
            return _context.Players.Find(playerId);
        }
        public IQueryable<MatchPlayer> GetAllPlayerMatches(int playerId)
        {
            return _context.MatchPlayer.Where(x => x.PlayerId == playerId);
        }
        public IQueryable<TeamPlayer> GetAllPlayerTeams(int playerId)
        {
            return _context.TeamPlayer.Where(x => x.PlayerId == playerId);
        }
    }
}
