using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WaveAndPlay.Web.Models;

namespace WaveAndPlay.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Teams()
        {
            List<Team> teams = new List<Team>()
            {
                new Team(1, "Footballers"),
                new Team(2, "NightPlayers"),
                new Team(3, "Randoms")
            };

            List<Player> players = new List<Player>()
            {
                new Player(1, "Patrick"),
                new Player(2, "Anna")
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

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
