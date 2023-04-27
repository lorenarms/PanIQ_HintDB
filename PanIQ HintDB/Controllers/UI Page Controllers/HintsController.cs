using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PanIQ_HintDB.Data;
using PanIQ_HintDB.Models;
using PanIQ_HintDB.ViewModels;

namespace PanIQ_HintDB.Controllers.UI_Page_Controllers
{
	public class HintsController : Controller
	{
		private readonly ApplicationDbContext _context;

		public HintsController(ApplicationDbContext context)
		{
			_context = context;
		}
		public IActionResult Index()
		{
			var hints = _context.Hint
				.Include(h => h.Puzzle)
				.ThenInclude(p => p.Room);
			return View(hints);
		}


		[Route("/hints/new")]
		public IActionResult New()
		{
			var puzzles = _context.Puzzle.ToList();
			var rooms = _context.Rooms.ToList();
			var viewModel = new HintFormViewModel()
			{
				Puzzles = puzzles,
				Rooms = rooms

			};
			return View("HintForm", viewModel);
		}

		[HttpPost]
		public IActionResult Save(Hint hint)
		{
			if (!ModelState.IsValid)
			{
				var viewModel = new HintFormViewModel(hint)
				{
					Puzzles = _context.Puzzle.ToList(),
					Rooms = _context.Rooms.ToList()
				};
				return View("HintForm", viewModel);
			}

			if (hint.Id == 0)
			{
				_context.Add(hint);
			}
			else
			{
				var hintInDb = _context.Hint.Single(h => h.Id == hint.Id);
				hintInDb.Text = hint.Text;
				hintInDb.Order = hint.Order;
				hintInDb.PuzzleId = hint.PuzzleId;
			}

			_context.SaveChanges();

			return RedirectToAction("Index", "Hints");
		}

		[HttpPost]
		public ActionResult GetHintsByPuzzleId(int puzzleId)
		{
			var hints = _context.Hint.Where(x => x.PuzzleId == puzzleId).ToList();
			var sortedHints = hints.OrderBy(o => o.Order).ToList();
			return Json(new { data = sortedHints });
		}


	}
}
