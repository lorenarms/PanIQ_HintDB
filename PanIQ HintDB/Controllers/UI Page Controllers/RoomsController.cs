using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PanIQ_HintDB.Data;
using PanIQ_HintDB.ViewModels;

namespace PanIQ_HintDB.Controllers.UI_Page_Controllers
{
	public class RoomsController : Controller
	{

		private readonly ApplicationDbContext _context;

		public RoomsController(ApplicationDbContext context)
		{
			_context = context;
		}
		public IActionResult Index()
		{
			var rooms = _context.Rooms;
			return View(rooms);
		}

		public IActionResult Details(byte id)
		{
			var room = _context.Rooms.SingleOrDefault(r => r.Id == id);

			var viewModel = new RoomsDetailsViewModel
			{
				Room = room,
				Puzzles = _context.Puzzle.Where(x => x.RoomId == id).OrderBy(o => o.Order).ToList()
			};

			return View("Details", viewModel);
		}
	}
}
