using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using WaveAndPlay.Web.Models;

namespace WaveAndPlay.Web.Controllers
{
    public class MatchesController : Controller
    {
        [Route("Matches/All")]
        public IActionResult ViewAllMatches()
        {
            var player = new Player(1, "Grumpy123", "Patrick", "Test");
            var player1 = new Player(2, "Grumpy456", "Anna", "Test1");
            var player2 = new Player(3, "Grumpy789", "Bob", "Test2");
            var discipline = new Discipline(1, "Football", 1, 100, "");
            var address = new Address(1, "Poland", "Wrocław", "54-212", "Legnicka", "1A", "1");
            var match = new Match(1, player, DateTime.Parse("2022-06-01 18:00:00"), DateTime.Parse("2022-06-01 20:00:00"),
                discipline, 10, 14, 2, address);
            var matchPlayer = new List<MatchPlayer>()
            {
                new MatchPlayer(match, player),
                new MatchPlayer(match, player1),
                new MatchPlayer(match, player2)
            };

            return View(matchPlayer);
        }
    }
}
