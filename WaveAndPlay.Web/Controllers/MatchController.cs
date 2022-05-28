using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using WaveAndPlay.Application.Interfaces;

namespace WaveAndPlay.Web.Controllers
{
    public class MatchController : Controller
    {
        private readonly IMatchService _matchService;
        public MatchController(IMatchService matchService)
        {
            _matchService = matchService;
        }
        public IActionResult Index()
        {
            var model = _matchService.GetAllMatchesForList();

            return View(model);
        }
    }
}
