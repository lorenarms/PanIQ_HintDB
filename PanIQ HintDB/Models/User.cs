using System.ComponentModel.DataAnnotations;

namespace PanIQ_HintDB.Models
{
	public class User
	{
		[Required]
		public string Name { get; set; }

		[Required]
		[DataType(DataType.EmailAddress)]
		public string Email { get; set; }

		[Required]
		[DataType(DataType.Password)]
		public string Password { get; set; }

	}
}
