using System.ComponentModel.DataAnnotations;

namespace PanIQ_HintDB.Models
{
	public class Hint
	{
		public int Id { get; set; }

		[Required]
		public int Order { get; set; }
		public Puzzle? Puzzle { get; set; }

		[Required]
		[Display(Name = "Puzzle")]
		public int PuzzleId { get; set; }
		public string Text { get; set; }
		

	}
}
