using System.ComponentModel.DataAnnotations;

namespace PanIQ_HintDB.Models
{
	public class Puzzle
	{
		public byte Id { get; set; }
		public string Name { get; set; }
		public Room? Room { get; set; }
		
		[Display(Name = "Room")]
		public byte RoomId { get; set; }

		public int Order { get; set; }
	}
}
