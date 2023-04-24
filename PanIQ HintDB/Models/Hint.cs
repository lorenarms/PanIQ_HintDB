using System.ComponentModel.DataAnnotations;

namespace PanIQ_HintDB.Models
{
	public class Hint
	{
		public byte Id { get; set; }
		public string Name { get; set; }

		public string Description { get; set; }

		public Puzzle Puzzle { get; set; }

		[Display(Name = "Puzzle")]
		public byte PuzzleId { get; set; }
		
		public int Order { get; set; }

	}
}
