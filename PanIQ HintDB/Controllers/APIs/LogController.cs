using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PanIQ_HintDB.Data;
using PanIQ_HintDB.Models;

namespace PanIQ_HintDB.Controllers.APIs
{
	[Route("api/[controller]")]
	[ApiController]
	public class LogController : ControllerBase
	{
		private ApplicationDbContext _context;

		public LogController(ApplicationDbContext context)
		{
			_context = context;
		}

		[HttpGet]
		[Route("/api/log")]
		public IActionResult GetAllEntries()
		{
			return Ok(_context.
				LogEntry.
				Include(h => h.Hint).
				ThenInclude(p => p.Puzzle).
				ThenInclude(r => r.Room).
				ToList());
		}

		[HttpPost]
		[Route("/api/newLog")]
		public IActionResult CreateNewLog([FromForm] LogEntry newLog)
		{
			var puzzle = _context.Puzzle.SingleOrDefault(
				p => p.Id == newLog.Hint.PuzzleId);

			if (puzzle == null)
			{
				return BadRequest("The puzzle selected is not valid.");
			}

			return Ok();
		}
	}
}
