/*
 * Project: Municipal Elections Management System (MEMS)
 * Course: COMP4976
 * Authors: Abdullah Rehan, Alex Fisher (project contributors)
 * Description: Handles administrator sign-in, sign-out, and access-denied responses.
 */
using Mems.Web.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.RateLimiting;

namespace Mems.Web.Controllers;

/// <summary>Uses Identity cookie authentication with lockout and local-only return redirects.</summary>
public class AccountController(SignInManager<IdentityUser> signIn) : Controller
{
    [HttpGet]
    public IActionResult Login(string? returnUrl) => View(new LoginForm { ReturnUrl = returnUrl });
    [HttpPost, EnableRateLimiting("login")]
    public async Task<IActionResult> Login(LoginForm form)
    {
        if (!ModelState.IsValid) return View(form);
        var result = await signIn.PasswordSignInAsync(form.UserName, form.Password, form.RememberMe, lockoutOnFailure: true);
        // A supplied return URL must be local to avoid redirecting a successful login to another site.
        if (result.Succeeded) return Url.IsLocalUrl(form.ReturnUrl) ? LocalRedirect(form.ReturnUrl!) : RedirectToAction("Index", "Dashboard", new { area = "Admin" });
        ModelState.AddModelError("", result.IsLockedOut ? "Too many attempts. Please try again in 15 minutes." : "Invalid username or password.");
        return View(form);
    }
    [HttpPost, Authorize]
    public async Task<IActionResult> Logout() { await signIn.SignOutAsync(); return RedirectToAction("Index", "Municipalities"); }
    public IActionResult AccessDenied() { Response.StatusCode = 403; return View(); }
}
