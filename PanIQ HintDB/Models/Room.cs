namespace PanIQ_HintDB.Models
{
	public class Room
	{
		public byte Id { get; set; }

		public string Name { get; set; }

		public string GetName()
		{
			return this.Name;
		}

	}
}
