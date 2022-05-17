using System.Linq;
using WaveAndPlay.Domain.Models;

namespace WaveAndPlay.Domain.Interfaces
{
    public interface ITeamRepository
    {
        int AddTeam(Team team);
        void DeleteTeam(int teamId);
        void EditTeam(int teamId);
        Team GetTeamById(int teamId);
        IQueryable<TeamPlayer> GetAllTeamPlayers(int teamId);
    }
}
