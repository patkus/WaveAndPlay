using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using WaveAndPlay.Web.Models;

namespace WaveAndPlay.Web.Controllers
{
    public class TeamsController : Controller
    {
        [Route("Teams/{*team}")]
        public IActionResult ViewTeam(string team)
        {
            List<Team> teams = new List<Team>()
            {
                new Team(1, "Footballers", Team.TeamStatus.Public),
                new Team(2, "NightPlayers", Team.TeamStatus.Public),
                new Team(3, "Randoms", Team.TeamStatus.Private)
            };

            var currentTeam = teams.FirstOrDefault(x => x.Name == team);

            return View(currentTeam);
        }
        [Route("Teams/All")]
        public IActionResult ViewTeamsAndPlayers()
        {
            List<Team> teams = new List<Team>()
            {
                new Team(1, "Footballers", Team.TeamStatus.Public),
                new Team(2, "NightPlayers", Team.TeamStatus.Public),
                new Team(3, "Randoms", Team.TeamStatus.Private)
            };

            List<Player> players = new List<Player>()
            {
                new Player(1, "PK", "Patrick", "Tester1"),
                new Player(2, "Annie", "Anna", "Tester2")
            };

            List<TeamPlayer> teamsPlayer = new List<TeamPlayer>()
            {
                new TeamPlayer(players.ElementAt(0), teams.ElementAt(0)),
                new TeamPlayer(players.ElementAt(0), teams.ElementAt(1)),
                new TeamPlayer(players.ElementAt(0), teams.ElementAt(2)),
                new TeamPlayer(players.ElementAt(1), teams.ElementAt(0)),
                new TeamPlayer(players.ElementAt(1), teams.ElementAt(1)),
                new TeamPlayer(players.ElementAt(1), teams.ElementAt(2))
            };

            return View(teamsPlayer);
        }
    }
}
