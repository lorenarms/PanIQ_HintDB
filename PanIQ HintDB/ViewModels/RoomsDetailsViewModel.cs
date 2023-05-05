using PanIQ_HintDB.Models;

namespace PanIQ_HintDB.ViewModels
{
	public class RoomsDetailsViewModel
	{
		public Room Room { get; set; }
		public IEnumerable<Puzzle> Puzzles { get; set; }

	}
}
