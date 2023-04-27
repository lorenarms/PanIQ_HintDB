using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PanIQ_HintDB.Data;

namespace PanIQ_HintDB.Controllers.APIs
{
	[Route("api/[controller]")]
	[ApiController]
	public class HintsController : ControllerBase
	{
		private ApplicationDbContext _context;

		public HintsController(ApplicationDbContext context)
		{
			_context = context;
		}

		[HttpGet]
		[Route("/api/hints")]
		public IActionResult GetAllHints()
		{
			return Ok(_context.
				Hint.
				Include(p => p.Puzzle).
				ThenInclude(r => r.Room).
				ToList());
		}
	}
}
