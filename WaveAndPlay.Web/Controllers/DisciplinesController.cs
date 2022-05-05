using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WaveAndPlay.Web.Models;

namespace WaveAndPlay.Web.Controllers
{
    public class DisciplinesController : Controller
    {
        [Route("Disciplines/All")]
        public IActionResult ViewDisciplines()
        {
            var disciplines = new List<Discipline>()
            {
                new Discipline(1, "Football", 6, 22, "A family of team sports that involve, to varying degrees, kicking a ball to score a goal."),
                new Discipline(2, "Tennis", 2, 4, "A racket sport that can be played individually against a single opponent (singles) or between two teams of two players each (doubles)."),
                new Discipline(3, "Volleyball", 4, 12, "A team sport in which two teams of six players are separated by a net.")
            };

            return View(disciplines);
        }
    }
}
