using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using PanIQ_HintDB.Models;
using System.Diagnostics;

namespace PanIQ_HintDB.Controllers
{
	public class HomeController : Controller
	{
		private UserManager<ApplicationUser> userManager;
		public HomeController(UserManager<ApplicationUser> userMgr)
		{
			userManager = userMgr;
		}

		[Authorize]
		//[Authorize(Roles = "Manager")]
		public async Task<IActionResult> Index()
		{
			ApplicationUser user = await userManager.GetUserAsync(HttpContext.User);
			string message = "Hello " + user.UserName;
			return View((object)message);
		}
	}
}