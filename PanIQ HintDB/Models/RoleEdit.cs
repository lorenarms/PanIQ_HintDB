using Microsoft.AspNetCore.Identity;

namespace PanIQ_HintDB.Models
{
	public class RoleEdit
	{
		public IdentityRole Role { get; set; }

		public IEnumerable<ApplicationUser> Members { get; set; }

		public IEnumerable<ApplicationUser> NonMembers { get; set; }

	}
}
