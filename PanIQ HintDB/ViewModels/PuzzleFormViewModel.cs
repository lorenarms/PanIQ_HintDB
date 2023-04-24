using System.ComponentModel.DataAnnotations;
using PanIQ_HintDB.Models;

namespace PanIQ_HintDB.ViewModels
{
	public class PuzzleFormViewModel
	{
		//Lists for page
		public IEnumerable<Room> Rooms { get; set; }
		
		//Puzzle attributes
		public int? Id { get; set; }
		
		[Required]
		[Display(Name = "Puzzle Name")]
		public string Name { get; set; }

		[Display(Name = "Room Name")]
		public byte RoomId { get; set; }

		[Required]
		[Range(0, int.MaxValue)]
		public int Order { get; set; }

		//Page methods
		public string Title
		{
			get
			{
				return Id != 0 ? "Edit Puzzle" : "New Puzzle";
			}
		}

		public PuzzleFormViewModel()
		{
			Id = 0;
		}

		public PuzzleFormViewModel(Puzzle puzzle)
		{
			Id = puzzle.Id;
			Name = puzzle.Name;
			RoomId = puzzle.RoomId;
			Order = puzzle.Order;

		}
	}
}
