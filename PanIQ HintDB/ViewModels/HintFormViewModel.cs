using System.ComponentModel.DataAnnotations;
using PanIQ_HintDB.Models;

namespace PanIQ_HintDB.ViewModels
{
	public class HintFormViewModel
	{
		public IEnumerable<Room> Rooms { get; set; }

		public IEnumerable<Puzzle> Puzzles { get; set; }

		//Hint ID
		public int Id { get; set; }
		//Hint Name
		public string Name { get; set; }
		//Hint Description
		public string Description { get; set; }

		//Puzzle Info
		[Display(Name = "Puzzle")]
		public byte PuzzleId { get; set; }
		public int Order { get; set; }

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
			Name = hint.Name;
			Description = hint.Description;
			PuzzleId = hint.PuzzleId;
			Order = hint.Order;
			
		}
	}
}
