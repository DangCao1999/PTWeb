using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using PTWeb.Areas.Identity.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace PTWeb.ViewComponents
{
    public class LoginViewComponent: ViewComponent
    {
        private readonly SignInManager<AppUser> _signInManager;
        private readonly UserManager<AppUser> _userManager;

        public LoginViewComponent(SignInManager<AppUser> signInManager, UserManager<AppUser> userManager)
        {
            this._signInManager = signInManager;
            this._userManager = userManager;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            if (_signInManager.IsSignedIn(this.User as ClaimsPrincipal))
            {
                return View("Logined", await _userManager.GetUserAsync(this.User as ClaimsPrincipal));
            }
            return View("SignedOut");
        }

        //public async Task<IActionResult> OnPostAsync(string returnUrl = null)
        //{
        //    returnUrl ??= Url.Content("~/");

        //    ExternalLogins = (await _signInManager.GetExternalAuthenticationSchemesAsync()).ToList();

        //    if (ModelState.IsValid)
        //    {
        //        // This doesn't count login failures towards account lockout
        //        // To enable password failures to trigger account lockout, set lockoutOnFailure: true
        //        var result = await _signInManager.PasswordSignInAsync(Input.Email, Input.Password, Input.RememberMe, lockoutOnFailure: false);
        //        if (result.Succeeded)
        //        {
        //            _logger.LogInformation("User logged in.");
        //            return LocalRedirect(returnUrl);
        //        }
        //        if (result.RequiresTwoFactor)
        //        {
        //            return RedirectToPage("./LoginWith2fa", new { ReturnUrl = returnUrl, RememberMe = Input.RememberMe });
        //        }
        //        if (result.IsLockedOut)
        //        {
        //            _logger.LogWarning("User account locked out.");
        //            return RedirectToPage("./Lockout");
        //        }
        //        else
        //        {
        //            ModelState.AddModelError(string.Empty, "Invalid login attempt.");
        //            return Page();
        //        }
        //    }

        //    // If we got this far, something failed, redisplay form
        //    return Page();
        //}
    }
}
