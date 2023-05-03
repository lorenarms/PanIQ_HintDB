using System.ComponentModel.DataAnnotations;

namespace PanIQ_HintDB.Models
{
	public class LogEntry
	{
		public int Id { get; set; }
		
		

		[Display(Name = "Custom Text")]
		[StringLength(255)]
		public string? CustomText { get; set; }
		
		[StringLength(255)]
		public string? Glitch { get; set; }

		[StringLength(255)]
		public string? Bypass { get; set; }

		[Display(Name = "Date Added")]
		public DateTime DateAdded { get; set; }


		public Hint? Hint { get; set; }

		[Display(Name = "Hint")]
		public int HintId { get; set; }


		public string ShortDate => DateAdded.ToShortDateString();

		public string TimeAdded => DateAdded.ToShortTimeString();
	}
}
