using System.ComponentModel.DataAnnotations;
using PanIQ_HintDB.Models;

namespace PanIQ_HintDB.ViewModels
{
	public class PuzzleFormViewModel
	{
		public IEnumerable<Room> Rooms { get; set; }

		public int? Id { get; set; }

		public string Name { get; set; }

		[Display(Name = "Room")]
		public byte RoomId { get; set; }

		public int Order { get; set; }

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
