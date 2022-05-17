using System;
using System.Collections.Generic;
using System.Text;
using WaveAndPlay.Domain.Models;

namespace WaveAndPlay.Domain.Interfaces
{
    public interface ITeamPlayerRepository
    {
        void AddTeamPlayer(TeamPlayer teamPlayer);
        void DeleteTeamPlayer(int teamId, int playerId);
    }
}
