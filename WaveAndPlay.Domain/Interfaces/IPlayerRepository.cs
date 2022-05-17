using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WaveAndPlay.Domain.Models;

namespace WaveAndPlay.Domain.Interfaces
{
    public interface IPlayerRepository
    {
        int AddPlayer(Player player);
        void DeletePlayer(int playerId);
        void EditPlayer(int playerId);
        Player GetPlayerById(int playerId);
        IQueryable<MatchPlayer> GetAllPlayerMatches(int playerId);
        IQueryable<TeamPlayer> GetAllPlayerTeams(int playerId);
    }
}
