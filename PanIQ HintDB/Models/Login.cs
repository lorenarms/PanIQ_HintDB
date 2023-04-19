using System.ComponentModel.DataAnnotations;

namespace PanIQ_HintDB.Models
{
	public class Login
	{
		[Required]
		public string Email { get; set; }

		[Required]
		[DataType(DataType.Password)]
		public string Password { get; set; }

		public string ReturnUrl { get; set; }

		public bool Remember { get; set; }


	}
}
