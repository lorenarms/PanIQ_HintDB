using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using PanIQ_HintDB.Models;

namespace PanIQ_HintDB.Controllers
{
	public class AccountController : Controller
	{


		private UserManager<ApplicationUser> userManager;
		private SignInManager<ApplicationUser> signInManager;

		public AccountController(UserManager<ApplicationUser> userMgr, SignInManager<ApplicationUser> signinMgr)
		{
			userManager = userMgr;
			signInManager = signinMgr;
		}

		[AllowAnonymous]
		public IActionResult Login(string returnUrl)
		{
			Login login = new Login();
			login.ReturnUrl = returnUrl;
			return View(login);
		}

		[HttpPost]
		[AllowAnonymous]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> Login(Login login)
		{
			if (ModelState.IsValid)
			{
				ApplicationUser appUser = await userManager.FindByEmailAsync(login.Email);
				if (appUser != null)
				{
					await signInManager.SignOutAsync();
					Microsoft.AspNetCore.Identity.SignInResult result = await signInManager.PasswordSignInAsync(appUser, login.Password, login.Remember, false);

					if (result.Succeeded)
						return Redirect(login.ReturnUrl ?? "/");

				}
				ModelState.AddModelError(nameof(login.Email), "Login Failed: Invalid Email or password");
			}
			return View(login);
		}

		public async Task<IActionResult> Logout()
		{
			await signInManager.SignOutAsync();
			return RedirectToAction("Index", "Home");
		}

		public IActionResult AccessDenied()
		{
			return View();
		}
	}
}
