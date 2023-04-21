using System.ComponentModel.DataAnnotations;

namespace PanIQ_HintDB.Models
{
	public class HintEntry
	{
		public int Id { get; set; }
		
		public Hint? Hint { get; set; }

		public byte HintId { get; set; }

	}
}
