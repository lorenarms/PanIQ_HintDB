using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PanIQ_HintDB.Models;

namespace PanIQ_HintDB.Data
{
	public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
	{
		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
			: base(options)
		{

		}

		public DbSet<Room> Rooms { get; set; }
		public DbSet<Hint> Hint { get; set; }
		public DbSet<Puzzle> Puzzle { get; set; }
		public DbSet<HintEntry> HintEntry { get; set; }

	}
}