using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PanIQ_HintDB.Data;
using PanIQ_HintDB.Models;
using PanIQ_HintDB.ViewModels;

namespace PanIQ_HintDB.Controllers.UI_Page_Controllers
{
	public class PuzzlesController : Controller
	{
		private readonly ApplicationDbContext _context;

		public PuzzlesController(ApplicationDbContext context)
		{
			_context = context;
		}
		public IActionResult Index()
		{
			var puzzles = _context.Puzzle
				.Include(p => p.Room).ToList();
			return View(puzzles);
		}

		[Route("/puzzles/new")]
		public IActionResult New()
		{
			var rooms = _context.Rooms.ToList();
			var puzzles = _context.Puzzle.ToList();
			var viewModel = new PuzzleFormViewModel
			{
				Rooms = rooms,
				Puzzles = puzzles
			};
			return View("PuzzleForm", viewModel);
		}

		[HttpPost]
		public ActionResult GetPuzzlesByRoomId(int roomId)
		{
			var puzzles = _context.Puzzle.Where(x => x.RoomId == roomId).ToList();
			var sortedPuzzles = puzzles.OrderBy(o => o.Order).ToList();
			return Json( new { data = sortedPuzzles });
		}

		[HttpPost]
		public IActionResult Save(Puzzle puzzle)
		{
			if (!ModelState.IsValid)
			{
				var viewModel = new PuzzleFormViewModel(puzzle)
				{
					Rooms = _context.Rooms.ToList(),
					Puzzles = _context.Puzzle.ToList()

				};
				return View("PuzzleForm", viewModel);

			}

			return RedirectToAction("Index", "Puzzles");
		}

		//public IActionResult Edit(int id)
		//{

		//	return View("PuzzleForm");
		//}

		//public IActionResult Save(Puzzle puzzle)
		//{
		//	if (ModelState.IsValid)
		//	{
		//		var viewModel = new PuzzleFormViewModel(puzzle)
		//		{
		//			Rooms = _context.Rooms.ToList()
		//		};
		//		return View("PuzzleForm", viewModel);
		//	}

		//	if (puzzle.Id == 0)
		//	{
		//		_context.Puzzle.Add(puzzle);
		//	}
		//	else
		//	{
		//		var puzzleInDb = _context.Puzzle.Single(p => p.Id == puzzle.Id);

		//		puzzleInDb.Name = puzzle.Name;
		//		puzzleInDb.Room = puzzle.Room;
		//		puzzleInDb.Order = puzzle.Order;
		//	}

		//	_context.SaveChanges();

		//	return RedirectToAction("Index", "Puzzles");
		//}
	}
}
