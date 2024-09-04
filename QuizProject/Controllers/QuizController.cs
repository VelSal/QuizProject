using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using QuizProject.Data;
using QuizProject.Models;
using QuizProject.Services;
using QuizProject.ViewModels;

namespace QuizProject.Controllers
{
    public class QuizController : Controller
    {
        private readonly QuizContext _context;
        private readonly QuizService _quizService;
        public QuizController(QuizContext context, QuizService quizService)
        {
            _context = context;
            _quizService = quizService;
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

            if (ModelState.IsValid)
            {
                ViewBag.ActuelGamePlayerName = viewModel.PlayerName;
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

        // Begin new quiz
        public async Task<IActionResult> NewQuiz()
        {
            await _quizService.CopyAndRandomizeQuestionsAsync();    //Get randomized questions
            return RedirectToAction(nameof(Question));  //Ask questions
        }

        // Show question to user
        public IActionResult Question()
        {
            if (!_quizService.HasMoreQuestions())
            {
                return RedirectToAction(nameof(PerfectGame));  // Perfect game page when 100% questions answered
            }
            var question = _quizService.GetNextQuestion();
            return View(question);
        }

        // How did the user answered to the question?
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult SubmitedAnswer(int questionId, string selectedAnswer)
        {
            var currentQuestion = _quizService.GetNextQuestion();

            //Game over if answer is wrong
            if (!_quizService.IsCorrectAnswer(currentQuestion, selectedAnswer))
            {
                return RedirectToAction(nameof(GameOver)); // Game Over page
            }

            //If there is no more questions, perfect game
            if (!_quizService.HasMoreQuestions())
            {
                return RedirectToAction(nameof(PerfectGame)); // Perfect game page
            }

            return RedirectToAction(nameof(Question));
        }

        //Perfect game view when every questions are answered
        public IActionResult PerfectGame()
        {
            return View();
        }

        //Game Over when the user chose the wrong answer
        public IActionResult GameOver()
        {
            return View();
        }
    }
}
