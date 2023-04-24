using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PanIQ_HintDB.Data;
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


	}
}
