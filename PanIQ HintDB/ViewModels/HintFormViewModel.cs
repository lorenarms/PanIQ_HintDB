using System.ComponentModel.DataAnnotations;
using PanIQ_HintDB.Models;

namespace PanIQ_HintDB.ViewModels
{
	public class HintFormViewModel
	{
		public IEnumerable<Room> Rooms { get; set; }

		public IEnumerable<Puzzle> Puzzles { get; set; }

		//Hint Info
		public int Id { get; set; }
		public int Order { get; set; }
		public string Text { get; set; }

		//Puzzle Info
		[Display(Name = "Puzzle")]
		public int PuzzleId { get; set; }

		//Room Info
		public byte RoomId { get; set; }
		
		
		
		//Constructors and other methods
		public string Title => Id != 0 ? "Edit Hint" : "New Hint";

		public HintFormViewModel()
		{
			Id = 0;
		}

		public HintFormViewModel(Hint hint)
		{
			Id = hint.Id;
			Order = hint.Order;
			Text = hint.Text;
			PuzzleId = hint.PuzzleId;
			
		}
	}
}
