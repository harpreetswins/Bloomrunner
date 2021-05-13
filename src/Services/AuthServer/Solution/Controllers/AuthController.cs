using System;
using System.Security.Claims;
using System.Threading.Tasks;
using AuthIdentityServer.Infrastructure.EmailSender;
using AuthIdentityServer.Models;
using AuthIdentityServer.Models.AccountViewModels;
using AuthIdentityServer.Models.Sendgrid;
using AuthIdentityServer.Models.SendGrid;
using AuthIdentityServer.Services;
using IdentityModel;
using IdentityServer4;
using IdentityServer4.Models;
using IdentityServer4.Services;
using IdentityServer4.Stores;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Solution.Data.Interfaces;
using Microsoft.Extensions.Options;
using AuthIdentityServer.Models.ManageViewModels;

namespace AuthIdentityServer.Controllers
{
    // [Route("api/v{version:apiVersion}/[controller]")]
    // [ApiVersion("1.0", Deprecated = true)]
    // [ApiVersion("1.1")]
    // [ApiController]
    public class AuthController : Controller
    {
        private readonly ILoginService<ApplicationUser> _loginService;
        private readonly IIdentityServerInteractionService _interaction;
        private readonly IClientStore _clientStore;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IConfiguration _configuration;
        private readonly IFloristThemeIdRepository _userService;
        private readonly IOptions<EmailCredientials> Credientials;

        public AuthController(ILoginService<ApplicationUser> loginService,
            IFloristThemeIdRepository userService,
            IIdentityServerInteractionService interaction,
            IClientStore clientStore,
            UserManager<ApplicationUser> userManager,
            IConfiguration configuration,
            IOptions<EmailCredientials> credientials)
        {
            _loginService = loginService;
            _interaction = interaction;
            _clientStore = clientStore;
            _userManager = userManager;
            _configuration = configuration;
            _userService = userService;
            Credientials = credientials;
        }

        [HttpGet]
        public async Task<IActionResult> Login(string returnUrl)
        {
            var context = await _interaction.GetAuthorizationContextAsync(returnUrl);
            if (context?.IdP != null)
            {
                throw new NotImplementedException("External login is not implemented!");
            }
            var result = await _userService.GetFloristThemeIds(50);
            var vm = await BuildLoginViewModelAsync(returnUrl, context);
            vm.ThemeId = result.KeyId;
            ViewData["ReturnUrl"] = returnUrl;
            return View(vm);

        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                var user = await _loginService.FindByUsername(model.Email);
                if (await _loginService.ValidateCredentials(user, model.Password))
                {
                    var tokenLifetime = _configuration.GetValue("TokenLifetimeMinutes", 120);
                    var props = new AuthenticationProperties
                    {
                        ExpiresUtc = DateTimeOffset.UtcNow.AddMinutes(tokenLifetime),
                        AllowRefresh = true,
                        RedirectUri = model.ReturnUrl
                    };
                    if (model.RememberMe)
                    {
                        var permanentTokenLifetime = _configuration.GetValue("PermanentTokenLifetimeDays", 365);

                        props.ExpiresUtc = DateTimeOffset.UtcNow.AddDays(permanentTokenLifetime);
                        props.IsPersistent = true;
                    };
                    await _loginService.SignInAsync(user, props);

                    if (_interaction.IsValidReturnUrl(model.ReturnUrl))
                    {
                        return Redirect(model.ReturnUrl);

                    }
                }
                model.Message = "Wrong username and password";
            }
            var vm = await BuildLoginViewModelAsync(model);
            var result = await _userService.GetFloristThemeIds(50);
            vm.ThemeId = result.KeyId;
            return View(vm);
        }

        private async Task<LoginViewModel> BuildLoginViewModelAsync(string returnUrl, AuthorizationRequest context)
        {
            var allowLocal = true;
            if (context?.ClientId != null)
            {
                var client = await _clientStore.FindEnabledClientByIdAsync(context.ClientId);
                if (client != null)
                {
                    allowLocal = client.EnableLocalLogin;
                }
            }

            return new LoginViewModel
            {
                ReturnUrl = returnUrl,
                Email = context?.LoginHint,
            };
        }

        private async Task<LoginViewModel> BuildLoginViewModelAsync(LoginViewModel model)
        {
            var context = await _interaction.GetAuthorizationContextAsync(model.ReturnUrl);
            var vm = await BuildLoginViewModelAsync(model.ReturnUrl, context);
            vm.Email = model.Email;
            vm.RememberMe = model.RememberMe;
            vm.Message = model.Message;
            return vm;
        }


        [HttpGet]
        public async Task<IActionResult> Logout(string logoutId)
        {
            if (User.Identity.IsAuthenticated == false)
            {
                // if the user is not authenticated, then just show logged out page
                return await Logout(new LogoutViewModel { LogoutId = logoutId });
            }

            //Test for Xamarin. 
            var context = await _interaction.GetLogoutContextAsync(logoutId);
            if (context?.ShowSignoutPrompt == false)
            {
                //it's safe to automatically sign-out
                return await Logout(new LogoutViewModel { LogoutId = logoutId });
            }

            // show the logout prompt. this prevents attacks where the user 
            // is automatically signed out by another malicious web page.
            var vm = new LogoutViewModel
            {
                LogoutId = logoutId
            };
            return View(vm);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Logout(LogoutViewModel model)
        {
            var idp = User?.FindFirst(JwtClaimTypes.IdentityProvider)?.Value;

            if (idp != null && idp != IdentityServerConstants.LocalIdentityProvider)
            {
                if (model.LogoutId == null)
                {
                    model.LogoutId = await _interaction.CreateLogoutContextAsync();
                }

                string url = "/Auth/Logout?logoutId=" + model.LogoutId;

                try
                {
                    await HttpContext.SignOutAsync(idp, new AuthenticationProperties
                    {
                        RedirectUri = url
                    });
                }
                catch (Exception ex)
                {

                }
            }
            await HttpContext.SignOutAsync();
            await HttpContext.SignOutAsync(IdentityConstants.ApplicationScheme);
            HttpContext.User = new ClaimsPrincipal(new ClaimsIdentity());
            var logout = await _interaction.GetLogoutContextAsync(model.LogoutId);
            return Redirect(logout?.PostLogoutRedirectUri);
        }

        [HttpGet]
        public async Task<IActionResult> ForgotPassword(string returnUrl)
        {
            var context = await _interaction.GetAuthorizationContextAsync(returnUrl);
            if (context?.IdP != null)
            {
                throw new NotImplementedException("External login is not implemented!");
            }

            var result = await _userService.GetFloristThemeIds(50);
            var vm = await BuildLoginViewModelAsync(returnUrl, context);
            vm.ThemeId = result.KeyId;
            ViewData["ReturnUrl"] = returnUrl;
            return View(vm);

            //return View();
        }

        [HttpPost]
        public async Task<IActionResult> ForgotPassword(ForgotPasswordViewModel forgotPasswordViewModel)
        {
            if (!ModelState.IsValid)
                return View(forgotPasswordViewModel);

            var user = await _userManager.FindByEmailAsync(forgotPasswordViewModel.Email);
            if (forgotPasswordViewModel.Email == null)
                return RedirectToAction(nameof(forgotPasswordViewModel));

            var token = await _userManager.GeneratePasswordResetTokenAsync(user);
            var callback = Url.Action(nameof(ResetPassword), "AuthController", new { token, email = user.Email }, Request.Scheme);

            IEmailNotification<ForgotPassword> emailNotification = new EmailNotifaction<ForgotPassword>(Credientials);
            await emailNotification.Send(
                new ForgotPassword() { tutorname = user.Email, token = token },
                user.Email,
                "ForgotPassword",
                "ForgotPassword");
            //return Ok();
            //var message = new Message(new string[] { "codemazetest@gmail.com" }, "Reset password token", callback, null);
            //await _emailSender.SendEmailAsync(message);

            return RedirectToAction(nameof(ForgotPasswordConfirmation));
        }
        public IActionResult ForgotPasswordConfirmation()
        {
            return View();
        }

        [HttpGet]
        public IActionResult ResetPassword(string token, string email)
        {
            var model = new ResetPasswordViewModel { Code = token, Email = email };
            return View(model);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ResetPassword(ResetPasswordViewModel resetPasswordViewModel)
        {
            if (!ModelState.IsValid)
                return View(resetPasswordViewModel);
            var user = await _userManager.FindByEmailAsync(resetPasswordViewModel.Email);
            if (user == null)
                RedirectToAction(nameof(ResetPasswordConfirmation));
            var resetPassResult = await _userManager.ResetPasswordAsync(user, resetPasswordViewModel.Code, resetPasswordViewModel.Password);
            if (!resetPassResult.Succeeded)
            {
                foreach (var error in resetPassResult.Errors)
                {
                    ModelState.TryAddModelError(error.Code, error.Description);
                }
                return View();
            }
            return RedirectToAction(nameof(ResetPasswordConfirmation));
        }
        [HttpGet]
        public IActionResult ResetPasswordConfirmation()
        {
            return View();
        }

        //[HttpGet]
        // public IActionResult ChangePassword()
        // {
        //     return View();
        // }

        // [HttpPost("ChangePassword")]
        // public async Task<IActionResult> ChangePassword(ChangePasswordViewModel model)
        // {
        //     if (ModelState.IsValid)
        //     {
        //         var user = await _userManager.FindByEmailAsync(model.Email);
        //         if (user == null)
        //         {
        //             return RedirectToAction("Login");
        //         }
        //         var result = await _userManager.ChangePasswordAsync(user, model.OldPassword, model.NewPassword);
        //         if (!result.Succeeded)
        //         {
        //             foreach (var error in result.Errors)
        //             {
        //                 ModelState.AddModelError(model.OldPassword, error.Description);
        //             }
        //             return View(model);
        //         }
        //         return View("ChangePasswordConfirmation");
        //     }
        //     return View(model);
        //}
    }
}