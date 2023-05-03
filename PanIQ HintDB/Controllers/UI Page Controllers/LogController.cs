using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PanIQ_HintDB.Data;
using PanIQ_HintDB.Models;
using PanIQ_HintDB.ViewModels;

namespace PanIQ_HintDB.Controllers.UI_Page_Controllers
{
	public class LogController : Controller
	{
		private readonly ApplicationDbContext _context;
		public LogController(ApplicationDbContext context)
		{
			_context = context;
		}
		public IActionResult Index()
		{
			var entries = _context.LogEntry.
				Include(h => h.Hint).
				ThenInclude(p => p.Puzzle)
				.ThenInclude(r => r.Room);
			return View(entries);
		}

		public IActionResult New()
		{
			var rooms = _context.Rooms.ToList();
			var puzzles = _context.Puzzle.ToList();
			var hints = _context.Hint.ToList();
			var viewModel = new LogEntryFormViewModel()
			{
				Rooms = rooms,
				Puzzles = puzzles,
				Hints = hints,
				DateAdded = DateTime.Now
			};

			return View("LogEntryForm", viewModel);
		}

		[HttpPost]
		public IActionResult Save(LogEntry log)
		{
			if (!ModelState.IsValid)
			{
				var viewModel = new LogEntryFormViewModel(log)
				{
					Rooms = _context.Rooms.ToList(),
					Puzzles = _context.Puzzle.ToList(),
					Hints = _context.Hint.ToList(),
					DateAdded = DateTime.Now

				};
				return View("LogEntryForm", viewModel);

			}

			if (log.Id == 0)
			{
				log.DateAdded = DateTime.Now;
				_context.Add(log);
			}
			else
			{
				var logInDb = _context.LogEntry.Single(x => x.Id == log.Id);
				logInDb.CustomText = log.CustomText;
				logInDb.Bypass = log.Bypass;
				logInDb.Glitch = log.Glitch;
				logInDb.HintId = log.HintId;
			}

			_context.SaveChanges();

			
			return RedirectToAction("New", "Log");
		}

		public IActionResult Details(int id)
		{
			var entry = _context.LogEntry.
				Include(h => h.Hint).
				ThenInclude(p => p.Puzzle).
				ThenInclude(r => r.Room).
				SingleOrDefault(m => m.Id == id);

			if (entry == null)
			{
				return new NotFoundResult();

			}
			return View(entry);
		}
	}
}
