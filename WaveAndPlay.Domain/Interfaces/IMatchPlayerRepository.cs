using System;
using System.Collections.Generic;
using System.Text;
using WaveAndPlay.Domain.Models;

namespace WaveAndPlay.Domain.Interfaces
{
    public interface IMatchPlayerRepository
    {
        void AddMatchPlayer(MatchPlayer matchPlayer);
        void DeleteMatchPlayer(int matchId, int playerId);
    }
}
