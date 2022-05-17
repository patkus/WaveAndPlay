using System.Linq;
using WaveAndPlay.Domain.Models;

namespace WaveAndPlay.Domain.Interfaces
{
    public interface IMatchRepository
    {
        int AddMatch(Match match);
        void DeleteMatch(int matchId);
        void EditMatch(int matchId);
        Match GetMatchById(int matchId);
        IQueryable<MatchPlayer> GetMatchPlayers(int matchId);
    }
}