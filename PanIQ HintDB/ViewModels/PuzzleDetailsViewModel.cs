using PanIQ_HintDB.Controllers.APIs;
using PanIQ_HintDB.Models;

namespace PanIQ_HintDB.ViewModels
{
	public class PuzzleDetailsViewModel
	{
		public IEnumerable<Hint> Hints { get; set; }

		public Puzzle Puzzle { get; set; }
	}
}
