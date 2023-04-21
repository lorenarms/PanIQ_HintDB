using Microsoft.AspNetCore.Mvc;
using PanIQ_HintDB.Data;

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
	}
}
