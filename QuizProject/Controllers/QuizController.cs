using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using QuizProject.Data;
using QuizProject.Models;
using QuizProject.ViewModels;

namespace QuizProject.Controllers
{
    public class QuizController : Controller
    {
        private readonly QuizContext _context;
        public QuizController(QuizContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Index(IndexPlayerViewModel viewModel)
        {
            if (!ModelState.IsValid && ModelState == null)
            {
                return View(viewModel);
            }

            var newPlayer = new Player
            {
                PlayerName = viewModel.PlayerName
            };

            ViewBag.ActuelGamePlayerName = viewModel.PlayerName;

            if (ModelState.IsValid)
            {
                if (_context.Players.Any(x => x.PlayerName == newPlayer.PlayerName.ToString()))
                {
                    return RedirectToAction(nameof(Index));
                }
                else
                {
                    _context.Players.Add(newPlayer);
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }
            }
            return View(viewModel);
        }
    }
}
