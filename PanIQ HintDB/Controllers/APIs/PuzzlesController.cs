using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PanIQ_HintDB.Data;

namespace PanIQ_HintDB.Controllers.APIs
{
	[Route("api/[controller]")]
	[ApiController]
	public class PuzzlesController : ControllerBase
	{
		private ApplicationDbContext _context;

		public PuzzlesController(ApplicationDbContext context)
		{
			_context = context;
		}

		[HttpGet]
		[Route("/api/puzzles")]
		public IActionResult GetAllPuzzles()
		{
			return Ok(_context.
				Puzzle.
				Include(r => r.Room).
				ToList());
		}

		[HttpGet]
		[Route("/api/puzzles/{id}")]
		public IActionResult GetPuzzlesByRoom(int id)
		{
			var puzzles = _context.Puzzle.Where(p => p.RoomId == id).Include(r => r.Room).ToList();

			return Ok(puzzles);
		}

		[HttpGet]
		[Route("/api/puzzle/{id}")]
		public IActionResult GetPuzzleById(int id)
		{
			var puzzle = _context.Puzzle.SingleOrDefault(p => p.Id == id);

			if (puzzle == null)
			{
				return NotFound();
			}

			return Ok(puzzle);
		}

	}


}
